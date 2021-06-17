using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KepwareClient
{
    public partial class FormSettings : Form
    {
        OPCSettings settings;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            settings.OPCURL = textBoxOPCAddress.Text;
            int timeOut = 0;
            Int32.TryParse(textBoxOPCTimeOut.Text, out timeOut);
            settings.TimeOut = timeOut;

            try
            {
                StreamWriter sw = new StreamWriter("D:\\OPCSettings.txt", false, Encoding.ASCII);
                sw.WriteLine("Address:"+textBoxOPCAddress.Text);
                sw.WriteLine("TimeOut:" + textBoxOPCTimeOut.Text);
                sw.WriteLine("Port:" + textBoxPort.Text);
                sw.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            finally
            {

            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxOPCAddress.Text = settings.OPCURL;
            textBoxOPCTimeOut.Text = settings.TimeOut.ToString();
        }
        public void SetSettings(OPCSettings _settings)
        {
            settings = new OPCSettings();
            settings.OPCURL = _settings.OPCURL;
            settings.TimeOut = _settings.TimeOut;
        }
        public OPCSettings GetSettings()
        {
            return settings;
        }
    }
}
