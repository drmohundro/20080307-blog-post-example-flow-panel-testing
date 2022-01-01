using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.flowLayoutPanel1.AutoScroll = true;
            this.cboFlowDirection.SelectedIndex = 0;
            this.chkWrapContents.Checked = true;

            this.cboFlowDirection.SelectedIndexChanged += delegate(object sender, EventArgs e)
            {
                switch (this.cboFlowDirection.SelectedItem.ToString())
                {
                    case "LeftToRight":
                        this.flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                        break;
                    case "TopDown":
                        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                        break;
                    case "RightToLeft":
                        this.flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
                        break;
                    case "BottomUp":
                        this.flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
                        break;
                }
            };

            this.chkWrapContents.CheckStateChanged += delegate(object sender, EventArgs e)
            {
                // Interesting to note... if you turn off wrap contents, add past the margin, then
                // reset the WrapContents to true, it won't automatically wrap at the margin - it
                // will only wrap controls that have been newly added.
                this.flowLayoutPanel1.WrapContents = this.chkWrapContents.Checked;
            };

            this.button1.Click += delegate(object sender, EventArgs e)
            {
                Button btn = new Button();
                btn.Text = "Button";
                this.flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new EventHandler(dynamicButton_Click);
            };
        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {
            PropertyGrid pg;
            if (this.panel1.Controls.Count == 0)
            {
                pg = new PropertyGrid();
                pg.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(pg);
            }
            else
            {
                pg = (PropertyGrid) this.panel1.Controls[0];
            }
            pg.SelectedObject = sender;
        }
    }
}