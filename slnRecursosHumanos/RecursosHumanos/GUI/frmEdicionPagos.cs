﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEdicionPagos : Form
    {
        public frmEdicionPagos()
        {
            InitializeComponent();
            this.txtNumPagos.ReadOnly = true;
            this.txtTotalDeducciones.ReadOnly = true;
            this.txtTotalPagos.ReadOnly = true;
        }


    }
}
