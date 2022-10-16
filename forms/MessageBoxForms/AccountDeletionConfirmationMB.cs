﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZappCash.forms.MessageBoxForms.EditOrDelete
{
    public partial class AccountDeletionConfirmationMB : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public AccountDeletionConfirmationMB()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // Delete account method then show SuccessfulAccountDeletionMB
            this.Hide();
            SuccessfulAccountDeletionMB successfulAccountDeletionMB = new SuccessfulAccountDeletionMB();
            successfulAccountDeletionMB.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Hide then show AccountsPage
            this.Hide();
            AccountsPage accountsPage = new AccountsPage();
            accountsPage.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}