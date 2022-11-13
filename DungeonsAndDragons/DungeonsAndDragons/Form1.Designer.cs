namespace DungeonsAndDragons
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dieTypeSelect = new System.Windows.Forms.ComboBox();
            this.numOfDieSelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dieCombo_Label = new System.Windows.Forms.Label();
            this.dieTotal_Label = new System.Windows.Forms.Label();
            this.roll_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDieSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dieTypeSelect
            // 
            this.dieTypeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dieTypeSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dieTypeSelect.ForeColor = System.Drawing.Color.Red;
            this.dieTypeSelect.FormattingEnabled = true;
            this.dieTypeSelect.Items.AddRange(new object[] {
            "D4",
            "D6",
            "D10",
            "D12",
            "D20"});
            this.dieTypeSelect.Location = new System.Drawing.Point(384, 168);
            this.dieTypeSelect.Name = "dieTypeSelect";
            this.dieTypeSelect.Size = new System.Drawing.Size(121, 29);
            this.dieTypeSelect.TabIndex = 1;
            // 
            // numOfDieSelect
            // 
            this.numOfDieSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numOfDieSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numOfDieSelect.ForeColor = System.Drawing.Color.Red;
            this.numOfDieSelect.Location = new System.Drawing.Point(384, 208);
            this.numOfDieSelect.Name = "numOfDieSelect";
            this.numOfDieSelect.Size = new System.Drawing.Size(120, 29);
            this.numOfDieSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Die Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dungeons and Dragons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Die:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "You Roll:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(240, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your Resut is:";
            // 
            // dieCombo_Label
            // 
            this.dieCombo_Label.AutoSize = true;
            this.dieCombo_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dieCombo_Label.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dieCombo_Label.ForeColor = System.Drawing.Color.Red;
            this.dieCombo_Label.Location = new System.Drawing.Point(384, 336);
            this.dieCombo_Label.MinimumSize = new System.Drawing.Size(120, 0);
            this.dieCombo_Label.Name = "dieCombo_Label";
            this.dieCombo_Label.Size = new System.Drawing.Size(120, 24);
            this.dieCombo_Label.TabIndex = 9;
            // 
            // dieTotal_Label
            // 
            this.dieTotal_Label.AutoSize = true;
            this.dieTotal_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dieTotal_Label.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dieTotal_Label.ForeColor = System.Drawing.Color.Red;
            this.dieTotal_Label.Location = new System.Drawing.Point(384, 376);
            this.dieTotal_Label.MinimumSize = new System.Drawing.Size(120, 0);
            this.dieTotal_Label.Name = "dieTotal_Label";
            this.dieTotal_Label.Size = new System.Drawing.Size(120, 24);
            this.dieTotal_Label.TabIndex = 10;
            // 
            // roll_Button
            // 
            this.roll_Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roll_Button.Location = new System.Drawing.Point(336, 264);
            this.roll_Button.Name = "roll_Button";
            this.roll_Button.Size = new System.Drawing.Size(80, 32);
            this.roll_Button.TabIndex = 11;
            this.roll_Button.Text = "Roll";
            this.roll_Button.UseVisualStyleBackColor = true;
            this.roll_Button.Click += new System.EventHandler(this.roll_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DungeonsAndDragons.Properties.Resources.DungeonImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roll_Button);
            this.Controls.Add(this.dieTotal_Label);
            this.Controls.Add(this.dieCombo_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfDieSelect);
            this.Controls.Add(this.dieTypeSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOfDieSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox dieTypeSelect;
        private NumericUpDown numOfDieSelect;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label dieCombo_Label;
        private Label dieTotal_Label;
        private Button roll_Button;
    }
}