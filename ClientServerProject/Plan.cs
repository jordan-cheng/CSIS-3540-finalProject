﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerProject
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
            openSearch();
        }

        public void openSearch()
        {
            PlanSearch ps = new PlanSearch(this);
            this.Controls.Add(ps);
        }
    }
}
