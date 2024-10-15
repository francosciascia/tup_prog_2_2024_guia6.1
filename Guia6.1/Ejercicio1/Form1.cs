using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ITExto it;
        List<string> list = new List<string> { "OXY333", "OYZ 013", "AAA 123", "BCD 456", "AB 123 CD", "YZ5432EF", "QW 3456 AB" };
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void rbString_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (rbRegex.Checked)
            {
                it = new VerificarRegex();
                tbMultiline.Clear();
                foreach (string s in list)
                {
                    tbMultiline.Text += it.VerificarTexto(s) + $"\r\n";
                }

            }
            if (rbString.Checked)
            {
                it = new VerificarString();
                tbMultiline.Clear();
                foreach (string s in list)
                {
                    tbMultiline.Text += it.VerificarTexto(s) + $"\r\n";
                }
            }
        }
    }
}
