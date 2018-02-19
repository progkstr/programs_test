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
    public partial class Check_cafe : Form
    {
        public Person asd;
        public Check_cafe()
        {
            InitializeComponent();
            string adres;
            Employee host;
            using (Login f_login = new Login()) //открываем форму логин через. using нужен для автоматической сборки мусора, после выполнения кода в {} все данные f_login будут удалены и недоступны
            {
                f_login.ShowDialog();
                host = f_login._host;  //для того чтобы сохранить данные о хосте и адресе смены, сорханяем их в другие ячейки памяти.
                adres = f_login._adres;  // сохраняем отдельно потому что записать время должны именно с открытия смены, смена будет открыта после выставления персонала в смене.
            }
            using (Change_Employee f_startChange = new Change_Employee())
            {
                f_startChange.ShowDialog();
            }
            //using (var context = new SQL_Cafe()) забираем данные из бд и засовываем его в коллекцию
            //{
            //    var Nhost = context.Employee.ToList();
            //    foreach (var rec in Nhost)
            //    {
            //        MessageBox.Show(rec.Id_person.ToString() + "\n " + rec.Person.Name.ToString() + "\n " + rec.Position.ToString());
            //    }
            //}
        }

        private void Add_client_Click(object sender, EventArgs e)
        {
            MessageBox.Show("add");  //это необходимо позднее заменить.
        }
    }
}
