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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void buttonExitInMenu_BDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain FormM = new FormMain();
            FormM.Show();
        }

        private void buttonQuiqGuide_BDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В этом приложении вы сможете вести свой личный читательский дневник. Записывать новые данные о прочтенных книгах и сохранять их. Интерфейс специально сделан упрощенным для удобства использования.");
        }

        private void buttonInform_BDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение выполнила Борисова Диана Сергеевна, ученица 1 курса Тюменского Индустриального Университета.");
        }
    }
}
