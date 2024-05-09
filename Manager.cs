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
    public partial class Manager : Form
    {
        DBClas2 zam;
        DBClas3 kur;
        public Manager()
        {
            InitializeComponent();
            zam = new DBClas2();
            zam.Database.EnsureCreated();
            zam.Zamovlennas.Load();
            kur = new DBClas3();
            kur.Database.EnsureCreated();
            kur.Kurers.Load();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in kur.Kurers)
            {
                string a = $"КУР'ЄР:{item.Name},НОМЕР ЗАМОВЛЕННЯ {item.ZamID}.";
                listBox1.Items.Add(a);
            }
            foreach (var item in zam.Zamovlennas)
            {
                string a = $"НОМЕР:{item.Id},ЗАМОВНИК {item.Name},ПРИЙНЯТО:{item.Prinato}, ДОСТАВЛЕНО:{item.Vidpravleno}.";
                listBox2.Items.Add(a);
            }
        }

    }
}
