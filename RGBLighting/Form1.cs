using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBLighting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int delay = 150;

            async void aAsync()
            {
                await Task.Delay(delay);
                this.BackColor = Color.Blue;
                await Task.Delay(delay);
                this.BackColor = Color.Red;
                await Task.Delay(delay);
                this.BackColor = Color.Yellow;
                await Task.Delay(delay);
                this.BackColor = Color.LimeGreen;
                aAsync();
            }

            aAsync();
        }

    }
}
