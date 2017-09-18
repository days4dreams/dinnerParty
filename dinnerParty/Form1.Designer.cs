namespace dinnerParty
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
            this.introLabel = new System.Windows.Forms.Label();
            this.guestsLabel = new System.Windows.Forms.Label();
            this.numericGuests = new System.Windows.Forms.NumericUpDown();
            this.decorLabel = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.radioStandard = new System.Windows.Forms.CheckBox();
            this.radioFancy = new System.Windows.Forms.CheckBox();
            this.radioIndulgent = new System.Windows.Forms.CheckBox();
            this.radioHealthy = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numberBirthdayLabel = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthdayLabel = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.cakeWritingLabel = new System.Windows.Forms.Label();
            this.birthdayCostLabel = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(12, 19);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(484, 42);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "The Party Planner programme calculates the cost of your party. Let\'s get planning" +
    "!";
            this.introLabel.Click += new System.EventHandler(this.introLabel_Click);
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsLabel.Location = new System.Drawing.Point(38, 13);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(124, 18);
            this.guestsLabel.TabIndex = 1;
            this.guestsLabel.Text = "Number of Guests:";
            // 
            // numericGuests
            // 
            this.numericGuests.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericGuests.Location = new System.Drawing.Point(42, 39);
            this.numericGuests.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGuests.Name = "numericGuests";
            this.numericGuests.Size = new System.Drawing.Size(213, 26);
            this.numericGuests.TabIndex = 2;
            this.numericGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGuests.ValueChanged += new System.EventHandler(this.numericGuests_ValueChanged);
            // 
            // decorLabel
            // 
            this.decorLabel.AutoSize = true;
            this.decorLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decorLabel.Location = new System.Drawing.Point(39, 83);
            this.decorLabel.Name = "decorLabel";
            this.decorLabel.Size = new System.Drawing.Size(113, 18);
            this.decorLabel.TabIndex = 3;
            this.decorLabel.Text = "Decoration Style:";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(39, 144);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(139, 18);
            this.labelFood.TabIndex = 6;
            this.labelFood.Text = "Food and Drink Style:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(39, 222);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(83, 19);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Party Cost:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(147, 222);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(108, 23);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "£0.00";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStandard.Location = new System.Drawing.Point(41, 106);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(82, 22);
            this.radioStandard.TabIndex = 11;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // radioFancy
            // 
            this.radioFancy.AutoSize = true;
            this.radioFancy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFancy.Location = new System.Drawing.Point(147, 106);
            this.radioFancy.Name = "radioFancy";
            this.radioFancy.Size = new System.Drawing.Size(62, 22);
            this.radioFancy.TabIndex = 12;
            this.radioFancy.Text = "Fancy";
            this.radioFancy.UseVisualStyleBackColor = true;
            // 
            // radioIndulgent
            // 
            this.radioIndulgent.AutoSize = true;
            this.radioIndulgent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIndulgent.Location = new System.Drawing.Point(41, 178);
            this.radioIndulgent.Name = "radioIndulgent";
            this.radioIndulgent.Size = new System.Drawing.Size(87, 22);
            this.radioIndulgent.TabIndex = 13;
            this.radioIndulgent.Text = "Indulgent";
            this.radioIndulgent.UseVisualStyleBackColor = true;
            // 
            // radioHealthy
            // 
            this.radioHealthy.AutoSize = true;
            this.radioHealthy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHealthy.Location = new System.Drawing.Point(147, 181);
            this.radioHealthy.Name = "radioHealthy";
            this.radioHealthy.Size = new System.Drawing.Size(75, 22);
            this.radioHealthy.TabIndex = 14;
            this.radioHealthy.Text = "Healthy";
            this.radioHealthy.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 287);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guestsLabel);
            this.tabPage1.Controls.Add(this.radioHealthy);
            this.tabPage1.Controls.Add(this.numericGuests);
            this.tabPage1.Controls.Add(this.radioIndulgent);
            this.tabPage1.Controls.Add(this.decorLabel);
            this.tabPage1.Controls.Add(this.radioFancy);
            this.tabPage1.Controls.Add(this.labelFood);
            this.tabPage1.Controls.Add(this.radioStandard);
            this.tabPage1.Controls.Add(this.labelCost);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.numberBirthdayLabel);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.fancyBirthdayLabel);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.cakeWritingLabel);
            this.tabPage2.Controls.Add(this.birthdayCostLabel);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numberBirthdayLabel
            // 
            this.numberBirthdayLabel.AutoSize = true;
            this.numberBirthdayLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBirthdayLabel.Location = new System.Drawing.Point(66, 12);
            this.numberBirthdayLabel.Name = "numberBirthdayLabel";
            this.numberBirthdayLabel.Size = new System.Drawing.Size(124, 18);
            this.numberBirthdayLabel.TabIndex = 13;
            this.numberBirthdayLabel.Text = "Number of Guests:";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBirthday.Location = new System.Drawing.Point(70, 38);
            this.numberBirthday.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(213, 26);
            this.numberBirthday.TabIndex = 14;
            this.numberBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // fancyBirthdayLabel
            // 
            this.fancyBirthdayLabel.AutoSize = true;
            this.fancyBirthdayLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyBirthdayLabel.Location = new System.Drawing.Point(67, 82);
            this.fancyBirthdayLabel.Name = "fancyBirthdayLabel";
            this.fancyBirthdayLabel.Size = new System.Drawing.Size(113, 18);
            this.fancyBirthdayLabel.TabIndex = 15;
            this.fancyBirthdayLabel.Text = "Decoration Style:";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyBirthday.Location = new System.Drawing.Point(69, 105);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(62, 22);
            this.fancyBirthday.TabIndex = 19;
            this.fancyBirthday.Text = "Fancy";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // cakeWritingLabel
            // 
            this.cakeWritingLabel.AutoSize = true;
            this.cakeWritingLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeWritingLabel.Location = new System.Drawing.Point(67, 143);
            this.cakeWritingLabel.Name = "cakeWritingLabel";
            this.cakeWritingLabel.Size = new System.Drawing.Size(90, 18);
            this.cakeWritingLabel.TabIndex = 16;
            this.cakeWritingLabel.Text = "Cake Writing:";
            // 
            // birthdayCostLabel
            // 
            this.birthdayCostLabel.AutoSize = true;
            this.birthdayCostLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCostLabel.Location = new System.Drawing.Point(67, 221);
            this.birthdayCostLabel.Name = "birthdayCostLabel";
            this.birthdayCostLabel.Size = new System.Drawing.Size(83, 19);
            this.birthdayCostLabel.TabIndex = 17;
            this.birthdayCostLabel.Text = "Party Cost:";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthdayCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCost.Location = new System.Drawing.Point(175, 221);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(108, 23);
            this.birthdayCost.TabIndex = 18;
            this.birthdayCost.Text = "£0.00";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(69, 175);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(214, 20);
            this.cakeWriting.TabIndex = 20;
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.Location = new System.Drawing.Point(289, 178);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(22, 13);
            this.tooLongLabel.TabIndex = 21;
            this.tooLongLabel.Text = "OK";
            this.tooLongLabel.Click += new System.EventHandler(this.tooLongLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.introLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label guestsLabel;
        private System.Windows.Forms.NumericUpDown numericGuests;
        private System.Windows.Forms.Label decorLabel;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.CheckBox radioStandard;
        private System.Windows.Forms.CheckBox radioFancy;
        private System.Windows.Forms.CheckBox radioIndulgent;
        private System.Windows.Forms.CheckBox radioHealthy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label numberBirthdayLabel;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label fancyBirthdayLabel;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label cakeWritingLabel;
        private System.Windows.Forms.Label birthdayCostLabel;
        private System.Windows.Forms.Label birthdayCost;
    }
}

