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
    public partial class Client : Form
    {
        DBClas2 db2;
        public Client()
        {
            InitializeComponent();
            db2 = new DBClas2();
            db2.Database.EnsureCreated();
            db2.Zamovlennas.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false&&checkBox5.Checked==false)
            { MessageBox.Show("Не обрано нічого."); }
            else
            {
                db2.Add(new Zamovlenna {Name= this.Text,Ogirki=checkBox1.Checked,Pomidori=checkBox2.Checked,Kapusta=checkBox3.Checked,Buriak=checkBox4.Checked,Morkva=checkBox5.Checked });
                db2.SaveChanges();
                MessageBox.Show("Замовлення зроблено.");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            
        }
    }
}
