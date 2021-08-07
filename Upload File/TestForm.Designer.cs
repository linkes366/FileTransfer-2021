namespace Upload_File
{
    partial class TestForm
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
            this.test_popup = new System.Windows.Forms.Button();
            this.test_popup_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // test_popup
            // 
            this.test_popup.Location = new System.Drawing.Point(12, 12);
            this.test_popup.Name = "test_popup";
            this.test_popup.Size = new System.Drawing.Size(75, 23);
            this.test_popup.TabIndex = 0;
            this.test_popup.Text = "test popup";
            this.test_popup.UseVisualStyleBackColor = true;
            this.test_popup.Click += new System.EventHandler(this.test_popup_Click);
            // 
            // test_popup_checkbox
            // 
            this.test_popup_checkbox.AutoSize = true;
            this.test_popup_checkbox.Location = new System.Drawing.Point(94, 17);
            this.test_popup_checkbox.Name = "test_popup_checkbox";
            this.test_popup_checkbox.Size = new System.Drawing.Size(76, 17);
            this.test_popup_checkbox.TabIndex = 1;
            this.test_popup_checkbox.Text = "test popup";
            this.test_popup_checkbox.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test_popup_checkbox);
            this.Controls.Add(this.test_popup);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test_popup;
        private System.Windows.Forms.CheckBox test_popup_checkbox;
    }
}