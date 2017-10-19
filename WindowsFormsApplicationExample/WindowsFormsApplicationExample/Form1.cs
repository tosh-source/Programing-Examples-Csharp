using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationExample
{
    public partial class Програма : Form
    {
        public Програма()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Архиви_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The time is:" + DateTime.Now);    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Архиви 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кого търсиш тук подяволите :D");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Затвори ме гадино :D");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
