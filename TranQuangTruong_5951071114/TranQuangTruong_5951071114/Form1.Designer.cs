namespace TranQuangTruong_5951071114
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsbd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtho = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsbd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvsv);
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 193);
            this.panel2.TabIndex = 30;
            // 
            // dgvsv
            // 
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsv.Location = new System.Drawing.Point(0, 0);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(797, 193);
            this.dgvsv.TabIndex = 0;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsv_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexit.Location = new System.Drawing.Point(641, 195);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(91, 46);
            this.btnexit.TabIndex = 29;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(446, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(89, 46);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(309, 195);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 46);
            this.btnsua.TabIndex = 27;
            this.btnsua.Text = "Xác lập";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(181, 195);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 46);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(41, 195);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 46);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(515, 85);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(192, 22);
            this.txtsdt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên sinh viên:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(515, 35);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(192, 22);
            this.txtten.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(134, 136);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(172, 22);
            this.txtdiachi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số báo danh:";
            // 
            // txtsbd
            // 
            this.txtsbd.Location = new System.Drawing.Point(134, 85);
            this.txtsbd.Name = "txtsbd";
            this.txtsbd.Size = new System.Drawing.Size(172, 22);
            this.txtsbd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Họ sinh viên:";
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(134, 35);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(172, 22);
            this.txtho.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtho;
    }
}

