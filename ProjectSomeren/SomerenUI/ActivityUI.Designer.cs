namespace SomerenUI
{
    partial class ActivityUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityUI));
            pnlActivities = new System.Windows.Forms.Panel();
            pnlActivityCRUD = new System.Windows.Forms.Panel();
            btnClearCRUD = new System.Windows.Forms.Button();
            textBoxActivityCRUDDesc = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            lblActivityCRUD = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            textBoxActivityCRUDID = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            lblActivityCRUDID = new System.Windows.Forms.Label();
            lblActivityCRUDEnd = new System.Windows.Forms.Label();
            lblActivityCRUDDesc = new System.Windows.Forms.Label();
            dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            lblActivityCRUDStart = new System.Windows.Forms.Label();
            dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            pictureBoxActivities = new System.Windows.Forms.PictureBox();
            listViewActivities = new System.Windows.Forms.ListView();
            lblActivities = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlActivities.SuspendLayout();
            pnlActivityCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActivities).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pnlActivityCRUD);
            pnlActivities.Controls.Add(pictureBoxActivities);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(lblActivities);
            pnlActivities.Location = new System.Drawing.Point(10, 47);
            pnlActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1202, 484);
            pnlActivities.TabIndex = 5;
            // 
            // pnlActivityCRUD
            // 
            pnlActivityCRUD.Controls.Add(btnClearCRUD);
            pnlActivityCRUD.Controls.Add(textBoxActivityCRUDDesc);
            pnlActivityCRUD.Controls.Add(btnUpdate);
            pnlActivityCRUD.Controls.Add(lblActivityCRUD);
            pnlActivityCRUD.Controls.Add(btnDelete);
            pnlActivityCRUD.Controls.Add(textBoxActivityCRUDID);
            pnlActivityCRUD.Controls.Add(btnCreate);
            pnlActivityCRUD.Controls.Add(lblActivityCRUDID);
            pnlActivityCRUD.Controls.Add(lblActivityCRUDEnd);
            pnlActivityCRUD.Controls.Add(lblActivityCRUDDesc);
            pnlActivityCRUD.Controls.Add(dateTimePickerEnd);
            pnlActivityCRUD.Controls.Add(lblActivityCRUDStart);
            pnlActivityCRUD.Controls.Add(dateTimePickerStart);
            pnlActivityCRUD.Location = new System.Drawing.Point(573, 56);
            pnlActivityCRUD.Name = "pnlActivityCRUD";
            pnlActivityCRUD.Size = new System.Drawing.Size(471, 408);
            pnlActivityCRUD.TabIndex = 17;
            // 
            // btnClearCRUD
            // 
            btnClearCRUD.Location = new System.Drawing.Point(334, 65);
            btnClearCRUD.Name = "btnClearCRUD";
            btnClearCRUD.Size = new System.Drawing.Size(94, 29);
            btnClearCRUD.TabIndex = 17;
            btnClearCRUD.Text = "Clear Fields";
            btnClearCRUD.UseVisualStyleBackColor = true;
            btnClearCRUD.Click += btnClearCRUD_Click;
            // 
            // textBoxActivityCRUDDesc
            // 
            textBoxActivityCRUDDesc.Location = new System.Drawing.Point(136, 115);
            textBoxActivityCRUDDesc.Multiline = true;
            textBoxActivityCRUDDesc.Name = "textBoxActivityCRUDDesc";
            textBoxActivityCRUDDesc.Size = new System.Drawing.Size(292, 138);
            textBoxActivityCRUDDesc.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(184, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblActivityCRUD
            // 
            lblActivityCRUD.AutoSize = true;
            lblActivityCRUD.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblActivityCRUD.Location = new System.Drawing.Point(35, 11);
            lblActivityCRUD.Name = "lblActivityCRUD";
            lblActivityCRUD.Size = new System.Drawing.Size(201, 41);
            lblActivityCRUD.TabIndex = 3;
            lblActivityCRUD.Text = "Activity CRUD";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(334, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBoxActivityCRUDID
            // 
            textBoxActivityCRUDID.Enabled = false;
            textBoxActivityCRUDID.Location = new System.Drawing.Point(136, 66);
            textBoxActivityCRUDID.Name = "textBoxActivityCRUDID";
            textBoxActivityCRUDID.ReadOnly = true;
            textBoxActivityCRUDID.Size = new System.Drawing.Size(67, 27);
            textBoxActivityCRUDID.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(35, 363);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblActivityCRUDID
            // 
            lblActivityCRUDID.AutoSize = true;
            lblActivityCRUDID.Location = new System.Drawing.Point(35, 69);
            lblActivityCRUDID.Name = "lblActivityCRUDID";
            lblActivityCRUDID.Size = new System.Drawing.Size(27, 20);
            lblActivityCRUDID.TabIndex = 8;
            lblActivityCRUDID.Text = "ID:";
            // 
            // lblActivityCRUDEnd
            // 
            lblActivityCRUDEnd.AutoSize = true;
            lblActivityCRUDEnd.Location = new System.Drawing.Point(35, 322);
            lblActivityCRUDEnd.Name = "lblActivityCRUDEnd";
            lblActivityCRUDEnd.Size = new System.Drawing.Size(73, 20);
            lblActivityCRUDEnd.TabIndex = 13;
            lblActivityCRUDEnd.Text = "End Date:";
            // 
            // lblActivityCRUDDesc
            // 
            lblActivityCRUDDesc.AutoSize = true;
            lblActivityCRUDDesc.Location = new System.Drawing.Point(35, 115);
            lblActivityCRUDDesc.Name = "lblActivityCRUDDesc";
            lblActivityCRUDDesc.Size = new System.Drawing.Size(88, 20);
            lblActivityCRUDDesc.TabIndex = 9;
            lblActivityCRUDDesc.Text = "Description:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new System.Drawing.Point(136, 317);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new System.Drawing.Size(292, 27);
            dateTimePickerEnd.TabIndex = 12;
            // 
            // lblActivityCRUDStart
            // 
            lblActivityCRUDStart.AutoSize = true;
            lblActivityCRUDStart.Location = new System.Drawing.Point(35, 280);
            lblActivityCRUDStart.Name = "lblActivityCRUDStart";
            lblActivityCRUDStart.Size = new System.Drawing.Size(79, 20);
            lblActivityCRUDStart.TabIndex = 10;
            lblActivityCRUDStart.Text = "Start Date:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new System.Drawing.Point(136, 275);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new System.Drawing.Size(292, 27);
            dateTimePickerStart.TabIndex = 11;
            // 
            // pictureBoxActivities
            // 
            pictureBoxActivities.Image = (System.Drawing.Image)resources.GetObject("pictureBoxActivities.Image");
            pictureBoxActivities.Location = new System.Drawing.Point(1050, 3);
            pictureBoxActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxActivities.Name = "pictureBoxActivities";
            pictureBoxActivities.Size = new System.Drawing.Size(149, 164);
            pictureBoxActivities.TabIndex = 2;
            pictureBoxActivities.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.FullRowSelect = true;
            listViewActivities.Location = new System.Drawing.Point(18, 56);
            listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewActivities.MultiSelect = false;
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(538, 408);
            listViewActivities.TabIndex = 1;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = System.Windows.Forms.View.Details;
            listViewActivities.SelectedIndexChanged += listViewActivities_SelectedIndexChanged;
            // 
            // lblActivities
            // 
            lblActivities.AutoSize = true;
            lblActivities.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblActivities.Location = new System.Drawing.Point(15, 9);
            lblActivities.Name = "lblActivities";
            lblActivities.Size = new System.Drawing.Size(135, 41);
            lblActivities.TabIndex = 0;
            lblActivities.Text = "Activities";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { applicationToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1222, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, closeToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            closeToolStripMenuItem.Text = "Close";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // ActivityUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1222, 554);
            Controls.Add(menuStrip1);
            Controls.Add(pnlActivities);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ActivityUI";
            Text = "ActivityUI";
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            pnlActivityCRUD.ResumeLayout(false);
            pnlActivityCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActivities).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // Activity - Sagy
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.PictureBox pictureBoxActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        // Activity END - END

        // ActivityCRUD - Ignas - Assignment 4
        private System.Windows.Forms.Label lblActivityCRUD;
        private System.Windows.Forms.Label lblActivityCRUDID;
        private System.Windows.Forms.TextBox textBoxActivityCRUDDesc;
        private System.Windows.Forms.Label lblActivityCRUDEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblActivityCRUDStart;
        private System.Windows.Forms.Label lblActivityCRUDDesc;
        private System.Windows.Forms.Panel pnlActivityCRUD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClearCRUD;
        private System.Windows.Forms.TextBox textBoxActivityCRUDID;
        // ActivityCRUD - END
    }
}