using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace KepwareClient
{
    public partial class FormMain : Form
    {
        bool IsConnected = false;
        OPCSettings settings;
        Kepware.ClientAce.OpcDaClient.DaServerMgt DAserver = new Kepware.ClientAce.OpcDaClient.DaServerMgt();
        Kepware.ClientAce.OpcDaClient.ConnectInfo connectInfo = new Kepware.ClientAce.OpcDaClient.ConnectInfo();
        bool connectFailed;
        int activeServerSubscriptionHandle;
        int clientSubscriptionHandle;
        string url;
        //ItemIdentifier[] itemIdentifiers = new ItemIdentifier[5];

        private string _PathToDB = "dbmonitoring.db";
        private string _ConnectionString;
        private SQLiteConnection _SqliteConnection;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings frmSettings = new FormSettings();
            frmSettings.SetSettings(settings);
            if (frmSettings.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.OPCURL = frmSettings.GetSettings().OPCURL;
                settings.TimeOut = frmSettings.GetSettings().TimeOut;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            int clientHandle = 1;
            try
            {
                DAserver.Connect(url, clientHandle, ref connectInfo, out connectFailed);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка подключения. Причина: " + ex.Message);
                Random r = new Random();
                textBoxRamp.Text = Math.Sin(r.Next()).ToString();
                textBoxRandom.Text = r.Next().ToString();
                textBoxSine.Text = Math.Sin(r.Next()).ToString();
                connectFailed = true;
            }
            if (connectFailed)
            {
                //MessageBox.Show("Ошибка подключения");
            } else
            {
                buttonConnect.Text = "Подключено";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            settings = new OPCSettings();
            //Из документации по ClientAce
            url = "opc.tcp://" + settings.OPCURL + ":" + settings.port;
            connectInfo.LocalId = "en";
            connectInfo.KeepAliveTime = settings.TimeOut;
            connectInfo.RetryAfterConnectionError = true;
            connectInfo.RetryInitialConnection = false;
            connectInfo.ClientName = "CS Simple Client";
            connectFailed = false;

            _ConnectionString = String.Format("Data Source={0};Version=3;", _PathToDB);
            _SqliteConnection = new SQLiteConnection(_ConnectionString);
            _SqliteConnection.Open();
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            if (_SqliteConnection.State == ConnectionState.Closed)
            {
                return;
            }
            Int32 _dateUnix = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            using (SQLiteCommand sqliteCommand = _SqliteConnection.CreateCommand())
            {
                sqliteCommand.CommandText = "INSERT INTO [tbData] (TimeStamp, Ramp1, Rand1, Sin1) VALUES (@pTimeStamp, @pRamp1, @pRand1, @pSin1)";

            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_SqliteConnection.State == ConnectionState.Open)
            {
                _SqliteConnection.Close();
            }

        }
    }
}
