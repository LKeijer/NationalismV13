namespace NationalismV13
{
    partial class mainForm
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
            this.checkedListBoxContinents = new System.Windows.Forms.CheckedListBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.selectedItemListBox = new System.Windows.Forms.ListBox();
            this.selectedIndexListBox = new System.Windows.Forms.ListBox();
            this.getItemBtn = new System.Windows.Forms.Button();
            this.getIndexBtn = new System.Windows.Forms.Button();
            this.goNextFormBtn = new System.Windows.Forms.Button();
            this.trainRadioBtn = new System.Windows.Forms.RadioButton();
            this.testRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkedListBoxContinents
            // 
            this.checkedListBoxContinents.FormattingEnabled = true;
            this.checkedListBoxContinents.Items.AddRange(new object[] {
            "Africa.",
            "Asia.",
            "Australia.",
            "North-America.",
            "South-America.",
            "Europe."});
            this.checkedListBoxContinents.Location = new System.Drawing.Point(34, 73);
            this.checkedListBoxContinents.Name = "checkedListBoxContinents";
            this.checkedListBoxContinents.Size = new System.Drawing.Size(113, 169);
            this.checkedListBoxContinents.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.welcomeLabel.Location = new System.Drawing.Point(135, 23);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(443, 31);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "How to induce ignorant nationalism!";
            // 
            // selectedItemListBox
            // 
            this.selectedItemListBox.FormattingEnabled = true;
            this.selectedItemListBox.Location = new System.Drawing.Point(34, 305);
            this.selectedItemListBox.Name = "selectedItemListBox";
            this.selectedItemListBox.Size = new System.Drawing.Size(120, 95);
            this.selectedItemListBox.TabIndex = 2;
            // 
            // selectedIndexListBox
            // 
            this.selectedIndexListBox.FormattingEnabled = true;
            this.selectedIndexListBox.Location = new System.Drawing.Point(169, 305);
            this.selectedIndexListBox.Name = "selectedIndexListBox";
            this.selectedIndexListBox.Size = new System.Drawing.Size(120, 95);
            this.selectedIndexListBox.TabIndex = 3;
            // 
            // getItemBtn
            // 
            this.getItemBtn.Location = new System.Drawing.Point(34, 267);
            this.getItemBtn.Name = "getItemBtn";
            this.getItemBtn.Size = new System.Drawing.Size(120, 23);
            this.getItemBtn.TabIndex = 4;
            this.getItemBtn.Text = "Get selected Item";
            this.getItemBtn.UseVisualStyleBackColor = true;
            this.getItemBtn.Click += new System.EventHandler(this.getItemBtn_Click);
            // 
            // getIndexBtn
            // 
            this.getIndexBtn.Location = new System.Drawing.Point(169, 267);
            this.getIndexBtn.Name = "getIndexBtn";
            this.getIndexBtn.Size = new System.Drawing.Size(120, 23);
            this.getIndexBtn.TabIndex = 5;
            this.getIndexBtn.Text = "Get selected index";
            this.getIndexBtn.UseVisualStyleBackColor = true;
            this.getIndexBtn.Click += new System.EventHandler(this.getIndexBtn_Click);
            // 
            // goNextFormBtn
            // 
            this.goNextFormBtn.Location = new System.Drawing.Point(169, 155);
            this.goNextFormBtn.Name = "goNextFormBtn";
            this.goNextFormBtn.Size = new System.Drawing.Size(120, 87);
            this.goNextFormBtn.TabIndex = 6;
            this.goNextFormBtn.Text = "Lets go!";
            this.goNextFormBtn.UseVisualStyleBackColor = true;
            this.goNextFormBtn.Click += new System.EventHandler(this.goNextFormBtn_Click);
            // 
            // trainRadioBtn
            // 
            this.trainRadioBtn.AutoSize = true;
            this.trainRadioBtn.Location = new System.Drawing.Point(169, 73);
            this.trainRadioBtn.Name = "trainRadioBtn";
            this.trainRadioBtn.Size = new System.Drawing.Size(95, 17);
            this.trainRadioBtn.TabIndex = 7;
            this.trainRadioBtn.TabStop = true;
            this.trainRadioBtn.Text = "Training mode!";
            this.trainRadioBtn.UseVisualStyleBackColor = true;
            // 
            // testRadioBtn
            // 
            this.testRadioBtn.AutoSize = true;
            this.testRadioBtn.Location = new System.Drawing.Point(169, 113);
            this.testRadioBtn.Name = "testRadioBtn";
            this.testRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.testRadioBtn.TabIndex = 8;
            this.testRadioBtn.TabStop = true;
            this.testRadioBtn.Text = "Test mode!";
            this.testRadioBtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 412);
            this.Controls.Add(this.testRadioBtn);
            this.Controls.Add(this.trainRadioBtn);
            this.Controls.Add(this.goNextFormBtn);
            this.Controls.Add(this.getIndexBtn);
            this.Controls.Add(this.getItemBtn);
            this.Controls.Add(this.selectedIndexListBox);
            this.Controls.Add(this.selectedItemListBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.checkedListBoxContinents);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxContinents;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListBox selectedItemListBox;
        private System.Windows.Forms.ListBox selectedIndexListBox;
        private System.Windows.Forms.Button getItemBtn;
        private System.Windows.Forms.Button getIndexBtn;
        private System.Windows.Forms.Button goNextFormBtn;
        private System.Windows.Forms.RadioButton trainRadioBtn;
        private System.Windows.Forms.RadioButton testRadioBtn;
    }
}

