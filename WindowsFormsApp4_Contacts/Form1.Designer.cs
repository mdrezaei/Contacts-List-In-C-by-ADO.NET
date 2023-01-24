
namespace WindowsFormsApp4_Contacts
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
            this.dgContactsList = new System.Windows.Forms.DataGridView();
            this.ContactID_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addres_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddContact = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.grpboxList = new System.Windows.Forms.GroupBox();
            this.gtpboxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpboxList.SuspendLayout();
            this.gtpboxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgContactsList
            // 
            this.dgContactsList.AllowUserToAddRows = false;
            this.dgContactsList.AllowUserToDeleteRows = false;
            this.dgContactsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContactsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID_DB,
            this.Name_DB,
            this.Family_DB,
            this.Number_DB,
            this.Email_DB,
            this.Addres_DB});
            this.dgContactsList.Location = new System.Drawing.Point(6, 20);
            this.dgContactsList.Name = "dgContactsList";
            this.dgContactsList.ReadOnly = true;
            this.dgContactsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgContactsList.Size = new System.Drawing.Size(977, 356);
            this.dgContactsList.TabIndex = 0;
            // 
            // ContactID_DB
            // 
            this.ContactID_DB.DataPropertyName = "ContactID";
            this.ContactID_DB.HeaderText = "شناسه";
            this.ContactID_DB.Name = "ContactID_DB";
            this.ContactID_DB.ReadOnly = true;
            this.ContactID_DB.Visible = false;
            // 
            // Name_DB
            // 
            this.Name_DB.DataPropertyName = "Name";
            this.Name_DB.HeaderText = "نام";
            this.Name_DB.Name = "Name_DB";
            this.Name_DB.ReadOnly = true;
            // 
            // Family_DB
            // 
            this.Family_DB.DataPropertyName = "Family";
            this.Family_DB.HeaderText = "نام خانوادگی";
            this.Family_DB.Name = "Family_DB";
            this.Family_DB.ReadOnly = true;
            // 
            // Number_DB
            // 
            this.Number_DB.DataPropertyName = "Number";
            this.Number_DB.HeaderText = "تلفن";
            this.Number_DB.Name = "Number_DB";
            this.Number_DB.ReadOnly = true;
            // 
            // Email_DB
            // 
            this.Email_DB.DataPropertyName = "Email";
            this.Email_DB.HeaderText = "ایمیل";
            this.Email_DB.Name = "Email_DB";
            this.Email_DB.ReadOnly = true;
            // 
            // Addres_DB
            // 
            this.Addres_DB.DataPropertyName = "Addres";
            this.Addres_DB.HeaderText = "ادرس";
            this.Addres_DB.Name = "Addres_DB";
            this.Addres_DB.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddContact,
            this.btnRefresh,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddContact
            // 
            this.btnAddContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Image")));
            this.btnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(85, 22);
            this.btnAddContact.Text = "افزودن مخاطب";
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 22);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 22);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 22);
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpboxList
            // 
            this.grpboxList.BackColor = System.Drawing.SystemColors.Info;
            this.grpboxList.Controls.Add(this.dgContactsList);
            this.grpboxList.Location = new System.Drawing.Point(12, 77);
            this.grpboxList.Name = "grpboxList";
            this.grpboxList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpboxList.Size = new System.Drawing.Size(989, 382);
            this.grpboxList.TabIndex = 2;
            this.grpboxList.TabStop = false;
            this.grpboxList.Text = "لیست مخاطبین";
            // 
            // gtpboxSearch
            // 
            this.gtpboxSearch.BackColor = System.Drawing.SystemColors.Info;
            this.gtpboxSearch.Controls.Add(this.txtSearch);
            this.gtpboxSearch.Location = new System.Drawing.Point(12, 28);
            this.gtpboxSearch.Name = "gtpboxSearch";
            this.gtpboxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gtpboxSearch.Size = new System.Drawing.Size(989, 43);
            this.gtpboxSearch.TabIndex = 3;
            this.gtpboxSearch.TabStop = false;
            this.gtpboxSearch.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(977, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 471);
            this.Controls.Add(this.gtpboxSearch);
            this.Controls.Add(this.grpboxList);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContactsList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpboxList.ResumeLayout(false);
            this.gtpboxSearch.ResumeLayout(false);
            this.gtpboxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContactsList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddContact;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.GroupBox grpboxList;
        private System.Windows.Forms.GroupBox gtpboxSearch;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addres_DB;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

