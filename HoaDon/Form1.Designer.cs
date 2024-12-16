namespace HoaDon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnkhoitao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbatdau = new System.Windows.Forms.TextBox();
            this.txtketthuc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(138, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // btnloc
            // 
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(272, 41);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(91, 51);
            this.btnloc.TabIndex = 2;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(759, 599);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(116, 51);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnkhoitao
            // 
            this.btnkhoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhoitao.Image = ((System.Drawing.Image)(resources.GetObject("btnkhoitao.Image")));
            this.btnkhoitao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhoitao.Location = new System.Drawing.Point(597, 599);
            this.btnkhoitao.Name = "btnkhoitao";
            this.btnkhoitao.Size = new System.Drawing.Size(121, 51);
            this.btnkhoitao.TabIndex = 6;
            this.btnkhoitao.Text = "Khởi tạo";
            this.btnkhoitao.UseVisualStyleBackColor = true;
            this.btnkhoitao.Click += new System.EventHandler(this.btnkhoitao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chọn hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Hóa Đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(239, 155);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(360, 29);
            this.txttimkiem.TabIndex = 10;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(690, 147);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(97, 40);
            this.btntimkiem.TabIndex = 11;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnchon
            // 
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(690, 101);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(76, 35);
            this.btnchon.TabIndex = 12;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(239, 101);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(202, 24);
            this.comboBoxTables.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtketthuc);
            this.groupBox2.Controls.Add(this.txtbatdau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnloc);
            this.groupBox2.Location = new System.Drawing.Point(78, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 122);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day star";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day end";
            // 
            // txtbatdau
            // 
            this.txtbatdau.Location = new System.Drawing.Point(110, 29);
            this.txtbatdau.Name = "txtbatdau";
            this.txtbatdau.Size = new System.Drawing.Size(100, 22);
            this.txtbatdau.TabIndex = 5;
            // 
            // txtketthuc
            // 
            this.txtketthuc.Location = new System.Drawing.Point(110, 73);
            this.txtketthuc.Name = "txtketthuc";
            this.txtketthuc.Size = new System.Drawing.Size(100, 22);
            this.txtketthuc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnkhoitao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnkhoitao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtketthuc;
        private System.Windows.Forms.TextBox txtbatdau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

