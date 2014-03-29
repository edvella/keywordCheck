using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keywordChecker
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            var url = txtUrl.Text;
            url = !string.IsNullOrEmpty(url) && Uri.IsWellFormedUriString(url, UriKind.Absolute) ?
                url : "http://www.gametrailers.com";
            var keywords = txtKeywords.Text;
            keywords = !string.IsNullOrEmpty(keywords) ? keywords : "final fantasy";
            var pageContent = client.DownloadString(url);
            var keywordLocation = pageContent.IndexOf(keywords, StringComparison.OrdinalIgnoreCase);

            StringBuilder sb = new StringBuilder();
            if (keywordLocation >= 0)
            {
                sb.AppendFormat("{0} are talking about {1} today.", url, keywords);
                sb.Append("\n\nSnippet:\n" + pageContent.Substring(keywordLocation, 100));

                brwPreview.Navigate(url);
            }
            else
            {
                sb.Append("Keyword not found!");
            }
            lblResult.Text = sb.ToString();
        }
    }
}
