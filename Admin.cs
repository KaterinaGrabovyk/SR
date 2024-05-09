using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR
{
    public partial class Admin : Form
    {
        DBClas1 use;
        DBClas2 zam;
        DBClas3 kur;
        public Admin()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Scrollable = true;
            listView1.MultiSelect = false;
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Замовник", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Огірки", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Помідори", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Капуста", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Буряк", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Морква", 130, HorizontalAlignment.Center);
            zam = new DBClas2();
            zam.Database.EnsureCreated();
            zam.Zamovlennas.Load();
            kur = new DBClas3();
            kur.Database.EnsureCreated();
            kur.Kurers.Load();
            use = new DBClas1();
            use.Database.EnsureCreated();
            use.Users.Load();
            ListZamov();
            foreach (var item in use.Users) { if (item.Role == "Кур'єр") { comboBox1.Items.Add(item.Name); } }
        }
        private void ListZamov()
        {
            listView1.Items.Clear();
            foreach (var zamov in zam.Zamovlennas.Local.ToList())
            {
                if (zamov.Prinato == false)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Clear();
                    item.SubItems[0].Text = "" + zamov.Id;
                    item.SubItems.Add(zamov.Name);
                    item.SubItems.Add((zamov.Ogirki).ToString());
                    item.SubItems.Add((zamov.Pomidori).ToString());
                    item.SubItems.Add((zamov.Kapusta).ToString());
                    item.SubItems.Add((zamov.Buriak).ToString());
                    item.SubItems.Add((zamov.Morkva).ToString());
                    listView1.Items.Add(item);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1&&numericUpDown1.Value!=0)
            {
                kur.Add(new Kurer { Name = comboBox1.Text, ZamID = (int)numericUpDown1.Value});
                kur.SaveChanges();
                foreach (var item in zam.Zamovlennas){ if (item.Id == (int)numericUpDown1.Value) { item.Prinato = true; } }
                zam.SaveChanges();
                MessageBox.Show("Ви призначили замовлення.");
                ListZamov();
                numericUpDown1.Value = 0;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ви не обрали кур'єра/замовлення");
            }

        }
    }
}
