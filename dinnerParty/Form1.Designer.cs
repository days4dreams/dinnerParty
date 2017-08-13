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
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(12, 19);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(248, 65);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "The Party Planner programme calculates the cost of your party. Let\'s get planning" +
    "!";
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsLabel.Location = new System.Drawing.Point(13, 100);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(124, 18);
            this.guestsLabel.TabIndex = 1;
            this.guestsLabel.Text = "Number of Guests:";
            // 
            // numericGuests
            // 
            this.numericGuests.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericGuests.Location = new System.Drawing.Point(17, 126);
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
            this.decorLabel.Location = new System.Drawing.Point(14, 170);
            this.decorLabel.Name = "decorLabel";
            this.decorLabel.Size = new System.Drawing.Size(113, 18);
            this.decorLabel.TabIndex = 3;
            this.decorLabel.Text = "Decoration Style:";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(14, 231);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(139, 18);
            this.labelFood.TabIndex = 6;
            this.labelFood.Text = "Food and Drink Style:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(14, 309);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(83, 19);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Party Cost:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(122, 309);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(108, 23);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "£0.00";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStandard.Location = new System.Drawing.Point(16, 193);
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
            this.radioFancy.Location = new System.Drawing.Point(122, 193);
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
            this.radioIndulgent.Location = new System.Drawing.Point(16, 265);
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
            this.radioHealthy.Location = new System.Drawing.Point(122, 268);
            this.radioHealthy.Name = "radioHealthy";
            this.radioHealthy.Size = new System.Drawing.Size(75, 22);
            this.radioHealthy.TabIndex = 14;
            this.radioHealthy.Text = "Healthy";
            this.radioHealthy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 351);
            this.Controls.Add(this.radioHealthy);
            this.Controls.Add(this.radioIndulgent);
            this.Controls.Add(this.radioFancy);
            this.Controls.Add(this.radioStandard);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.decorLabel);
            this.Controls.Add(this.numericGuests);
            this.Controls.Add(this.guestsLabel);
            this.Controls.Add(this.introLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

