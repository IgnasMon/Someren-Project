namespace SomerenUI
{
    partial class DrinkUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.clearTextBoxesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.requirementLabel1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.isAlcoholicCheckBox = new System.Windows.Forms.CheckBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.drinkMenuLabel = new System.Windows.Forms.Label();
            this.isAlcoholicLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.drinkIdLabel = new System.Windows.Forms.Label();
            this.drinkIdTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxDrinks = new System.Windows.Forms.PictureBox();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click_1);
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.label2);
            this.pnlDrinks.Controls.Add(this.clearTextBoxesButton);
            this.pnlDrinks.Controls.Add(this.label1);
            this.pnlDrinks.Controls.Add(this.requirementLabel1);
            this.pnlDrinks.Controls.Add(this.deleteButton);
            this.pnlDrinks.Controls.Add(this.updateButton);
            this.pnlDrinks.Controls.Add(this.isAlcoholicCheckBox);
            this.pnlDrinks.Controls.Add(this.amountTextBox);
            this.pnlDrinks.Controls.Add(this.amountLabel);
            this.pnlDrinks.Controls.Add(this.priceTextBox);
            this.pnlDrinks.Controls.Add(this.priceLabel);
            this.pnlDrinks.Controls.Add(this.createButton);
            this.pnlDrinks.Controls.Add(this.drinkMenuLabel);
            this.pnlDrinks.Controls.Add(this.isAlcoholicLabel);
            this.pnlDrinks.Controls.Add(this.nameTextBox);
            this.pnlDrinks.Controls.Add(this.nameLabel);
            this.pnlDrinks.Controls.Add(this.drinkIdLabel);
            this.pnlDrinks.Controls.Add(this.drinkIdTextBox);
            this.pnlDrinks.Controls.Add(this.pictureBoxDrinks);
            this.pnlDrinks.Controls.Add(this.listViewDrinks);
            this.pnlDrinks.Controls.Add(this.lblDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(12, 32);
            this.pnlDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(747, 545);
            this.pnlDrinks.TabIndex = 9;
            // 
            // clearTextBoxesButton
            // 
            this.clearTextBoxesButton.Location = new System.Drawing.Point(534, 425);
            this.clearTextBoxesButton.Name = "clearTextBoxesButton";
            this.clearTextBoxesButton.Size = new System.Drawing.Size(140, 29);
            this.clearTextBoxesButton.TabIndex = 11;
            this.clearTextBoxesButton.Text = "Clear Text Boxes";
            this.clearTextBoxesButton.UseVisualStyleBackColor = true;
            this.clearTextBoxesButton.Click += new System.EventHandler(this.clearTextBoxesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(528, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Use dot";
            // 
            // requirementLabel1
            // 
            this.requirementLabel1.AutoSize = true;
            this.requirementLabel1.ForeColor = System.Drawing.Color.Red;
            this.requirementLabel1.Location = new System.Drawing.Point(546, 186);
            this.requirementLabel1.Name = "requirementLabel1";
            this.requirementLabel1.Size = new System.Drawing.Size(25, 20);
            this.requirementLabel1.TabIndex = 18;
            this.requirementLabel1.Text = "(*)";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(660, 390);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 29);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(561, 390);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 29);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // isAlcoholicCheckBox
            // 
            this.isAlcoholicCheckBox.AutoSize = true;
            this.isAlcoholicCheckBox.Location = new System.Drawing.Point(594, 252);
            this.isAlcoholicCheckBox.Name = "isAlcoholicCheckBox";
            this.isAlcoholicCheckBox.Size = new System.Drawing.Size(133, 24);
            this.isAlcoholicCheckBox.TabIndex = 5;
            this.isAlcoholicCheckBox.Text = "(Empty = False)";
            this.isAlcoholicCheckBox.UseVisualStyleBackColor = true;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(594, 311);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(125, 27);
            this.amountTextBox.TabIndex = 7;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(488, 318);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 20);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "Amount";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(594, 278);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 27);
            this.priceTextBox.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(488, 285);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 20);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(485, 390);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(70, 29);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // drinkMenuLabel
            // 
            this.drinkMenuLabel.AutoSize = true;
            this.drinkMenuLabel.ForeColor = System.Drawing.Color.Red;
            this.drinkMenuLabel.Location = new System.Drawing.Point(505, 345);
            this.drinkMenuLabel.Name = "drinkMenuLabel";
            this.drinkMenuLabel.Size = new System.Drawing.Size(218, 40);
            this.drinkMenuLabel.TabIndex = 9;
            this.drinkMenuLabel.Text = "Only Text Boxes with a (*) need \r\n  to be filled in when Deleting\r\n";
            // 
            // isAlcoholicLabel
            // 
            this.isAlcoholicLabel.AutoSize = true;
            this.isAlcoholicLabel.Location = new System.Drawing.Point(488, 252);
            this.isAlcoholicLabel.Name = "isAlcoholicLabel";
            this.isAlcoholicLabel.Size = new System.Drawing.Size(85, 20);
            this.isAlcoholicLabel.TabIndex = 7;
            this.isAlcoholicLabel.Text = "Is Alcoholic";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(594, 212);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(488, 219);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // drinkIdLabel
            // 
            this.drinkIdLabel.AutoSize = true;
            this.drinkIdLabel.Location = new System.Drawing.Point(488, 186);
            this.drinkIdLabel.Name = "drinkIdLabel";
            this.drinkIdLabel.Size = new System.Drawing.Size(63, 20);
            this.drinkIdLabel.TabIndex = 4;
            this.drinkIdLabel.Text = "Drink ID";
            // 
            // drinkIdTextBox
            // 
            this.drinkIdTextBox.Location = new System.Drawing.Point(594, 179);
            this.drinkIdTextBox.Name = "drinkIdTextBox";
            this.drinkIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.drinkIdTextBox.TabIndex = 3;
            // 
            // pictureBoxDrinks
            // 
            this.pictureBoxDrinks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDrinks.Image")));
            this.pictureBoxDrinks.Location = new System.Drawing.Point(544, 9);
            this.pictureBoxDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxDrinks.Name = "pictureBoxDrinks";
            this.pictureBoxDrinks.Size = new System.Drawing.Size(130, 116);
            this.pictureBoxDrinks.TabIndex = 2;
            this.pictureBoxDrinks.TabStop = false;
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.Location = new System.Drawing.Point(18, 56);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewDrinks.MultiSelect = false;
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(452, 408);
            this.listViewDrinks.TabIndex = 1;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDrinks.Location = new System.Drawing.Point(15, 9);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(101, 41);
            this.lblDrinks.TabIndex = 0;
            this.lblDrinks.Text = "Drinks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fill in all Text Boxes when\r\n    Updating or Creating";
            // 
            // DrinkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 507);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DrinkUI";
            this.Text = "DrinkUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox pictureBoxDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Label drinkIdLabel;
        private System.Windows.Forms.TextBox drinkIdTextBox;
        private System.Windows.Forms.CheckBox isAlcoholicCheckBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label isAlcoholicLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label drinkMenuLabel;
        private System.Windows.Forms.Label requirementLabel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearTextBoxesButton;
        private System.Windows.Forms.Label label2;
    }
}