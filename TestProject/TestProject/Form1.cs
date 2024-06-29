using System.Diagnostics;
using System.Net.Http.Headers;

namespace TestProject
{
    public partial class Form : System.Windows.Forms.Form
    {
        static readonly HttpClient client = new HttpClient();

        string ffUrl = "https://download.mozilla.org/?product=firefox-latest-ssl&os=win64&lang=en-US";
        string chUrl = "http://dl.google.com/chrome/install/375.126/chrome_installer.exe";
        string br;

        string dcUrl = "https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x64";
        string dc;

        string stUrl = "https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe";
        string st;

        string dir;

        DialogResult result;

        static List<string> urlList;

        private Point _mouseLoc;

        private void title_EnabledChanged(object sender, EventArgs e)
        {
            title.ForeColor = Color.White;
            browser.BackColor = Color.Transparent;
        }

        private void title_Paint(object sender, PaintEventArgs e)
        {
            dynamic lbl = (Label)sender;
            dynamic drawBrush = new SolidBrush(lbl.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
            title.Text = string.Empty;
            e.Graphics.DrawString("ShellSharp Install Script", lbl.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        public static async Task<string> GetRedirectedUrl(string url)
        {
            var handler = new HttpClientHandler()
            {
                AllowAutoRedirect = false
            };
            string redirectedUrl = null;

            using (HttpClient client = new HttpClient(handler))
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    HttpResponseHeaders headers = response.Headers;
                    if (headers != null && headers.Location != null)
                    {
                        redirectedUrl = headers.Location.AbsoluteUri;
                    }
                }
            }

            return redirectedUrl;
        }

        public static string UrlToFileName(string url)
        {
            Uri uri = new Uri(url);
            string fileName = Path.GetFileName(uri.LocalPath);
            return SanitizeFileName(fileName);
        }

        public static string SanitizeFileName(string fileName)
        {
            // Replace spaces with underscores
            fileName = fileName.Replace(" ", "_");

            // Remove invalid file name characters
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c.ToString(), string.Empty);
            }

            return fileName;
        }

        public Form()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Show();
        }

        private async void install_Click(object sender, EventArgs e)
        {
            string urlCollection = $"{br},{dc},{st}";
            urlList = urlCollection.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            if (result == DialogResult.OK || result == DialogResult.Continue || result == DialogResult.Yes)
            {
                foreach (string url in urlList)
                {
                    string redirectedUrl = await GetRedirectedUrl(url);
                    string fileName;
                    if (url.EndsWith(".exe"))
                    {
                        fileName = UrlToFileName(url);
                    }
                    else fileName = UrlToFileName(redirectedUrl);

                    var directory = new DirectoryInfo(folderDialog.SelectedPath);

                    Debug.WriteLine($"Redirected URL: {fileName}");

                    richTextBox1.Text = $"installing {fileName}...\r\n";
                    using (var client = new HttpClient())
                    {
                        using (var s = client.GetStreamAsync(url))
                        {
                            using (var fs = new FileStream(directory + "/" + fileName, FileMode.OpenOrCreate))
                            {
                                s.Result.CopyTo(fs);
                            }
                        }
                    }

                    richTextBox1.AppendText(" installed\r\n");
                }
            }
            else
            {
                richTextBox1.Text = "No Path Selected";
            }
        }

        private void chdir_Click(object sender, EventArgs e)
        {
            result = folderDialog.ShowDialog();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            title.BackColor = title.BackColor;
            title.ForeColor = title.ForeColor;
        }

        private void browser_CheckedChanged(object sender, EventArgs e)
        {
            if (browser.Checked)
            {
                browserDropdown.Enabled = true;
                browserDropdown.SelectedIndex = 0;
            }
            else
            {
                browserDropdown.Enabled = false;
                br = "";
            }
        }

        private void browserDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (browserDropdown.SelectedIndex == 0)
            {
                br = ffUrl;
            }
            else
            {
                br = chUrl;
            }
        }

        private void discord_CheckedChanged(object sender, EventArgs e)
        {
            if (discord.Checked) dc = dcUrl;
            else dc = "";
        }

        private void steam_CheckedChanged(object sender, EventArgs e)
        {
            if (steam.Checked) st = stUrl;
            else st = "";
        }
    }
}
