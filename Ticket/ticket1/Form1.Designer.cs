namespace ticket1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Flight_informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refund_informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User_informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Flight_informationToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.RefundToolStripMenuItem,
            this.Refund_informationToolStripMenuItem,
            this.User_informationToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1248, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Flight_informationToolStripMenuItem
            // 
            this.Flight_informationToolStripMenuItem.Name = "Flight_informationToolStripMenuItem";
            this.Flight_informationToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.Flight_informationToolStripMenuItem.Text = "Flight_information";
            this.Flight_informationToolStripMenuItem.Click += new System.EventHandler(this.Flight_informationToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.OrderToolStripMenuItem.Text = "Order";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // RefundToolStripMenuItem
            // 
            this.RefundToolStripMenuItem.Name = "RefundToolStripMenuItem";
            this.RefundToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.RefundToolStripMenuItem.Text = "airline";
            this.RefundToolStripMenuItem.Click += new System.EventHandler(this.RefundToolStripMenuItem_Click);
            // 
            // Refund_informationToolStripMenuItem
            // 
            this.Refund_informationToolStripMenuItem.Name = "Refund_informationToolStripMenuItem";
            this.Refund_informationToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.Refund_informationToolStripMenuItem.Text = "Refund_information";
            this.Refund_informationToolStripMenuItem.Click += new System.EventHandler(this.Refund_informationToolStripMenuItem_Click);
            // 
            // User_informationToolStripMenuItem
            // 
            this.User_informationToolStripMenuItem.Name = "User_informationToolStripMenuItem";
            this.User_informationToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.User_informationToolStripMenuItem.Text = "User_information";
            this.User_informationToolStripMenuItem.Click += new System.EventHandler(this.User_informationToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.returnToolStripMenuItem.Text = "quit";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(326, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 126);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To\r\nAir ticket booking system";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Air ticket booking system";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Flight_informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem User_informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Refund_informationToolStripMenuItem;
    }
}

