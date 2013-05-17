using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkLabelTest
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            string target = (string)e.Link.LinkData;
            if (null != target && target.StartsWith("www"))
                {
                System.Diagnostics.Process.Start(target);
                }
            else
            {
                MessageBox.Show("网址格式不正确" + target );
                }

            }

        private void button1_Click_1(object sender, EventArgs e)
            {
            this.linkLabel1.Text = this.textBox1.Text;
            this.linkLabel1.Links[0].LinkData = this.textBox2.Text;

            }

         
 
        }
    }
