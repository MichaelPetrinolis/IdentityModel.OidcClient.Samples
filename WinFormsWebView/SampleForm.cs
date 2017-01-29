using IdentityModel.OidcClient;
using IdentityModel.OidcClient.WebView.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class SampleForm : Form
    {
        private OidcClient _oidcClient;
        private HttpClient _apiClient;

        public SampleForm()
        {
            InitializeComponent();

            var options = new OidcClientOptions
            {
                Authority = "http://localhost:1941",
                ClientId = "native.hybrid",
                Scope = "openid email philoxenon philoxenon.tenants offline_access",
                RedirectUri = "http://localhost/winforms.client",

                Browser = new WinFormsWebView()
            };

            //var options = new OidcClientOptions(
            //    authority,
            //    "openid email api offline_access",
            //    "http://localhost/winforms.client",
            //    "native", 
            //    "secret", 
            //    new WinFormsWebView());
            //options.UseFormPost = true;

            _oidcClient = new OidcClient(options);
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            AccessTokenDisplay.Clear();
            OtherDataDisplay.Clear();
            IdentityTokenDisplay.Clear();
            TenantsListBox.Items.Clear();

            //var extraParameters = new { acr_values = $"idp:Facebook" };


            var result = await _oidcClient.LoginAsync((Silent.Checked ?
                IdentityModel.OidcClient.Browser.DisplayMode.Hidden :
                IdentityModel.OidcClient.Browser.DisplayMode.Visible));
                 
            if (result.IsError)
            {
                MessageBox.Show(this, result.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccessTokenDisplay.Text = result.AccessToken;
                IdentityTokenDisplay.Text = result.IdentityToken;

                var sb = new StringBuilder(128);
                foreach (var claim in result.User.Claims)
                {
                    sb.AppendLine($"{claim.Type}: {claim.Value}");
                    if (claim.Type == "philoxenon_tenant")
                        TenantsListBox.Items.Add(claim.Value);
                }

                if (!string.IsNullOrWhiteSpace(result.RefreshToken))
                {
                    sb.AppendLine($"refresh token: {result.RefreshToken}");
                }

                OtherDataDisplay.Text = sb.ToString();

                _apiClient = new HttpClient(result.RefreshTokenHandler);
                _apiClient.BaseAddress = new Uri("http://localhost:5412/");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //await _oidcClient.LogoutAsync(trySilent: Silent.Checked);
            //AccessTokenDisplay.Clear();
            //OtherDataDisplay.Clear();
        }

        private async void CallApiButton_Click(object sender, EventArgs e)
        {
            if (_apiClient == null)
            {
                return;
            }

            var result = await _apiClient.GetAsync("identity");
            if (result.IsSuccessStatusCode)
            {
                OtherDataDisplay.Text = JArray.Parse(await result.Content.ReadAsStringAsync()).ToString();
            }
            else
            {
                OtherDataDisplay.Text = result.ReasonPhrase;
            }
        }

        private async void AuthorizeButton_Click(object sender, EventArgs e)
        {
            var selectedTenant = TenantsListBox.SelectedItem;
            AccessTokenDisplay.Clear();
            OtherDataDisplay.Clear();
            IdentityTokenDisplay.Clear();
            TenantsListBox.Items.Clear();

            var options = new OidcClientOptions
            {
                Authority = "http://localhost:1941",
                ClientId = "native.hybrid",
                Scope = "openid email philoxenon offline_access",
                RedirectUri = "http://localhost/winforms.client",
                Browser = new WinFormsWebView()
            };



            //var options = new OidcClientOptions(
            //    authority,
            //    "openid email api offline_access",
            //    "http://localhost/winforms.client",
            //    "native", 
            //    "secret", 
            //    new WinFormsWebView());
            //options.UseFormPost = true;

            var oidcClient = new OidcClient(options);

            //IdentityModel.OidcConstants.AuthorizeRequest.AcrValues

            var extraParameters = new { acr_values = $"tenant:{selectedTenant}" };

            var result = await oidcClient.LoginAsync(displayMode: Silent.Checked ? IdentityModel.OidcClient.Browser.DisplayMode.Hidden : IdentityModel.OidcClient.Browser.DisplayMode.Visible,
                extraParameters: extraParameters);

            if (result.IsError)
            {
                MessageBox.Show(this, result.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccessTokenDisplay.Text = result.AccessToken;
                IdentityTokenDisplay.Text = result.IdentityToken;

                var sb = new StringBuilder(128);
                foreach (var claim in result.User.Claims)
                {
                    sb.AppendLine($"{claim.Type}: {claim.Value}");
                    if (claim.Type == "philoxenon_tenant")
                        TenantsListBox.Items.Add(claim.Value);
                }

                if (!string.IsNullOrWhiteSpace(result.RefreshToken))
                {
                    sb.AppendLine($"refresh token: {result.RefreshToken}");
                }

                OtherDataDisplay.Text = sb.ToString();

                _apiClient = new HttpClient(result.RefreshTokenHandler);
                _apiClient.BaseAddress = new Uri("http://localhost:5412/");
            }
        }
    }
}