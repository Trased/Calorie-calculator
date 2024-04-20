using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_PROJECT
{
    public partial class LogFoodForm : Form
    {
        public LogFoodForm()
        {
            InitializeComponent();
            this.FormClosing += CloseApp;
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
