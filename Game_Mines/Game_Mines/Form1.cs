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

        int _mapWidthCount = 10;
        int _mapHeightCount = 10;
        int _bombs = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var panel = new Panel();
            panel.Dock = DockStyle.Fill;

            for (int i = 0; i < _mapWidthCount; i++)
            {
                for (int j = 0; j < _mapHeightCount; j++)
                {
                    var btn = new Button() { Width = 20,  Height = 20, Left = i * 20, Top = j * 20 };

                    panel.Controls.Add(btn);
                }
            }

            this.Controls.Add(panel);
        }
    }
}
