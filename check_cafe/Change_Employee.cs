using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_cafe
{
    public partial class Change_Employee : Form
    {
        public Change_Employee()
        {
            InitializeComponent();
        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            using (Add_Employee f_addEmp = new Add_Employee())  //комментарий аналогичен в форме1, смотри там.
            {
                f_addEmp.ShowDialog();   //открываем форму регистрации нового сотрудника
            }
        }
    }
}
