using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace check_cafe
{
    public partial class Login : MetroForm
    {
        internal Employee _host; //данные о хосте, нужно для смены
        internal string _adres;  //адрес кафе
        private List<Employee> host; //храним данные из бд тк они нам нужны в 2х методах, следовательно чтобы не обращаться к бд 2 раза мы их храним.

        // пароль вроде бы есть, но на самом деле его нет =) программа для портфолио.

        public Login()
        {
            InitializeComponent();
            using (var context = new SQL_Cafe()) //берем данные из бд
            {
                host = context.Employee.ToList();  //сохраняем данные в виде коллекции в переменной
                foreach (var rec in host)
                {
                    if (rec.Position.LastIndexOfAny("Host".ToCharArray()) !=0)
                        Combo_host.Items.Add(rec.Person.Name.ToString()); // записываем в комбо бокс имена Хостов
                }
            }
        }

        private void bStart_Click(object sender, EventArgs e)  //Проверка для Михаила)
        {
            foreach (var rec in host)
            {
                if (rec.Person.Name.ToString() == Combo_host.SelectedItem.ToString()) //ищем именно нашего хоста в колеекции(копии бд)
                    _host = rec; // сохраняем нашего хоста(нужен его ID для записи о нем в смене)
            }
            host.Clear(); // на всякий случай чистим коллекцию(по идее ее потом разберет сборщик мусора тк при запуске использовался using)
            _adres = Text_adres.Text;            
            Close(); //закрываем форму логин
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
