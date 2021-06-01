using Sunny.UI;

namespace KEPServerEX
{
    partial class FHeaderMainFooter
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
            this.components = new System.ComponentModel.Container();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 593);
            this.Footer.Size = new System.Drawing.Size(1008, 88);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1008, 118);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // FHeaderMainFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Name = "FHeaderMainFooter";
            this.Text = "FHeaderMainFooter";
            this.ResumeLayout(false);

        }

        #endregion

        private UIStyleManager StyleManager;
    }
}