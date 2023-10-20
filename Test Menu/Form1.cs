using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            Header.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //newButton.MouseMove += NewButton_MouseMove;
        }
        //Кнопка убегает
        //private void NewButton_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Random rnd = new Random();
        //    newButton.Location = new Point(rnd.Next(0, 200), rnd.Next(0, 500));
        //}

        private void NewButton_Click(object sender, EventArgs e)
        {
           this.Controls.Remove(Header);
            this.Controls.Remove(newButton);
            //((Button)sender) 
        }
        Button newButton = new Button();

        private void PlayGame_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(Menu);
            this.Controls.Remove(PlayGame);
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void Сurtail_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
