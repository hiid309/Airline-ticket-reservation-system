namespace ticket1
{
    partial class Flight_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_information));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1_destination = new System.Windows.Forms.ComboBox();
            this.comboBox1_departure = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Query = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticknum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1_destination);
            this.groupBox1.Controls.Add(this.comboBox1_departure);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1_Query);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1238, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight inquiry";
            // 
            // comboBox1_destination
            // 
            this.comboBox1_destination.FormattingEnabled = true;
            this.comboBox1_destination.Items.AddRange(new object[] {
            "Sanaa",
            "Taiz",
            "Adin",
            "Makah",
            "Cairo"});
            this.comboBox1_destination.Location = new System.Drawing.Point(457, 121);
            this.comboBox1_destination.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_destination.Name = "comboBox1_destination";
            this.comboBox1_destination.Size = new System.Drawing.Size(160, 33);
            this.comboBox1_destination.TabIndex = 13;
            // 
            // comboBox1_departure
            // 
            this.comboBox1_departure.FormattingEnabled = true;
            this.comboBox1_departure.Items.AddRange(new object[] {
            "Sanaa",
            "Qatar",
            "Abha",
            "Amman"});
            this.comboBox1_departure.Location = new System.Drawing.Point(148, 121);
            this.comboBox1_departure.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_departure.Name = "comboBox1_departure";
            this.comboBox1_departure.Size = new System.Drawing.Size(160, 33);
            this.comboBox1_departure.TabIndex = 12;
            this.comboBox1_departure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_departure_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1099, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 69);
            this.button3.TabIndex = 11;
            this.button3.Text = "Buy tickets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(769, 125);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 33);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fclass,
            this.price,
            this.ticknum});
            this.dataGridView1.Location = new System.Drawing.Point(28, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 346);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "starting \r\npoint";
            // 
            // button1_Query
            // 
            this.button1_Query.ForeColor = System.Drawing.Color.Black;
            this.button1_Query.Location = new System.Drawing.Point(1099, 121);
            this.button1_Query.Margin = new System.Windows.Forms.Padding(4);
            this.button1_Query.Name = "button1_Query";
            this.button1_Query.Size = new System.Drawing.Size(115, 46);
            this.button1_Query.TabIndex = 5;
            this.button1_Query.Text = "Query";
            this.button1_Query.UseVisualStyleBackColor = true;
            this.button1_Query.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(684, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(331, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "destination";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 665);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fno";
            this.Column1.HeaderText = "flight number";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // fclass
            // 
            this.fclass.DataPropertyName = "fclass";
            this.fclass.HeaderText = "grade";
            this.fclass.MinimumWidth = 10;
            this.fclass.Name = "fclass";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            // 
            // ticknum
            // 
            this.ticknum.DataPropertyName = "ticknum";
            this.ticknum.HeaderText = "remaining seats";
            this.ticknum.MinimumWidth = 10;
            this.ticknum.Name = "ticknum";
            // 
            // Flight_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Flight_information";
            this.Text = "User booking flight information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Query;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1_departure;
        private System.Windows.Forms.ComboBox comboBox1_destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticknum;
    }
}