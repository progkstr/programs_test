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
    public partial class Add_Employee : Form
    {
        public Add_Employee() // необходимо проводить проверку при добавлении сотруника на наличие его в списке.
        {
            InitializeComponent();
            t_Position.Items.Add("Администратор");
            t_Position.Items.Add("Бариста");
            t_Position.Items.Add("Повар");
            t_Position.Items.Add("Официант_1");
            t_Position.Items.Add("Хостес");
        }

        private void Close_f_Click(object sender, EventArgs e)
        {

        }
    }
}
