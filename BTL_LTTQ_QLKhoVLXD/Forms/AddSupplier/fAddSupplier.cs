﻿using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Forms.AddSupplier
{
    
    public partial class fAddSupplier : Form
    {
        private readonly fTaskManager _parentForm;
        public fAddSupplier(fTaskManager form)
        {
            InitializeComponent();
            _parentForm = form;
        }


        private void fAddSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}