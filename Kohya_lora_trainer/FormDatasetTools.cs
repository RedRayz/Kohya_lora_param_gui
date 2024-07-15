using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohya_lora_trainer
{
    public partial class FormDatasetTools : Form
    {
        public FormDatasetTools()
        {
            InitializeComponent();
        }

        private void cbxUseRegEx_CheckedChanged(object sender, EventArgs e)
        {
            btnAddTag.Enabled = !cbxUseRegEx.Checked;
        }

        private void btnShuffleCaptions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("シャッフルしますか。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblProcessing.Visible = true;
                Update();
                bool success = MyUtils.ShuffleCaptions(tbxTargetDir.Text, (int)nudKeepTokens.Value, true);
                lblProcessing.Visible = false;
                if (success)
                    ShowDoneMsg();
            }
        }

        private void ShowDoneMsg()
        {
            MessageBox.Show("完了しました。", "おしらせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDatasetTools_Load(object sender, EventArgs e)
        {
            lblProcessing.Visible = false;
        }

        private void btnConvertToWD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("変換しますか。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text))
                {
                    MessageBox.Show("ディレクトリが見つかりません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
                {
                    MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                lblProcessing.Visible = true;
                Update();

                int convertedCnt = 0;
                string[] files = Directory.GetFiles(tbxTargetDir.Text);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);
                    if (txt.Contains(", "))
                        continue;


                    List<string> tags = new List<string>(txt.Split(" "));

                    if (tags.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        string str = sb.ToString();
                        str = str.Replace("_", " ");
                        File.WriteAllText(file, str);
                        convertedCnt++;
                    }

                }

                if (convertedCnt > 0)
                    MessageBox.Show($"{convertedCnt}件のキャプションを処理しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblProcessing.Visible = false;
            }
        }

        private void btnTagToHead_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
            {
                MessageBox.Show("ディレクトリが見つからないかタグが未入力です。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("指定したタグを先頭に移動させます。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
                {
                    return;
                }
                lblProcessing.Visible = true;
                Update();
                int movedCnt = 0;
                string booru = tbxBooruTag.Text;
                string[] files = Directory.GetFiles(tbxTargetDir.Text);
                Regex? reg = null;
                if (cbxUseRegEx.Checked)
                {
                    try
                    {
                        reg = new Regex(booru, RegexOptions.Compiled, TimeSpan.FromMilliseconds(16));
                    }
                    catch
                    {
                        MessageBox.Show("正規表現の文法が間違っています。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblProcessing.Visible = false;
                        return;
                    }
                }

                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);
                    if (reg == null && !txt.Contains(booru))
                        continue;


                    List<string> tags = new List<string>(txt.Split(", "));
                    int targetIdx = -1;
                    if (cbxUseRegEx.Checked && reg != null)
                    {
                        for (int i = 0; i < tags.Count; i++)
                        {
                            try
                            {
                                if (reg.IsMatch(tags[i]))
                                {
                                    targetIdx = i;
                                }
                            }
                            catch
                            {
                                Debug.WriteLine("Regex timed out");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        targetIdx = tags.IndexOf(booru);
                    }



                    if (targetIdx != -1 && targetIdx > 0)
                    {
                        string tmp = tags[targetIdx];

                        tags.RemoveAt(targetIdx);
                        tags.Insert(0, tmp);
                        movedCnt++;
                    }
                    else
                        continue;


                    if (tags.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        File.WriteAllText(file, sb.ToString());
                    }

                }
                lblProcessing.Visible = false;
                if (movedCnt > 0)
                    MessageBox.Show($"{movedCnt}件のタグを処理しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxTargetDir_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedDirectoryName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxTargetDir.Text = dropped;
            }
        }

        private void tbxTargetDir_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonDirectoryDragEvent(e);
        }

        private void tbxSourceDir_DragDrop(object sender, DragEventArgs e)
        {
            string dropped = MyUtils.GetDroppedDirectoryName(e);
            if (!string.IsNullOrEmpty(dropped))
            {
                tbxSourceDir.Text = dropped;
            }
        }

        private void tbxSourceDir_DragEnter(object sender, DragEventArgs e)
        {
            MyUtils.CommonDirectoryDragEvent(e);
        }

        private void btnRemoveImgWithTag_Click(object sender, EventArgs e)
        {
            string sourceDir = tbxTargetDir.Text;
            string boorutag = tbxBooruTag.Text;
            int removedCnt = 0;
            int errorCount = 0;
            int removedimgCnt = 0;

            if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
            {
                MessageBox.Show("ディレクトリが見つからないかタグが未入力です。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("同階層にtrashフォルダを作成し、そこに移動させます。\r\nよろしいですか。", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                lblProcessing.Visible = true;
                Update();
                Regex? reg = null;
                if (cbxUseRegEx.Checked)
                {
                    try
                    {
                        reg = new Regex(boorutag, RegexOptions.Compiled, TimeSpan.FromMilliseconds(16));
                    }
                    catch
                    {
                        MessageBox.Show("正規表現の文法が間違っています。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblProcessing.Visible = false;
                        return;
                    }
                }
                //キャプションが入った場所
                string[] files = Directory.GetFiles(sourceDir);
                foreach (string file in files)
                {
                    try
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext == ".txt")
                        {
                            string path = sourceDir + "\\";
                            string captionFile = Path.GetFileNameWithoutExtension(file);
                            string txt = File.ReadAllText(file);

                            List<string> tags = new List<string>(txt.Split(", "));
                            foreach (string tag in tags)
                            {
                                bool match = false;

                                if (cbxUseRegEx.Checked)
                                {
                                    match = reg != null && reg.IsMatch(tag);
                                }
                                else
                                {
                                    match = tag == boorutag;

                                }

                                if (match)
                                {
                                    if (!File.Exists(sourceDir + "\\trash\\" + captionFile + ".txt"))
                                    {
                                        //FileSystem.DeleteFileは重いので使わない
                                        if (!Directory.Exists(sourceDir + "\\trash"))
                                        {
                                            Directory.CreateDirectory(sourceDir + "\\trash");
                                        }
                                        File.Move(file, sourceDir + "\\trash\\" + captionFile + ".txt");
                                        removedCnt++;
                                    }

                                    string imgPath = string.Empty;
                                    string imgName = string.Empty;
                                    if (File.Exists(path + captionFile + ".png"))
                                    {
                                        imgPath = path + captionFile + ".png";
                                        imgName = captionFile + ".png";
                                    }
                                    else if (File.Exists(path + captionFile + ".jpg"))
                                    {
                                        imgPath = path + captionFile + ".jpg";
                                        imgName = captionFile + ".jpg";
                                    }
                                    else if (File.Exists(path + captionFile + ".jpeg"))
                                    {
                                        imgPath = path + captionFile + ".jpeg";
                                        imgName = captionFile + ".jpeg";
                                    }
                                    if (File.Exists(imgPath) && !File.Exists(path + "\\trash\\" + imgName))
                                    {
                                        if (!Directory.Exists(path + "\\trash"))
                                        {
                                            Directory.CreateDirectory(path + "\\trash");
                                        }
                                        File.Move(imgPath, path + "\\trash\\" + imgName);
                                        removedimgCnt++;
                                    }
                                }
                            }



                        }
                    }
                    catch
                    {
                        errorCount++;
                    }
                }

                lblProcessing.Visible = false;

                if (removedCnt > 0)
                    MessageBox.Show($"{removedCnt}件のテキストと\r\n {removedimgCnt}件の画像をtrashフォルダに移動しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (errorCount > 0)
                {
                    MessageBox.Show($"{errorCount}件がエラーで失敗しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
            {
                MessageBox.Show("ディレクトリが見つからないかタグが未入力です。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("指定したタグをtxtファイルから削除します。よろしいですか。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
                {
                    return;
                }
                lblProcessing.Visible = true;
                Update();
                int movedCnt = 0;
                string booru = tbxBooruTag.Text;
                string[] files = Directory.GetFiles(tbxTargetDir.Text);
                Regex? reg = null;
                if (cbxUseRegEx.Checked)
                {
                    try
                    {
                        reg = new Regex(booru, RegexOptions.Compiled, TimeSpan.FromMilliseconds(16));
                    }
                    catch
                    {
                        MessageBox.Show("正規表現の文法が間違っています。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblProcessing.Visible = false;
                        return;
                    }
                }
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);
                    if (reg == null && !txt.Contains(booru))
                        continue;


                    List<string> tags = new List<string>(txt.Split(", "));
                    int targetIdx = -1;
                    if (cbxUseRegEx.Checked && reg != null)
                    {
                        for (int i = 0; i < tags.Count; i++)
                        {
                            try
                            {
                                if (reg.IsMatch(tags[i]))
                                {
                                    targetIdx = i;
                                }
                            }
                            catch
                            {
                                Debug.WriteLine("Regex timed out");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        targetIdx = tags.IndexOf(booru);
                    }

                    if (targetIdx != -1)
                    {
                        tags.RemoveAt(targetIdx);
                        movedCnt++;
                    }
                    else
                        continue;


                    if (tags.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        File.WriteAllText(file, sb.ToString());
                    }

                }
                lblProcessing.Visible = false;
                if (movedCnt > 0)
                    MessageBox.Show($"{movedCnt}件のファイルを処理しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowTagCnt_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
            {
                MessageBox.Show("ディレクトリが見つからないかタグが未入力です。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("出現回数を確認します。よろしいですか。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
                {
                    return;
                }
                lblProcessing.Visible = true;
                Update();
                int movedCnt = 0;
                int captionCnt = 0;
                string booru = tbxBooruTag.Text;
                Regex? reg = null;
                if (cbxUseRegEx.Checked)
                {
                    try
                    {
                        reg = new Regex(booru, RegexOptions.Compiled, TimeSpan.FromMilliseconds(16));
                    }
                    catch
                    {
                        MessageBox.Show("正規表現の文法が間違っています。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblProcessing.Visible = false;
                        return;
                    }
                }

                if (reg != null && reg.IsMatch("4girls"))
                {
                    Debug.WriteLine("test matched");
                }

                string[] files = Directory.GetFiles(tbxTargetDir.Text);

                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    captionCnt++;

                    string txt = File.ReadAllText(file);
                    if (reg == null && !txt.Contains(booru))
                        continue;


                    List<string> tags = new List<string>(txt.Split(", "));
                    int targetIdx = -1;
                    if (reg != null)
                    {
                        for (int i = 0; i < tags.Count; i++)
                        {
                            try
                            {
                                if (reg.IsMatch(tags[i]))
                                {
                                    targetIdx = i;
                                    //Debug.WriteLine("Matched: \"" + tags[i] + '"');
                                }
                            }
                            catch
                            {
                                Debug.WriteLine("Regex timed out");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        targetIdx = tags.IndexOf(booru);
                    }

                    if (targetIdx != -1)
                    {
                        movedCnt++;
                    }
                    else
                        continue;


                }
                lblProcessing.Visible = false;
                if (captionCnt > 0)
                {
                    double percent = (double)movedCnt / (double)captionCnt;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(captionCnt).Append("件中").Append(movedCnt).Append("件にあります。(割合は").Append(percent.ToString("0.00%")).Append(')');
                    MessageBox.Show(sb.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GC.Collect();
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
            {
                MessageBox.Show("ディレクトリが見つからないかタグが未入力です。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(tbxTargetDir.Text))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("指定したタグを最後尾に追加します。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text) || string.IsNullOrEmpty(tbxBooruTag.Text))
                {
                    return;
                }
                lblProcessing.Visible = true;
                Update();
                int movedCnt = 0;
                string booru = tbxBooruTag.Text;
                string[] files = Directory.GetFiles(tbxTargetDir.Text);

                if (cbxUseRegEx.Checked)
                {
                    MessageBox.Show("正規表現のチェックを外してください。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblProcessing.Visible = false;
                    return;
                }


                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);
                    if (txt.Contains(booru))
                        continue;


                    List<string> tags = new List<string>(txt.Split(", "));

                    if (tags.Count > 0)
                    {
                        tags.Add(booru);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        File.WriteAllText(file, sb.ToString());
                        movedCnt++;
                    }

                }
                lblProcessing.Visible = false;
                if (movedCnt > 0)
                    MessageBox.Show($"{movedCnt}件のファイルに追加しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveDupNameImg_Click(object sender, EventArgs e)
        {
            string sourceDir = tbxSourceDir.Text;


            int removedCnt = 0;
            int errorCount = 0;

            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("ディレクトリが見つかりません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(sourceDir))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("同名のpngとjpgがある場合にjpgを同階層のtrashフォルダに移動させます。\r\nよろしいですか。", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblProcessing.Visible = true;
                Update();
                //キャプションが入った場所
                string[] files = Directory.GetFiles(sourceDir);
                foreach (string file in files)
                {
                    try
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext == ".png")
                        {
                            string path = sourceDir + "\\";
                            string captionFile = Path.GetFileNameWithoutExtension(file);

                            if (File.Exists(path + captionFile + ".jpg") && !File.Exists(sourceDir + "\\trash\\" + captionFile + ".jpg"))
                            {
                                //FileSystem.DeleteFileは重いので使わない
                                if (!Directory.Exists(sourceDir + "\\trash"))
                                {
                                    Directory.CreateDirectory(sourceDir + "\\trash");
                                }
                                File.Move(path + captionFile + ".jpg", sourceDir + "\\trash\\" + captionFile + ".jpg");
                                removedCnt++;
                            }


                        }
                    }
                    catch
                    {
                        errorCount++;
                    }
                }

                lblProcessing.Visible = false;

                if (removedCnt > 0)
                    MessageBox.Show($"{removedCnt}件の画像をtrashフォルダに移動しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (errorCount > 0)
                {
                    MessageBox.Show($"{errorCount}件がエラーで失敗しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            GC.Collect();
        }

        private void btnRemoveImgNoCap_Click(object sender, EventArgs e)
        {
            string sourceDir = tbxSourceDir.Text;
            int removedCnt = 0;
            int errorCount = 0;
            bool deleteImmediately = cbxDeleteImmediately.Checked;

            if (!Directory.Exists(sourceDir) || !Directory.Exists(sourceDir))
            {
                MessageBox.Show("ディレクトリが見つかりません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MyUtils.IsSystemDirectory(sourceDir))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("キャプションファイルだけで画像がないものを同階層のtrashフォルダに移動または完全に消去します。よろしいですか。", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (deleteImmediately && MessageBox.Show("完全に消去します。よろしいですか。", "確認", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }


                lblProcessing.Visible = true;
                Update();
                //キャプションが入った場所
                string[] files = Directory.GetFiles(sourceDir);
                foreach (string file in files)
                {
                    try
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext == ".txt")
                        {
                            string path = sourceDir + "\\";
                            string captionFile = Path.GetFileNameWithoutExtension(file);
                            //同名の画像がない
                            if (!File.Exists(sourceDir + "\\" + captionFile + ".png") && !File.Exists(sourceDir + "\\" + captionFile + ".jpg") && !File.Exists(sourceDir + "\\" + captionFile + ".jpeg"))
                            {
                                if (deleteImmediately)
                                {
                                    File.Delete(file);
                                    removedCnt++;
                                }
                                else
                                if (!File.Exists(sourceDir + "\\trash\\" + captionFile + ".txt"))
                                {
                                    if (!Directory.Exists(sourceDir + "\\trash"))
                                    {
                                        Directory.CreateDirectory(sourceDir + "\\trash");
                                    }
                                    //FileSystem.DeleteFileは重いので使わない
                                    File.Move(file, sourceDir + "\\trash\\" + captionFile + ".txt");
                                    removedCnt++;
                                }

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        errorCount++;
                    }
                }

                lblProcessing.Visible = false;

                if (removedCnt > 0)
                    MessageBox.Show($"{removedCnt}件の画像をtrashフォルダに移動または消去しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("対象のファイルはありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (errorCount > 0)
                {
                    MessageBox.Show($"{errorCount}件がエラーで失敗しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteTrash_Click(object sender, EventArgs e)
        {
            string sourceDir = tbxSourceDir.Text;

            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("ディレクトリが見つかりません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MyUtils.IsSystemDirectory(sourceDir))
            {
                MessageBox.Show("データ破損防止のため、OS関連のディレクトリは指定できません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("trashフォルダを消去します。よろしいですか。\nサブディレクトリがある場合はtrash直下のファイル消去のみとなります。", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string trashDir = sourceDir + @"\trash";

                if (!Directory.Exists(trashDir))
                {
                    MessageBox.Show("trashフォルダがありません。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    string[] files = Directory.GetFiles(trashDir);
                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }
                }
                catch
                {
                    MessageBox.Show("エラーで失敗しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Directory.GetFiles(trashDir).Length == 0 && Directory.GetDirectories(trashDir).Length == 0)
                {
                    Directory.Delete(trashDir);
                    MessageBox.Show("完了しました。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
