﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBPROJECT
{
    public partial class frmMain : Form
    {
        frmLogin fm;   // login form
        public frmMain()
        {
            InitializeComponent();


        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Exit the application?", "Please confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //         this.Close();
            if (csMessageBox.Show("Exit the application?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool mustchangepwd = false;

            Globals.glInitializeVariables();
            this.fm = new frmLogin();

            if (this.fm.ShowDialog() == DialogResult.Abort)
                this.Close();

            if (Globals.gLoginName != null)
            {
                this.txtUserName.Text = Globals.gLoginName;
            }

            if (Globals.gdbServerName != null)
            {
                this.txtServer.Text = Globals.gdbServerName;
            }

            this.glSetSizeToDesktop();
            this.BringToFront();
        }

        private frmChangePassword ChangePasswordfrm;

        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(Globals.gIdUser, Globals.gLoginName);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;
            //ChangePasswordfrm.MdiParent = this;
            ChangePasswordfrm.ShowDialog();
        }

        
        private frmUserProfile UserProfilefrm;

        private void UserProfilefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserProfilefrm.Dispose();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserProfilefrm = new frmUserProfile(Globals.gIdUser, Globals.gLoginName);
            UserProfilefrm.FormClosed += UserProfilefrm_FormClosed;
            UserProfilefrm.MdiParent = this;
            UserProfilefrm.Show();
        }

        frmUser Userfrm;
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userfrm = new frmUser();
            Userfrm.FormClosed += Userfrm_FormClosed;
            Userfrm.MdiParent = this;
            Userfrm.Show();
        }

        private void Userfrm_FormClosed(object sender, EventArgs e)
        {
           Userfrm.Dispose();
        }

        frmCustomers Customersfrm;
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customersfrm = new frmCustomers();
            Customersfrm.FormClosed += Customersfrm_FormClosed;
            Customersfrm.MdiParent = this;
            Customersfrm.Show();
        }

        private void Customersfrm_FormClosed(object sender, EventArgs e)
        {
            Customersfrm.Dispose();
        }

        frmVendors Vendorsfrm;
        private void btnVendors_Click(object sender, EventArgs e)
        {
            Vendorsfrm = new frmVendors();
            Vendorsfrm.FormClosed += Vendorsfrm_FormClosed;
            Vendorsfrm.MdiParent = this;
            Vendorsfrm.Show();
        }
        private void Vendorsfrm_FormClosed(object sender, EventArgs e)
        {
            Vendorsfrm.Dispose();
        }

        frmItems Itemsfrm;
        private void btnItems_Click(object sender, EventArgs e)
        {
            Itemsfrm = new frmItems();
            Itemsfrm.FormClosed += Itemsfrm_FormClosed;
            Itemsfrm.MdiParent = this;
            Itemsfrm.Show();
        }
        private void Itemsfrm_FormClosed(object sender, EventArgs e)
        {
            Itemsfrm.Dispose();
        }
    }

}
