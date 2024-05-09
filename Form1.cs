using Microsoft.EntityFrameworkCore;

namespace SR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            users = new DBClas1();
            users.Database.EnsureCreated();
            users.Users.Load();

        }
        DBClas1 users;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("Не введено ім'я/пароль/роль"); }
            else
            {
                bool isHere = false;
                bool isName = false;
                bool isParol= false;
                foreach (var item in users.Users)
                {
                    string parol = (textBox2.Text).ToLower();
                    if (item.Name == textBox1.Text && item.Parol == parol && item.Role == comboBox1.Text)
                    { isHere = false; break; }
                    else { isHere = true; }
                }
                if (isHere == false)
                {
                    DialogResult res = MessageBox.Show("Такий користувач уже існує.Ви бажаєте увійти?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes) { Open(); }
                }
                else
                {

                    foreach (var item in users.Users)
                    {
                        if (item.Name == textBox1.Text)
                        { isName = false; break; }
                        else { isName = true; }
                    }
                    if (isName == false)
                    { MessageBox.Show("Це ім'я зайняте.Введіть інше");textBox1.Text = ""; }
                    else{
                        foreach (var item in users.Users)
                        {
                            if (item.Parol == textBox2.Text)
                            { isParol = false; break; }
                            else { isParol = true; }
                        }
                        if (isParol == false)
                        { MessageBox.Show("Цей пароль зайнятий.Введіть інший"); textBox2.Text = ""; }
                        else
                        {
                            string parol = (textBox2.Text).ToLower();
                            users.Add(new User { Name = textBox1.Text, Role = comboBox1.Text, Parol = parol });
                            DialogResult res = MessageBox.Show("Ви точно хочете створити новий профіль?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (res == DialogResult.Yes)
                            {
                                users.SaveChanges();
                                Open();
                            }
                        }
                    }
                }
            }
        }
        private void Open()
        {
            if (comboBox1.Text == "Клієнт") { Client cl = new Client(); cl.Text = "Користувач: " + textBox1.Text; cl.ShowDialog(); }
            if (comboBox1.Text == "Адмін") { Admin ad = new Admin(); ad.Text = "Адмін: " + textBox1.Text; ad.ShowDialog(); }
            if (comboBox1.Text == "Кур'єр") { Kurier kr = new Kurier(); kr.Text = textBox1.Text; kr.ShowDialog(); }
            if (comboBox1.Text == "Менаджер") { Manager m = new Manager(); m.Text = textBox1.Text; m.ShowDialog(); }
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
        }

    }
}
