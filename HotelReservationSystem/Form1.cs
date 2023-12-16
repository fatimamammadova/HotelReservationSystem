using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "fatima" && txt_password.Text =="pass")
            {
                message_text.Visible= false;
                DashBoard ds = new DashBoard();
                this.Hide();
                ds.Show();
            } 
            else
            {
                message_text.Visible = true;
                txt_password.Clear();

            }
        }

       
    }
}