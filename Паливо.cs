﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Селецька
{
    public partial class Паливо : MaterialForm
    {
        public Паливо()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            float b = float.Parse(materialTextBox1.Text);
            double c = 100/b;
            materialLabel2.Text = c.ToString() + " км/л";
        }

        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b' | (e.KeyChar == Convert.ToChar("-"))) return;
            else
                e.Handled = true;
        }
    }
}
