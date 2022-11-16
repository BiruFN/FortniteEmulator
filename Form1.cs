using Microsoft.WindowsAPICodePack.Dialogs;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FortniteEmulator
{
    public partial class Form1 : Form
    {
        public static RestClient restClient = null;
        public static RestRequest restRequest = null;

        public static Process Shipping = null;
        public static Process BattlEye = null;
        public static Process EasyAntiCheat = null;
        public static Process Launcher = null;

        static string exchange = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var installationList = JsonSerializer.Deserialize<EpicInstallLocations>(File.ReadAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\Epic\UnrealEngineLauncher\LauncherInstalled.dat")).InstallationList;
            var installation = installationList.FirstOrDefault((Installation i) => i.AppName == "Fortnite");
            GamePath.Text = installation.InstallLocation;
            foreach (Match version in Regex.Matches(installation.AppVersion, @"[\w-]{2}\.[\w-]{2}"))
            {
                ClientVersion.Text = version.Value;
            }
        }

        private void PathChoose_Click(object sender, EventArgs e)
        {
            using (var cofd = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
            })
            {
                if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }
                else
                {
                    if (!File.Exists($@"{cofd.FileName}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe"))
                    {
                        MessageBox.Show("Fortnite path is wrong", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        GamePath.Text = cofd.FileName;
                    }
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Login.Text == "Login")
            {
                restClient = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token");
                restRequest = new RestRequest(Method.POST);
                restRequest.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
                restRequest.AddParameter("grant_type", "client_credentials");
                var reply = restClient.Execute(restRequest).Content;
                var content = JsonSerializer.Deserialize<DeviceTokenJson>(reply);

                restClient = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/deviceAuthorization");
                restRequest = new RestRequest(Method.POST);
                restRequest.AddHeader("Authorization", $"Bearer {content.access_token}");
                var reply2 = restClient.Execute(restRequest).Content;
                var content2 = JsonSerializer.Deserialize<DeviceCodeJson>(reply2);
                Process.Start(content2.verification_uri_complete);

                Login.Enabled = false;
                int num = 0;
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += (Sender, E) =>
                {
                    if (num < 60)
                    {
                        restClient = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token");
                        restRequest = new RestRequest(Method.POST);
                        restRequest.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
                        restRequest.AddParameter("grant_type", "device_code");
                        restRequest.AddParameter("device_code", content2.device_code);
                        var reply3 = restClient.Execute(restRequest).Content;
                        var content3 = JsonSerializer.Deserialize<DeviceCodeJson>(reply3);
                        if (reply3.Contains("access_token"))
                        {
                            timer.Stop();
                            restClient = new RestClient("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/exchange");
                            restRequest = new RestRequest(Method.GET);
                            restRequest.AddHeader("Authorization", $"bearer {content3.access_token}");
                            var reply4 = restClient.Execute(restRequest).Content;
                            var content4 = JsonSerializer.Deserialize<ExchangeJson>(reply4);
                            exchange = content4.code;
                            displayName.Text = content3.displayName;
                            Login.Text = "Launch";
                            Login.Enabled = true;
                            return;
                        }
                        if (reply3.Contains("errors.com.epicgames.not_found"))
                        {
                            timer.Stop();
                            MessageBox.Show("Verification canceled", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Login.Enabled = true;
                            return;
                        }
                        num++;
                    }
                    else
                    {
                        timer.Stop();
                        MessageBox.Show("Verification timed out", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Login.Enabled = true;
                        return;
                    }
                };
                timer.Start();
                return;
            }

            if (Login.Text == "Launch")
            {
                if (ClientVersion.Text == "")
                {
                    MessageBox.Show("Please enter the client version", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!File.Exists($@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe"))
                {
                    MessageBox.Show("Fortnite path is wrong", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string type = null;
                if (BattlEyeCheck.Checked == true)
                {
                    if (!File.Exists($@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_BE.exe"))
                    {
                        MessageBox.Show("\"FortniteClient-Win64-Shipping_BE.exe\" is missing", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    type = "BattlEye";
                }
                if (EasyAntiCheatCheck.Checked == true)
                {
                    if (!File.Exists($@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_EAC.exe"))
                    {
                        MessageBox.Show("\"FortniteClient-Win64-Shipping_EAC.exe\" is missing", "FortniteEmulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    type = "EasyAntiCheat";
                }
                var clientArgs = Client.GetClientArgs(ClientVersion.Text, type);

                Shipping = new Process
                {
                    StartInfo =
                    {
                        FileName = $@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe",
                        Arguments = $"-AUTH_LOGIN=unused -AUTH_PASSWORD={exchange} -AUTH_TYPE=exchangecode -epicapp=Fortnite -epicenv=Prod -EpicPortal {clientArgs} -skippatchcheck",
                        WorkingDirectory = $@"{GamePath.Text}\FortniteGame\Binaries\Win64"
                    }
                };
                Shipping.Start();

                if (BattlEyeCheck.Checked == true)
                {
                    BattlEye = new Process
                    {
                        StartInfo =
                        {
                            FileName = $@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_BE.exe",
                            CreateNoWindow = true,
                            UseShellExecute = false
                        }
                    };
                    BattlEye.Start();
                    foreach (ProcessThread thread in BattlEye.Threads)
                    {
                        Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                    }
                }

                if (EasyAntiCheatCheck.Checked == true)
                {
                    EasyAntiCheat = new Process
                    {
                        StartInfo =
                        {
                            FileName = $@"{GamePath.Text}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_EAC.exe",
                            CreateNoWindow = true,
                            UseShellExecute = false
                        }
                    };
                    EasyAntiCheat.Start();
                    foreach (ProcessThread thread in EasyAntiCheat.Threads)
                    {
                        Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                    }
                }

                Login.Text = "Close";


                int num = 0;
                System.Timers.Timer timer = new System.Timers.Timer(5000);
                timer.Elapsed += (Sender, E) =>
                {
                    if (num < 1)
                    {
                        if (Login.Text != "Close")
                        {
                            timer.Stop();
                            return;
                        }

                        if (Shipping.HasExited)
                        {
                            timer.Stop();
                            try
                            {
                                BattlEye.Kill();
                            }
                            catch { }
                            try
                            {
                                EasyAntiCheat.Kill();
                            }
                            catch { }
                            Login.Text = "Login";
                            displayName.Text = null;
                            return;
                        }
                    }
                };
                timer.Start();
                return;
            }

            if (Login.Text == "Close")
            {
                Shipping.Kill();
                try
                {
                    BattlEye.Kill();
                }
                catch { }
                try
                {
                    EasyAntiCheat.Kill();
                }
                catch { }
                Login.Text = "Login";
                displayName.Text = null;
            }
        }

        private void BattlEyeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BattlEyeCheck.Checked == true)
            {
                EasyAntiCheatCheck.Checked = false;
            }
            else
            {
                if (EasyAntiCheatCheck.Checked == false)
                {
                    BattlEyeCheck.Checked = true;
                }
            }
        }

        private void EasyAntiCheatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyAntiCheatCheck.Checked == true)
            {
                BattlEyeCheck.Checked = false;
            }
            else
            {
                if (BattlEyeCheck.Checked == false)
                {
                    EasyAntiCheatCheck.Checked = true;
                }
            }
        }
    }

    internal class ConfigJson
    {
        public string accountId { get; set; }
        public string deviceId { get; set; }
        public string secret { get; set; }
        public string path { get; set; }
        public string version { get; set; }
    }

    public class EpicInstallLocations
    {
        public List<Installation> InstallationList { get; set; }
    }

    public class Installation
    {
        public string InstallLocation { get; set; }
        public string NamespaceId { get; set; }
        public string ItemId { get; set; }
        public string ArtifactId { get; set; }
        public string AppVersion { get; set; }
        public string AppName { get; set; }
    }

    public class DeviceTokenJson
    {
        public string access_token { get; set; }
    }

    public class DeviceCodeJson
    {
        public string access_token { get; set; }

        public string displayName { get; set; }

        public string account_id { get; set; }

        public string device_code { get; set; }

        public string verification_uri_complete { get; set; }
    }

    public class ExchangeJson
    {
        public string code { get; set; }
    }
}
