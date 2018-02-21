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
            t_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void Close_f_Click(object sender, EventArgs e)
        {

        }

        private void Add_emp_Click(object sender, EventArgs e)
        {
            if (t_Name.Text != "" && t_Adres.Text != "" && t_Phone.Text != "" && t_Position.SelectedItem.ToString() != "")
                using (SQL_Cafe db = new SQL_Cafe()) //тут полная херня происходит, нужно дописывать функционал классов, но это не точно
                {
                    Person rab = new Person(t_Name.Text, t_Adres.Text, t_Phone.Text);
                    db.Persons.Add(rab);
                    
                    db.SaveChanges();
                    db.SaveChangesAsync();
                    
                    var person = db.Persons.Where(p => p.Name == t_Name.Text).ToList();
                    MessageBox.Show(person[0].Name+" "+ person[0].Phone+ " "+ person[0].Id);
                    //db.Employee.Add(new Employee { Id_person = person[0].Id, Position = t_Position.SelectedItem.ToString() });
                    //db.SaveChanges();
                }
        }
    }
}
