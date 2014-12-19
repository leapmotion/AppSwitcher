using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppSwitcher
{
    public partial class MainForm : Form
    {
        public string directToRiftExe;
        public string regularExe;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("switcher.xml");

            XmlNode root = doc.DocumentElement;
            for (XmlNode cur = root.FirstChild; cur != null; cur = cur.NextSibling)
            {
                if (cur.Name.CompareTo("WindowTitle") == 0)
                    this.Text = cur.InnerText;
                else if (cur.Name.CompareTo("DirectRiftExe") == 0)
                    directToRiftExe = cur.InnerText;
                else if (cur.Name.CompareTo("RegularExe") == 0)
                    regularExe = cur.InnerText;
            }
        }

        private void OnRegularExeLaunch(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(regularExe);
            this.Close();
        }

        private void OnDirectRiftExeLaunch(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(directToRiftExe);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
