namespace Ueb03_GUI
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
            this.checkbox_neg = new System.Windows.Forms.CheckBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox_neg
            // 
            this.checkbox_neg.AutoSize = true;
            this.checkbox_neg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_neg.Location = new System.Drawing.Point(60, 34);
            this.checkbox_neg.Name = "checkbox_neg";
            this.checkbox_neg.Size = new System.Drawing.Size(58, 21);
            this.checkbox_neg.TabIndex = 0;
            this.checkbox_neg.Text = "neg.";
            this.checkbox_neg.UseVisualStyleBackColor = true;
            this.checkbox_neg.Click += new System.EventHandler(this.CheckBoxClicck);
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxValue.Location = new System.Drawing.Point(158, 34);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(60, 74);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClick);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(158, 74);
            this.numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown.TabIndex = 3;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numbericUpDownValueChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(305, 127);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.checkbox_neg);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_neg;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

