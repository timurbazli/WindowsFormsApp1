using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class My_form : Form
    {
        public My_form()
        {
            InitializeComponent();
        }

        private void Run_Bottun_Click(object sender, EventArgs e)
        {
            double a, b, c, h;
            a = Convert.ToDouble(TXTA.Text);
            b = Convert.ToDouble(TXTB.Text);
            c = Convert.ToDouble(TXTC.Text);
            h = Convert.ToDouble(TXTH.Text);
            Triangle triangle = new Triangle(a, b, c);
            Triangle triangles = new Triangle(a,h);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Сторона h");
            listView1.Items.Add("периметр");
            listView1.Items.Add("площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(triangles.outputH());
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangles.Plosad()));
            if (triangle.ExistTriange) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TriangleType);

            if(triangle.TriangleType == "Равносторонний")
            {
                pictureBox1.Image = Properties.Resources.index;
            }
            else if (triangle.TriangleType == "Равнобедренный")
            {
                pictureBox1.Image = Properties.Resources.ss;
            }
            else if (triangle.TriangleType == "Разносторонний")
            {
                pictureBox1.Image = Properties.Resources.image001;
            }



        }
    }
}
