
namespace C969Assessment
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.appointmentsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.userApptList = new System.Windows.Forms.DataGridView();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userApptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsBtn
            // 
            this.appointmentsBtn.Location = new System.Drawing.Point(32, 12);
            this.appointmentsBtn.Name = "appointmentsBtn";
            this.appointmentsBtn.Size = new System.Drawing.Size(200, 200);
            this.appointmentsBtn.TabIndex = 0;
            this.appointmentsBtn.Text = "Appointments";
            this.appointmentsBtn.UseVisualStyleBackColor = true;
            this.appointmentsBtn.Click += new System.EventHandler(this.appointmentsBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(323, 12);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(200, 200);
            this.customersBtn.TabIndex = 2;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // userApptList
            // 
            this.userApptList.AllowUserToAddRows = false;
            this.userApptList.AllowUserToDeleteRows = false;
            this.userApptList.AutoGenerateColumns = false;
            this.userApptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userApptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn});
            this.userApptList.DataSource = this.appointmentBindingSource1;
            this.userApptList.Location = new System.Drawing.Point(12, 246);
            this.userApptList.Name = "userApptList";
            this.userApptList.RowHeadersVisible = false;
            this.userApptList.Size = new System.Drawing.Size(531, 243);
            this.userApptList.TabIndex = 3;
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "Appointment ID";
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            this.appointmentIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 65;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 80;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Appointment Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 90;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "URL";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.Width = 75;
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataSource = typeof(C969Assessment.Appointment);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 495);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(468, 541);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scheduled appointments:";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(C969Assessment.Appointment);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.userApptList);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.appointmentsBtn);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.userApptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointmentsBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DataGridView userApptList;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
    }
}