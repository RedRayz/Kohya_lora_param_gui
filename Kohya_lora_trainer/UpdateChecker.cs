using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using Microsoft.Win32;

namespace Kohya_lora_trainer
{
    internal static class UpdateChecker
    {
        static readonly HttpClient client = new HttpClient();
        private static bool IsFirstTime = true;
        
        internal static bool CheckUpdate()
        {
            try
            {
                //二回目以降はプロパティを変更できない
                if(IsFirstTime)
                    client.Timeout = new TimeSpan(0, 0, 5);
                IsFirstTime = false;

                var response = client.GetAsync("https://raw.githubusercontent.com/RedRayz/Kohya_lora_param_gui/master/version.txt").Result;
                var statusCode = response.StatusCode;

                if (statusCode != HttpStatusCode.OK)
                {
                    return false;
                }
                string? result = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrWhiteSpace(result))
                {
                    string appVer = Application.ProductVersion;
                    Debug.WriteLine("Local app version: " + appVer);
                    Debug.WriteLine("Remote version: " + result);
                    string[] remoteVerText = result.Split('.');

                    List<int> remoteVerList = new List<int>();
                    for (int i = 0; i < remoteVerText.Length; i++)
                    {
                        if (int.TryParse(remoteVerText[i], out int ver))
                        {
                            remoteVerList.Add(ver);
                        }
                    }

                    

                    string[] appVerText = appVer.Split(".");

                    List<int> appVerList = new List<int>();
                    for (int i = 0; i < appVerText.Length; i++)
                    {
                        if (int.TryParse(appVerText[i], out int ver))
                        {
                            appVerList.Add(ver);
                        }
                    }

                    if (remoteVerList.Count == appVerList.Count)
                    {
                        for (int i = 0; i < remoteVerList.Count; i++)
                        {
                            if (appVerList[i] < remoteVerList[i])
                            {
                                Debug.WriteLine("New update available.");
                                return true;
                            }
                            else if (appVerList[i] > remoteVerList[i])
                            {
                                return false;
                            }

                        }
                    }

                }
                return false;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Update check failed. See below:");
                Debug.WriteLine(ex.ToString());
                return false;
            }

        }

        internal static void AutomaticCheckUpdate()
        {
            int? checkInterval = (int?)Registry.GetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "UpdateCheckInterval", 7);
            if(checkInterval == null)
            {
                Debug.WriteLine("Auto update check failed: checkInterval is null.");
                return;
            }

            if (checkInterval == 0)
                return;

            DateTime current = DateTime.Today;
            
            string? lastCheckedDateText = (string?)Registry.GetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "LastUpdateCheckDate", string.Empty);
            
            if (string.IsNullOrEmpty(lastCheckedDateText))
            {
                lastCheckedDateText = "2023-01-01T12:00:00.0000000+09:00";
            }

            if(DateTime.TryParse(lastCheckedDateText, out DateTime lastCheckedDate))
            {
                TimeSpan span = current - lastCheckedDate;
                //Debug.WriteLine("最後のアプデ確認からの経過日: " + span.TotalDays.ToString());
                if(span.TotalDays >= checkInterval)
                {
                    bool updateAvailable = CheckUpdate();
                    if (updateAvailable)
                    {
                        if (MessageBox.Show("新しいバージョンのGUIが利用可能です。\r\nGUIの配布ページを開きますか?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                //.NET CoreではUseShellExecute=trueにしないとファイルがないと怒る
                                Process.Start(new ProcessStartInfo
                                {
                                    UseShellExecute = true,
                                    FileName = "https://github.com/RedRayz/Kohya_lora_param_gui/releases",
                                });
                            }
                            catch
                            {
                                MessageBox.Show("ブラウザを開けません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\kohya_lora_gui", "LastUpdateCheckDate", current.ToString("O"));
        }

    }
}
