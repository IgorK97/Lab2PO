using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (ISPUContext dbc = new ISPUContext())
            {
                Database.SetInitializer<ISPUContext>(null);
                dbc.Cathedras.Select(i => i).ToList();
                dbc.Cathedras.Add(new Cathedras() { Name = "Программное обеспечение компьютерных систем", abbreviation = "ПОКС" });
                dbc.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
