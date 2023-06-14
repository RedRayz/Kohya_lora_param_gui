using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kohya_lora_trainer {
    public static class CheckUtil {

        /// <summary>
        /// ASCII文字またはスペースが入っているか確認
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
     public static bool HaveNonAsciiOrSpace(string text) {
            if (string.IsNullOrEmpty(text))
                return false;
            if (text.Contains(" "))
                return true;

            Regex regex = new Regex(@"^[\u0000-\u007f]*$");
            if (regex.IsMatch(text)) {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 教師画像フォルダの構造が要件を満たしているかどうか
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ccnt">合計画像枚数</param>
        /// <returns></returns>
        public static bool IsValidImageFolder(string path, out int ccnt) {
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) {
                ccnt = 0;
                return false;
            }

            string[] dc = Directory.GetDirectories(path);
            ccnt = 0;
            if (dc.Length == 0) {
                return false;
            }
            else {
                foreach (string dc2 in dc) {
                    string str = dc2.Remove(0, dc2.LastIndexOf('\\') + 1);
                    int idx = str.IndexOf("_");
                    if (idx > 0) {
                        str = str.Remove(idx);
                        int num = 0;
                        if (int.TryParse(str, out num) && num > 0) {
                            string[] files = Directory.GetFiles(dc2);
                            int fileCnt = 0;
                            Regex reg = new Regex(@"png|jpg|jpeg|webp|bmp|PNG|JPG|JPEG|WEBP|BMP");
                            foreach (string file in files) {
                                if (reg.IsMatch(Path.GetExtension(file))) {
                                    fileCnt++;
                                }
                            }
                            ccnt += num * fileCnt;

                        }
                        else {
                            return false;
                        }
                    }
                    else {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 0以上の実数かどうか。0以下、NaN、無限の場合はfalse。それ以外はtrue
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsValidNum(float num) {
            if(num<= 0 || float.IsNaN(num) || float.IsInfinity(num)) 
                return false;
            return true;
        }

    }


}
