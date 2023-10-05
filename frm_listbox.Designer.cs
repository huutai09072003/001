namespace pratice
{
    partial class frm_listbox
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioLopB = new RadioButton();
            radioLopA = new RadioButton();
            txtHoten = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            bt_Thoat = new Button();
            bt_Lammoi = new Button();
            bt_CapNhat = new Button();
            groupBox3 = new GroupBox();
            list_LopA = new ListBox();
            groupBox4 = new GroupBox();
            list_lopB = new ListBox();
            btchhuyenb = new Button();
            btchuyenallb = new Button();
            btchuyena = new Button();
            btchuyenalla = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 38);
            label1.TabIndex = 1;
            label1.Text = "Nhap danh sach sinh vien";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioLopB);
            groupBox1.Controls.Add(radioLopA);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(85, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 128);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin sinh vien";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioLopB
            // 
            radioLopB.AutoSize = true;
            radioLopB.Location = new Point(311, 88);
            radioLopB.Name = "radioLopB";
            radioLopB.Size = new Size(68, 24);
            radioLopB.TabIndex = 3;
            radioLopB.TabStop = true;
            radioLopB.Text = "Lop B";
            radioLopB.UseVisualStyleBackColor = true;
            // 
            // radioLopA
            // 
            radioLopA.AutoSize = true;
            radioLopA.Location = new Point(144, 88);
            radioLopA.Name = "radioLopA";
            radioLopA.Size = new Size(69, 24);
            radioLopA.TabIndex = 2;
            radioLopA.TabStop = true;
            radioLopA.Text = "Lop A";
            radioLopA.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            txtHoten.AccessibleName = "";
            txtHoten.Location = new Point(185, 40);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(360, 27);
            txtHoten.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 39);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhap ten sinh vien";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_Thoat);
            groupBox2.Controls.Add(bt_Lammoi);
            groupBox2.Controls.Add(bt_CapNhat);
            groupBox2.Location = new Point(85, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tac";
            // 
            // bt_Thoat
            // 
            bt_Thoat.Location = new Point(335, 56);
            bt_Thoat.Name = "bt_Thoat";
            bt_Thoat.Size = new Size(94, 29);
            bt_Thoat.TabIndex = 2;
            bt_Thoat.Text = "Thoat";
            bt_Thoat.UseVisualStyleBackColor = true;
            bt_Thoat.Click += bt_Thoat_Click;
            // 
            // bt_Lammoi
            // 
            bt_Lammoi.Location = new Point(185, 56);
            bt_Lammoi.Name = "bt_Lammoi";
            bt_Lammoi.Size = new Size(94, 29);
            bt_Lammoi.TabIndex = 1;
            bt_Lammoi.Text = "Lam Moi";
            bt_Lammoi.UseVisualStyleBackColor = true;
            bt_Lammoi.Click += bt_Lammoi_Click;
            // 
            // bt_CapNhat
            // 
            bt_CapNhat.Location = new Point(38, 56);
            bt_CapNhat.Name = "bt_CapNhat";
            bt_CapNhat.Size = new Size(94, 29);
            bt_CapNhat.TabIndex = 0;
            bt_CapNhat.Text = "Cap Nhat";
            bt_CapNhat.UseVisualStyleBackColor = true;
            bt_CapNhat.Click += bt_CapNhat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(list_LopA);
            groupBox3.Location = new Point(85, 391);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 211);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sach sinh vien lop A";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // list_LopA
            // 
            list_LopA.FormattingEnabled = true;
            list_LopA.ItemHeight = 20;
            list_LopA.Items.AddRange(new object[] { "Nguyen Huynh Huu Tai", "Pham Nhat Vuong", "Nguyen Thi Van Anh" });
            list_LopA.Location = new Point(6, 43);
            list_LopA.Name = "list_LopA";
            list_LopA.SelectionMode = SelectionMode.MultiSimple;
            list_LopA.Size = new Size(238, 164);
            list_LopA.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(list_lopB);
            groupBox4.Location = new Point(436, 391);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 207);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sach sinh vien lop B";
            // 
            // list_lopB
            // 
            list_lopB.FormattingEnabled = true;
            list_lopB.ItemHeight = 20;
            list_lopB.Location = new Point(6, 43);
            list_lopB.Name = "list_lopB";
            list_lopB.Size = new Size(238, 164);
            list_lopB.TabIndex = 0;
            list_lopB.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btchhuyenb
            // 
            btchhuyenb.Location = new Point(335, 448);
            btchhuyenb.Name = "btchhuyenb";
            btchhuyenb.Size = new Size(94, 29);
            btchhuyenb.TabIndex = 6;
            btchhuyenb.Text = ">";
            btchhuyenb.UseVisualStyleBackColor = true;
            btchhuyenb.Click += btchhuyenb_Click;
            // 
            // btchuyenallb
            // 
            btchuyenallb.Location = new Point(335, 483);
            btchuyenallb.Name = "btchuyenallb";
            btchuyenallb.Size = new Size(94, 29);
            btchuyenallb.TabIndex = 6;
            btchuyenallb.Text = ">>";
            btchuyenallb.UseVisualStyleBackColor = true;
            btchuyenallb.Click += btchuyenallb_Click;
            // 
            // btchuyena
            // 
            btchuyena.Location = new Point(335, 518);
            btchuyena.Name = "btchuyena";
            btchuyena.Size = new Size(94, 29);
            btchuyena.TabIndex = 6;
            btchuyena.Text = "<";
            btchuyena.UseVisualStyleBackColor = true;
            btchuyena.Click += btchuyena_Click;
            // 
            // btchuyenalla
            // 
            btchuyenalla.Location = new Point(335, 553);
            btchuyenalla.Name = "btchuyenalla";
            btchuyenalla.Size = new Size(94, 29);
            btchuyenalla.TabIndex = 6;
            btchuyenalla.Text = ">>";
            btchuyenalla.UseVisualStyleBackColor = true;
            btchuyenalla.Click += btchuyenalla_Click;
            // 
            // frm_listbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(btchuyenalla);
            Controls.Add(btchuyena);
            Controls.Add(btchuyenallb);
            Controls.Add(btchhuyenb);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frm_listbox";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioLopB;
        private RadioButton radioLopA;
        private TextBox txtHoten;
        private Label label2;
        private GroupBox groupBox2;
        private Button bt_Thoat;
        private Button bt_Lammoi;
        private Button bt_CapNhat;
        private GroupBox groupBox3;
        private ListBox list_LopA;
        private GroupBox groupBox4;
        private ListBox list_lopB;
        private Button btchhuyenb;
        private Button btchuyenallb;
        private Button btchuyena;
        private Button btchuyenalla;
    }
}