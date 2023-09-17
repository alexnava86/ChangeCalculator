namespace ChangeCalculator
{
    partial class ChangeCalculatorForm
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
            this.ChangeDueLabel = new System.Windows.Forms.Label();
            this.QuartersLabel = new System.Windows.Forms.Label();
            this.DimesLabel = new System.Windows.Forms.Label();
            this.ChangeDueTextbox = new System.Windows.Forms.TextBox();
            this.QuartersTextbox = new System.Windows.Forms.TextBox();
            this.DimesTextbox = new System.Windows.Forms.TextBox();
            this.NickelsTextbox = new System.Windows.Forms.TextBox();
            this.NickelsLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Pennies = new System.Windows.Forms.Label();
            this.PenniesTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeDueLabel
            // 
            this.ChangeDueLabel.AutoSize = true;
            this.ChangeDueLabel.Location = new System.Drawing.Point(35, 41);
            this.ChangeDueLabel.Name = "ChangeDueLabel";
            this.ChangeDueLabel.Size = new System.Drawing.Size(148, 13);
            this.ChangeDueLabel.TabIndex = 0;
            this.ChangeDueLabel.Text = "Amount of change due: (0-99)";
            // 
            // QuartersLabel
            // 
            this.QuartersLabel.AutoSize = true;
            this.QuartersLabel.Location = new System.Drawing.Point(35, 82);
            this.QuartersLabel.Name = "QuartersLabel";
            this.QuartersLabel.Size = new System.Drawing.Size(47, 13);
            this.QuartersLabel.TabIndex = 1;
            this.QuartersLabel.Text = "Quarters";
            // 
            // DimesLabel
            // 
            this.DimesLabel.AutoSize = true;
            this.DimesLabel.Location = new System.Drawing.Point(35, 122);
            this.DimesLabel.Name = "DimesLabel";
            this.DimesLabel.Size = new System.Drawing.Size(36, 13);
            this.DimesLabel.TabIndex = 2;
            this.DimesLabel.Text = "Dimes";
            // 
            // ChangeDueTextbox
            // 
            this.ChangeDueTextbox.Location = new System.Drawing.Point(235, 41);
            this.ChangeDueTextbox.Name = "ChangeDueTextbox";
            this.ChangeDueTextbox.Size = new System.Drawing.Size(100, 20);
            this.ChangeDueTextbox.TabIndex = 3;
            // 
            // QuartersTextbox
            // 
            this.QuartersTextbox.Location = new System.Drawing.Point(235, 79);
            this.QuartersTextbox.Name = "QuartersTextbox";
            this.QuartersTextbox.ReadOnly = true;
            this.QuartersTextbox.Size = new System.Drawing.Size(100, 20);
            this.QuartersTextbox.TabIndex = 4;
            // 
            // DimesTextbox
            // 
            this.DimesTextbox.Location = new System.Drawing.Point(235, 119);
            this.DimesTextbox.Name = "DimesTextbox";
            this.DimesTextbox.ReadOnly = true;
            this.DimesTextbox.Size = new System.Drawing.Size(100, 20);
            this.DimesTextbox.TabIndex = 5;
            // 
            // NickelsTextbox
            // 
            this.NickelsTextbox.Location = new System.Drawing.Point(235, 170);
            this.NickelsTextbox.Name = "NickelsTextbox";
            this.NickelsTextbox.ReadOnly = true;
            this.NickelsTextbox.Size = new System.Drawing.Size(100, 20);
            this.NickelsTextbox.TabIndex = 6;
            // 
            // NickelsLabel
            // 
            this.NickelsLabel.AutoSize = true;
            this.NickelsLabel.Location = new System.Drawing.Point(35, 170);
            this.NickelsLabel.Name = "NickelsLabel";
            this.NickelsLabel.Size = new System.Drawing.Size(42, 13);
            this.NickelsLabel.TabIndex = 7;
            this.NickelsLabel.Text = "Nickels";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(72, 260);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(183, 260);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Pennies
            // 
            this.Pennies.AutoSize = true;
            this.Pennies.Location = new System.Drawing.Point(38, 212);
            this.Pennies.Name = "Pennies";
            this.Pennies.Size = new System.Drawing.Size(45, 13);
            this.Pennies.TabIndex = 10;
            this.Pennies.Text = "Pennies";
            // 
            // PenniesTextbox
            // 
            this.PenniesTextbox.Location = new System.Drawing.Point(235, 212);
            this.PenniesTextbox.Name = "PenniesTextbox";
            this.PenniesTextbox.ReadOnly = true;
            this.PenniesTextbox.Size = new System.Drawing.Size(100, 20);
            this.PenniesTextbox.TabIndex = 11;
            // 
            // ChangeCalculatorForm
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.PenniesTextbox);
            this.Controls.Add(this.Pennies);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NickelsLabel);
            this.Controls.Add(this.NickelsTextbox);
            this.Controls.Add(this.DimesTextbox);
            this.Controls.Add(this.QuartersTextbox);
            this.Controls.Add(this.ChangeDueTextbox);
            this.Controls.Add(this.DimesLabel);
            this.Controls.Add(this.QuartersLabel);
            this.Controls.Add(this.ChangeDueLabel);
            this.Name = "ChangeCalculatorForm";
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeDueLabel;
        private System.Windows.Forms.Label QuartersLabel;
        private System.Windows.Forms.Label DimesLabel;
        private System.Windows.Forms.TextBox ChangeDueTextbox;
        private System.Windows.Forms.TextBox QuartersTextbox;
        private System.Windows.Forms.TextBox DimesTextbox;
        private System.Windows.Forms.TextBox NickelsTextbox;
        private System.Windows.Forms.Label NickelsLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Pennies;
        private System.Windows.Forms.TextBox PenniesTextbox;
    }
}

