﻿using BTL_LTTQ_QLKhoVLXD.Models;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fTaskManager : Form
    {
        private readonly User User;

        public fTaskManager(User user)
        {
            InitializeComponent();
            User = user;
            DisplayUserInfo();
        }

        private void tctlControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.YellowGreen);

            e.DrawBackground();

            // Draw Text
            Graphics g = e.Graphics;
            string text = tctlControl.TabPages[e.Index].Text;
            SizeF textSize = g.MeasureString(text, tctlControl.Font);

            float x = e.Bounds.Left + 10;
            float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, tctlControl.Font, Brushes.Black, x, y);
        }

        private void DisplayUserInfo()
        {
            lblUser.Text = $"Người dùng: {User.Name}";
            lblPosition.Text = $"Chức vụ: {User.Position}";
        }
    }
}
