namespace dnd5eCharacterSheet
{
    partial class mainFormWindow
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
            this.strValue = new System.Windows.Forms.NumericUpDown();
            this.strLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.conLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.charName = new System.Windows.Forms.Label();
            this.charNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // strValue
            // 
            this.strValue.Location = new System.Drawing.Point(86, 83);
            this.strValue.Name = "strValue";
            this.strValue.Size = new System.Drawing.Size(41, 20);
            this.strValue.TabIndex = 0;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(13, 85);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(47, 13);
            this.strLabel.TabIndex = 1;
            this.strLabel.Text = "Strength";
            this.strLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(13, 119);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(48, 13);
            this.dexLabel.TabIndex = 3;
            this.dexLabel.Text = "Dexterity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(86, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(13, 150);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(59, 13);
            this.conLabel.TabIndex = 5;
            this.conLabel.Text = "Consitution";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(86, 148);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // charName
            // 
            this.charName.AutoSize = true;
            this.charName.Location = new System.Drawing.Point(17, 16);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(84, 13);
            this.charName.TabIndex = 6;
            this.charName.Text = "Character Name";
            this.charName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // charNameTextBox
            // 
            this.charNameTextBox.Location = new System.Drawing.Point(107, 13);
            this.charNameTextBox.Name = "charNameTextBox";
            this.charNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.charNameTextBox.TabIndex = 7;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(107, 38);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.playerNameTextBox.TabIndex = 9;
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(17, 41);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(67, 13);
            this.playerLabel.TabIndex = 8;
            this.playerLabel.Text = "Player Name";
            this.playerLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // mainFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 629);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.charNameTextBox);
            this.Controls.Add(this.charName);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.strValue);
            this.Name = "mainFormWindow";
            this.Text = "D&D 5e Character Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown strValue;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label charName;
        private System.Windows.Forms.TextBox charNameTextBox;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerLabel;
    }
}

