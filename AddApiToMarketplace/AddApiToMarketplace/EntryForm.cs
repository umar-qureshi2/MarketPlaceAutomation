using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddApiToMarketplace
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds API entry to database script on basis of recent most id from script and current formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToDatabaseButton_Click(object sender, EventArgs e)
        {
            status.Text = "Starting";
            try
            {
                string webApisDflt = string.Empty;
                int previousMax = 0;
                string newApiText = "";
                using (StreamReader sr = new StreamReader(@"D:\Trasix\MarketPlace\MP.Database\dbo\InitialData\Script.webapis_dflt.sql"))
                {
                    webApisDflt = sr.ReadToEnd();
                    previousMax = webApisDflt.Split(new string[] { "id =" }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => Regex.IsMatch(x, @".*[0-9]+\)"))
                        .Select(x => x.Trim())
                        .Select(x =>
                        {
                            var index = x.IndexOf(')');
                            var split = x.Substring(0, index);
                            return Convert.ToInt32(split);
                        })
                        .Max();
                    if (previousMax > 0)
                    {
                        var newIndex = ++previousMax;
                        newApiText = $"\r\nIF EXISTS (SELECT 1 FROM dbo.[webapis_dflt] WHERE id = {newIndex}) BEGIN  UPDATE [dbo].[webapis_dflt] SET [discription]=N'{Description.Text}', [RouteName]=N'{ApiName.Text}' WHERE ID = {newIndex} END ELSE BEGIN  INSERT [dbo].[webapis_dflt] (id, [discription], [RouteName])VALUES ({newIndex}, N'{Description.Text}', N'{ApiName.Text}') END";
                    }
                }
                if (previousMax > 0)
                {
                    var newIndex = previousMax;
                    using (StreamWriter sw = new StreamWriter(@"D:\Trasix\MarketPlace\MP.Database\dbo\InitialData\Script.webapis_dflt.sql", true))
                    {
                        sw.Write(newApiText);
                    }

                    string userRolesWebApis = "";
                    using (StreamReader sr = new StreamReader(@"D:\Trasix\MarketPlace\MP.Database\dbo\InitialData\Script.userrole_webapis_relation.sql"))
                    {
                        userRolesWebApis = sr.ReadToEnd();
                        userRolesWebApis = userRolesWebApis.Replace("GO", $"IF NOT EXISTS (SELECT 1 FROM dbo.[userrole_webapis_relation] WHERE [user_role_id] = @roleId  AND [webapiid] ={newIndex})BEGIN INSERT INTO [dbo].[userrole_webapis_relation]([user_role_id],[webapiid],[data_filter],[created_by],[updated_by],[created_date],[update_date],[regularexpression])VALUES(@roleId,{newIndex},NULL,1,1,GETDATE(),GETDATE(),NULL) END\r\nGO");
                    }

                    using (StreamWriter sw = new StreamWriter(@"D:\Trasix\MarketPlace\MP.Database\dbo\InitialData\Script.userrole_webapis_relation.sql"))
                    {
                        sw.Write(userRolesWebApis);
                    }

                }
                status.Text = "done";
            }
            catch (Exception exception)
            {
                status.Text = exception.Message;
                MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
            }
        }
    }
}
