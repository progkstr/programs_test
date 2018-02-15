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
            using (Login f_login = new Login())
            {
                f_login.ShowDialog();
                host = f_login._host;
                adres = f_login._adres;
            }
            //using (var context = new SQL_Cafe())
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
            MessageBox.Show("add");
        }
    }
}
