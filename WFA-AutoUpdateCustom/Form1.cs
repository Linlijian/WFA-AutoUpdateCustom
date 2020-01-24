using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
namespace WFA_AutoUpdateCustom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoUpdater.Start("https://raw.githubusercontent.com/Linlijian/WFA-AutoUpdateCustom/master/WFA-AutoUpdateCustom/CheckUpdate.xml");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start();
            label1.Text = Application.ProductVersion;
        }
    }
}
