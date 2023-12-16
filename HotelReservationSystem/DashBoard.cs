using HotelReservationSystem.AllControl;
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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addroom_btn_Click(object sender, EventArgs e)
        {
            costumerR_button.BackColor = Color.FromArgb(44, 62, 80);
            addroom_btn.BackColor= Color.FromArgb(241, 196, 15);
            costumerD_button.BackColor = Color.FromArgb(44, 62, 80);
            costumerR1.Visible = false;
            costumerDetails1.Visible = false;
            addRoom1.Visible= true;
            addRoom1.BringToFront();
        }

        private void costumerR_button_Click(object sender, EventArgs e)
        {
            addroom_btn.BackColor = Color.FromArgb(44, 62, 80);
            costumerR_button.BackColor = Color.FromArgb(241, 196, 15);
            costumerD_button.BackColor = Color.FromArgb(44, 62, 80);
            addRoom1.Visible = false;
            costumerDetails1.Visible = false;
            costumerR1.Visible = true;
            costumerR1.BringToFront();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            addRoom1.Visible = false;
            costumerR1.Visible = false;
            costumerDetails1.Visible = false;
        }

        private void costumerD_button_Click(object sender, EventArgs e)
        {
            addroom_btn.BackColor = Color.FromArgb(44, 62, 80);
            costumerR_button.BackColor = Color.FromArgb(44, 62, 80);
            costumerD_button.BackColor = Color.FromArgb(241, 196, 15);
            addRoom1.Visible = false;
            costumerR1.Visible = false;
            costumerDetails1.Visible = true;
            costumerDetails1.BringToFront();
        }
    }
}
