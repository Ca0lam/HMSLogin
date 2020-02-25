﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class HospitalLayout : Form
    {
        public HospitalLayout()
        {
            InitializeComponent();
        }

        private void Btn_New_Department_Click(object sender, EventArgs e)
        {
            NewDepartment viewDepartment = new NewDepartment();
            viewDepartment.Show();
        }

        private void Btn_New_Ward_Click(object sender, EventArgs e)
        {
            NewWard viewWard = new NewWard();
            viewWard.Show();
        }

        private void Btn_New_Room_Click(object sender, EventArgs e)
        {
            NewRoom viewRoom = new NewRoom();
            viewRoom.Show();
        }

        private void Btn_New_Bed_Click(object sender, EventArgs e)
        {
            NewBed viewBed = new NewBed();
            viewBed.Show();
        }

        private void Btn_View_Department_Click(object sender, EventArgs e)
        {
            NewWard department = new NewWard("LIES");
            department.Show();
        }

        private void Btn_View_Beds_Click(object sender, EventArgs e)
        {
            NewRoom room = new NewRoom("Lies");
            room.Show();
        }
    }
}
