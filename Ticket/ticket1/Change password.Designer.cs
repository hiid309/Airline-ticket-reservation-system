namespace ticket1
{
    partial class Change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_password));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_old = new System.Windows.Forms.TextBox();
            this.textBox2_new = new System.Windows.Forms.TextBox();
            this.textBox3_newr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(554, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(554, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(537, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // textBox1_old
            // 
            this.textBox1_old.Location = new System.Drawing.Point(477, 143);
            this.textBox1_old.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_old.Name = "textBox1_old";
            this.textBox1_old.Size = new System.Drawing.Size(312, 33);
            this.textBox1_old.TabIndex = 3;
            // 
            // textBox2_new
            // 
            this.textBox2_new.Location = new System.Drawing.Point(477, 276);
            this.textBox2_new.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_new.Name = "textBox2_new";
            this.textBox2_new.Size = new System.Drawing.Size(312, 33);
            this.textBox2_new.TabIndex = 4;
            // 
            // textBox3_newr
            // 
            this.textBox3_newr.Location = new System.Drawing.Point(477, 401);
            this.textBox3_newr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_newr.Name = "textBox3_newr";
            this.textBox3_newr.Size = new System.Drawing.Size(312, 33);
            this.textBox3_newr.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 575);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3_newr);
            this.Controls.Add(this.textBox2_new);
            this.Controls.Add(this.textBox1_old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_password";
            this.Text = "Change_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_old;
        private System.Windows.Forms.TextBox textBox2_new;
        private System.Windows.Forms.TextBox textBox3_newr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}