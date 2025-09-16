namespace HOTELAPP
{
    partial class ManagerForm
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
            DGV_Employee = new DataGridView();
            DGV_Client = new DataGridView();
            B_AddEmployee = new Button();
            B_ShowEmployees = new Button();
            B_ShowClients = new Button();
            LL_LogOut = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)DGV_Employee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Client).BeginInit();
            SuspendLayout();
            // 
            // DGV_Employee
            // 
            DGV_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Employee.Location = new Point(199, 191);
            DGV_Employee.Name = "DGV_Employee";
            DGV_Employee.RowHeadersWidth = 51;
            DGV_Employee.RowTemplate.Height = 29;
            DGV_Employee.Size = new Size(1097, 483);
            DGV_Employee.TabIndex = 6;
            // 
            // DGV_Client
            // 
            DGV_Client.AllowUserToAddRows = false;
            DGV_Client.AllowUserToDeleteRows = false;
            DGV_Client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Client.Location = new Point(199, 191);
            DGV_Client.Name = "DGV_Client";
            DGV_Client.ReadOnly = true;
            DGV_Client.RowHeadersWidth = 51;
            DGV_Client.RowTemplate.Height = 29;
            DGV_Client.Size = new Size(1097, 483);
            DGV_Client.TabIndex = 7;
            DGV_Client.Visible = false;
            // 
            // B_AddEmployee
            // 
            B_AddEmployee.Location = new Point(659, 692);
            B_AddEmployee.Name = "B_AddEmployee";
            B_AddEmployee.Size = new Size(236, 61);
            B_AddEmployee.TabIndex = 8;
            B_AddEmployee.Text = "Add Employee";
            B_AddEmployee.UseVisualStyleBackColor = true;
            B_AddEmployee.Click += B_AddEmployee_Click;
            // 
            // B_ShowEmployees
            // 
            B_ShowEmployees.Location = new Point(487, 65);
            B_ShowEmployees.Name = "B_ShowEmployees";
            B_ShowEmployees.Size = new Size(168, 63);
            B_ShowEmployees.TabIndex = 9;
            B_ShowEmployees.Text = "Show Employees";
            B_ShowEmployees.UseVisualStyleBackColor = true;
            B_ShowEmployees.Click += B_ShowEmployees_Click;
            // 
            // B_ShowClients
            // 
            B_ShowClients.Location = new Point(875, 65);
            B_ShowClients.Name = "B_ShowClients";
            B_ShowClients.Size = new Size(168, 63);
            B_ShowClients.TabIndex = 10;
            B_ShowClients.Text = "Show Clients";
            B_ShowClients.UseVisualStyleBackColor = true;
            B_ShowClients.Click += B_ShowClients_Click;
            // 
            // LL_LogOut
            // 
            LL_LogOut.ActiveLinkColor = Color.CornflowerBlue;
            LL_LogOut.AutoSize = true;
            LL_LogOut.BackColor = Color.Transparent;
            LL_LogOut.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LL_LogOut.LinkArea = new LinkArea(0, 7);
            LL_LogOut.LinkBehavior = LinkBehavior.NeverUnderline;
            LL_LogOut.LinkColor = Color.RoyalBlue;
            LL_LogOut.Location = new Point(65, 50);
            LL_LogOut.Name = "LL_LogOut";
            LL_LogOut.Size = new Size(167, 41);
            LL_LogOut.TabIndex = 21;
            LL_LogOut.TabStop = true;
            LL_LogOut.Text = "Log Out";
            LL_LogOut.LinkClicked += LL_LogOut_LinkClicked;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1526, 856);
            Controls.Add(LL_LogOut);
            Controls.Add(B_ShowClients);
            Controls.Add(B_ShowEmployees);
            Controls.Add(B_AddEmployee);
            Controls.Add(DGV_Client);
            Controls.Add(DGV_Employee);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage";
            FormClosing += ManagerForm_FormClosing;
            Load += ManagerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Employee).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Client).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DataGridView DGV_Employee;
        private DataGridView DGV_Client;
        private Button B_AddEmployee;
        private Button B_ShowEmployees;
        private Button B_ShowClients;
        private LinkLabel LL_LogOut;
    }
}