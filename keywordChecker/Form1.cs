using RobotsTxt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keywordChecker
{
    public partial class frmSettings : Form
    {
        WebClient client;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            client = new WebClient();
            var url = txtUrl.Text;
            url = !string.IsNullOrEmpty(url) && Uri.IsWellFormedUriString(url, UriKind.Absolute) ?
                url : "http://www.gametrailers.com";
            var keywords = txtKeywords.Text;
            keywords = !string.IsNullOrEmpty(keywords) ? keywords : "final fantasy";

            if (CheckRobots(url))
            {

                var pageContent = client.DownloadString(url);
                var keywordLocation = pageContent.IndexOf(keywords, StringComparison.InvariantCultureIgnoreCase);

                StringBuilder sb = new StringBuilder();
                if (keywordLocation >= 0)
                {
                    var pageIds = Regex.Matches(pageContent, @"id=""\s*?\S*?""");
                    string matchedId = closestId(keywordLocation, pageIds);
                    string idTag = matchedId.Substring(4, matchedId.Length - 5);
                    brwPreview.Navigate(url + "#" + idTag);

                    sb.AppendFormat("{0} are talking about {1} today.", url, keywords);
                    sb.Append("\n\nSnippet:\n" + pageContent.Substring(keywordLocation, 100));
                    sb.AppendFormat("\n\nClosest id: {0}", idTag);
                }
                else
                {
                    sb.Append("Keyword not found!");
                }
                lblResult.Text = sb.ToString();
            }
            else
            {
                lblResult.Text = "Blocked by robots.txt!";
            }
        }

        private string closestId(int keywordLocation, MatchCollection matchingIds)
        {
            int? closestId = null;
            string closestIdName = null;
            foreach (Match id in matchingIds)
            {
                if (closestId != null)
                {
                    int idDistance = Math.Abs(id.Index - keywordLocation);
                    if (idDistance < closestId.Value)
                    {
                        closestId = idDistance;
                        closestIdName = id.Value;
                    }
                }
                else
                {
                    closestId = Math.Abs(id.Index - keywordLocation);
                    closestIdName = id.Value;
                }
            }
            return closestIdName;
        }

        /// <summary>
        /// Checks if a url is allowed to be spidered by our bot.
        /// </summary>
        /// <param name="url">The url to check.</param>
        /// <returns>True if allowed, false if not.</returns>
        private bool CheckRobots(string url)
        {
            var robotsFileLocation = new Uri(url).GetLeftPart(UriPartial.Authority) + "/robots.txt";
            try
            {
                var robotsFileContent = client.DownloadString(robotsFileLocation);
                Robots robots = Robots.Load(robotsFileContent);
                return robots.IsPathAllowed("keywordChecker", url);
            }
            catch
            {
                return true;
            }
        }
    }
}
