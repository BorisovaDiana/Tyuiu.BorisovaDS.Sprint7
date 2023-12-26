using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BorisovaDS.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInformationAboutBooks_BDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIformationAboutBooks_BDS FormAB = new FormIformationAboutBooks_BDS();
            FormAB.Show();
        }

        private void buttonInformation_BDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInformation FormI = new FormInformation();
            FormI.Show();
        }

        private void buttonExit_BDS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
