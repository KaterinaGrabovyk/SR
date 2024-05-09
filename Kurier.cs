using Microsoft.EntityFrameworkCore;
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
    public partial class Kurier : Form
    {
        DBClas2 zam;
        DBClas3 kur;
        public Kurier()
        {
            InitializeComponent();
            zam = new DBClas2();
            zam.Database.EnsureCreated();
            zam.Zamovlennas.Load();
            kur = new DBClas3();            
            kur.Database.EnsureCreated();
            kur.Kurers.Load();
            foreach (var j in kur.Kurers)
            {
                foreach (var i in zam.Zamovlennas)
                {
                    if (j.Name.Contains(this.Text))
                    {
                        if (i.Id.Equals(j.ZamID) && i.Vidpravleno == false)
                        {
                            comboBox1.Items.Add(i.Id);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==-1) { MessageBox.Show("Не обрано замовлення."); }
            else
            {
                foreach(var item in zam.Zamovlennas)
                {
                    int id = (int)comboBox1.SelectedItem;
                    if (item.Id == id) { 
                        MessageBox.Show("Замовлення доставлено.");
                        item.Vidpravleno = true;
                    }
                }
                zam.SaveChanges();
                Spisok();
            }
        }
        private void Spisok()
        {
            foreach (var j in kur.Kurers)
            {
                foreach (var i in zam.Zamovlennas)
                {
                    if (j.Name.Contains(this.Text))
                    {
                        if (i.Id.Equals(j.ZamID) && i.Vidpravleno == false)
                        {
                            listBox1.Items.Clear();
                            string prod = "";
                            if (i.Ogirki == true) { prod += "Огірки,"; }
                            if (i.Pomidori == true) { prod += "Помідори,"; }
                            if (i.Kapusta == true) { prod += "Капуста,"; }
                            if (i.Buriak == true) { prod += "Буряк,"; }
                            if (i.Morkva == true) { prod += "Морква,"; }
                            string el = $"НОМЕР:{j.ZamID}; ПРОДУКТИ:{prod};";
                            listBox1.Items.Add(el);
                        }
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Spisok();
        }
    }
}
