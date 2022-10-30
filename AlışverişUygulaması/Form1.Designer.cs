namespace AlışverişUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGoster = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoster
            // 
            this.buttonGoster.Location = new System.Drawing.Point(31, 22);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(101, 47);
            this.buttonGoster.TabIndex = 0;
            this.buttonGoster.Text = "Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(993, 22);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(125, 47);
            this.buttonKapat.TabIndex = 1;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 246);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(323, 197);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(212, 34);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(410, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 559);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGoster;
        private Button buttonKapat;
        private DataGridView dataGridView1;
        private Button buttonKaydet;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}