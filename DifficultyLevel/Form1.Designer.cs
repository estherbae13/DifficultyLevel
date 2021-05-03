
namespace DifficultyLevel
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.easyCheckBox = new System.Windows.Forms.CheckBox();
            this.mediumCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nameLabel.Location = new System.Drawing.Point(61, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(254, 39);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter your name:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nameInput.Location = new System.Drawing.Point(345, 45);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(258, 42);
            this.nameInput.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.difficultyLabel.Location = new System.Drawing.Point(175, 128);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(328, 39);
            this.difficultyLabel.TabIndex = 2;
            this.difficultyLabel.Text = "Choose Your Difficulty:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.startButton.Location = new System.Drawing.Point(231, 287);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(212, 63);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "begin";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.outputLabel.Location = new System.Drawing.Point(22, 392);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(627, 106);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // easyCheckBox
            // 
            this.easyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.easyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.easyCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.easyCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.easyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyCheckBox.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.easyCheckBox.Location = new System.Drawing.Point(68, 196);
            this.easyCheckBox.Name = "easyCheckBox";
            this.easyCheckBox.Size = new System.Drawing.Size(132, 57);
            this.easyCheckBox.TabIndex = 8;
            this.easyCheckBox.Text = "easy";
            this.easyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.easyCheckBox.UseVisualStyleBackColor = false;
            this.easyCheckBox.CheckedChanged += new System.EventHandler(this.easyCheckBox_CheckedChanged);
            // 
            // mediumCheckBox
            // 
            this.mediumCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.mediumCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.mediumCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.LemonChiffon;
            this.mediumCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.mediumCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumCheckBox.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mediumCheckBox.Location = new System.Drawing.Point(270, 196);
            this.mediumCheckBox.Name = "mediumCheckBox";
            this.mediumCheckBox.Size = new System.Drawing.Size(132, 57);
            this.mediumCheckBox.TabIndex = 9;
            this.mediumCheckBox.Text = "medium!";
            this.mediumCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mediumCheckBox.UseVisualStyleBackColor = false;
            this.mediumCheckBox.CheckedChanged += new System.EventHandler(this.mediumCheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox2.Location = new System.Drawing.Point(471, 196);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 57);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "hard!!!";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(675, 527);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.mediumCheckBox);
            this.Controls.Add(this.easyCheckBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Difficulty Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox easyCheckBox;
        private System.Windows.Forms.CheckBox mediumCheckBox;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

