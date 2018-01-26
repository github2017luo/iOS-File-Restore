using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace iOS_File_Restore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("files"))
            {
                MessageBox.Show("Nothing to restore");
                Environment.Exit(0);
            }
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = ip.Text,
                UserName = "root",
                Password = pass.Text,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };
            Session session = new Session();
            session.Open(sessionOptions);
            foreach (string dir in Directory.GetDirectories("files"))
            {
                session.PutFiles(dir, "/"); //put directories
            }
            foreach (string file in Directory.GetFiles("files"))
            {
                session.PutFiles(file, "/"); //put files
            }
            session.Close();
            MessageBox.Show("Done");
        }
    }
}
