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
    }
}
