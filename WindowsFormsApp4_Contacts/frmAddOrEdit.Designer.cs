
namespace WindowsFormsApp4_Contacts
{
    partial class frmAddOrEdit
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
            this.grpboxInfo = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxInfo
            // 
            this.grpboxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.grpboxInfo.Controls.Add(this.btnSubmit);
            this.grpboxInfo.Controls.Add(this.txtNumber);
            this.grpboxInfo.Controls.Add(this.label5);
            this.grpboxInfo.Controls.Add(this.txtEmail);
            this.grpboxInfo.Controls.Add(this.label4);
            this.grpboxInfo.Controls.Add(this.txtAddres);
            this.grpboxInfo.Controls.Add(this.label3);
            this.grpboxInfo.Controls.Add(this.txtFamily);
            this.grpboxInfo.Controls.Add(this.label2);
            this.grpboxInfo.Controls.Add(this.txtName);
            this.grpboxInfo.Controls.Add(this.label1);
            this.grpboxInfo.Location = new System.Drawing.Point(12, 12);
            this.grpboxInfo.Name = "grpboxInfo";
            this.grpboxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpboxInfo.Size = new System.Drawing.Size(440, 249);
            this.grpboxInfo.TabIndex = 0;
            this.grpboxInfo.TabStop = false;
            this.grpboxInfo.Text = "اطلاعات";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(428, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "ذخیره اطلاعات";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 72);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(349, 21);
            this.txtNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "شماره تماس :*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ایمیل :";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(6, 126);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddres.Size = new System.Drawing.Size(349, 86);
            this.txtAddres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ادرس :";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(6, 45);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(349, 21);
            this.txtFamily.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی :*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :*";
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 274);
            this.Controls.Add(this.grpboxInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.grpboxInfo.ResumeLayout(false);
            this.grpboxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
    }
}