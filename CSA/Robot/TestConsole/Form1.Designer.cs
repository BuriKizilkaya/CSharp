namespace TestConsole
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
            this.consoleView = new RobotView.ConsoleView();
            this.SuspendLayout();
            // 
            // consoleView
            // 
            this.consoleView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.consoleView.Console = null;
            this.consoleView.Location = new System.Drawing.Point(92, 39);
            this.consoleView.Name = "consoleView";
            this.consoleView.Size = new System.Drawing.Size(211, 57);
            this.consoleView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(391, 155);
            this.Controls.Add(this.consoleView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.ConsoleView consoleView;
    }
}

