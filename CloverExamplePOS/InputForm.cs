﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CloverExamplePOS
{
    public partial class InputForm : OverlayForm
    {
        private string val = "";
        public String Title
        {
            get
            {
                //return Text;
                return TitleTextBox.Text;
            }
            set
            {
                //Text = value;
                TitleTextBox.Text = value;
            }
        }
        public string Label
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                textBox1.Text = value;
            }
        }

        public DialogResult Status
        {
            get; internal set;
        }

        public InputForm(Form formToCover) : base(formToCover)
        {
            InitializeComponent();

            textBox1.TextChanged += (object sender, EventArgs e) => { val = textBox1.Text; };
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            Status = DialogResult.OK;
            this.Close();
        }

        private void CxButton_Click(object sender, EventArgs e)
        {
            Status = DialogResult.Cancel;
            this.Close();
        }
    }
}
