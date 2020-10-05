using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj_1 = new Class1();
            int tevadoba, mandzili,ganvlili_mandzili;
            double max_sichqare, dro,mandzili_1;


            tevadoba = int.Parse(textBox1.Text);
            mandzili = int.Parse(textBox2.Text);
            max_sichqare = double.Parse(textBox3.Text);
            dro = double.Parse(textBox4.Text);


            ganvlili_mandzili = obj_1.Mandzili(tevadoba,mandzili);
            mandzili_1 = obj_1.Mandzili(max_sichqare, dro);

            label5.Text = "ავტომობილი სავსე ბაკით გაივლის " + ganvlili_mandzili.ToString()+ " კმ";
            label6.Text = "ავტომობილი გაივლის " + mandzili_1.ToString() + " კმ";

        }
    }
}
