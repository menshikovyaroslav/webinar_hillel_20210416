using Game_Mines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Mines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var panel = new Panel();
            panel.Dock = DockStyle.Fill;

            for (int i = 0; i < Options.MapWidthCount; i++)
            {
                for (int j = 0; j < Options.MapHeightCount; j++)
                {
                    var btn = new Button() { Width = Options.MapElementWidth,  Height = Options.MapElementHeight, Left = i * Options.MapElementWidth, Top = j * Options.MapElementHeight };
                    btn.Click += Btn_Click;

                    panel.Controls.Add(btn);
                }
            }

            this.Controls.Add(panel);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
