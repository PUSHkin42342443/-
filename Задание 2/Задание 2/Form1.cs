using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("введиите число 1");
            double longKatetOne = double.Parse(Console.ReadLine());
            Console.WriteLine("введиите число 2");
            double longKatetTwo = double.Parse(Console.ReadLine());

            double x = Math.Sqrt(longKatetOne * longKatetOne + longKatetTwo * longKatetTwo);

            Console.WriteLine(x);
            //находим площадь
            Console.WriteLine("Площадь равна:");
            Console.WriteLine((longKatetOne * longKatetTwo) / 2);
        }
    }
}
