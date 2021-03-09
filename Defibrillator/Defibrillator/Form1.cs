using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defibrillator
{
    public partial class Form1 : Form
    {
        static List<Keszulek> keszulekek = new List<Keszulek>();

        public void Beolvas()
        {
            StreamReader be = new StreamReader("data.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                keszulekek.Add(new Keszulek(int.Parse(a[0]), a[1], double.Parse(a[2]), double.Parse(a[3]), a[4], a[5]));
            }
            be.Close();
        }

        public Form1()
        {
            InitializeComponent();
            Beolvas();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
