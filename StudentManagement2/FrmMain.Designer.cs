
namespace StudentManagement2
{
    partial class FrmMain
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(60, 40);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(67, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Mã sinh viên";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(146, 37);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(172, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(60, 81);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(71, 13);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Tên sinh viên";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(146, 77);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(172, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(60, 110);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(54, 13);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Ngày sinh";
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(60, 155);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(81, 13);
            this.lblAvgScore.TabIndex = 6;
            this.lblAvgScore.Text = "Điểm trung bình";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(146, 109);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(172, 20);
            this.dtpDateOfBirth.TabIndex = 7;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(60, 196);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(39, 13);
            this.lblClassID.TabIndex = 8;
            this.lblClassID.Text = "Mã lớp";
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.Location = new System.Drawing.Point(146, 155);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.Size = new System.Drawing.Size(172, 20);
            this.txtAvgScore.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(60, 232);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(146, 196);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(172, 20);
            this.txtClassID.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(355, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 20);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(355, 77);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(64, 20);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Lùi lại";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(355, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 20);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 276);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAvgScore);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Name = "FrmMain";
            this.Text = "Quản lý thông tin sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox txtAvgScore;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnDelete;
    }
}

