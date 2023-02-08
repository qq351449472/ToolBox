namespace ToolBox
{
    partial class MainForm
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
            this.bt_InterfaceTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_InterfaceTest
            // 
            this.bt_InterfaceTest.Location = new System.Drawing.Point(141, 75);
            this.bt_InterfaceTest.Name = "bt_InterfaceTest";
            this.bt_InterfaceTest.Size = new System.Drawing.Size(75, 23);
            this.bt_InterfaceTest.TabIndex = 0;
            this.bt_InterfaceTest.Text = "接口调试";
            this.bt_InterfaceTest.UseVisualStyleBackColor = true;
            this.bt_InterfaceTest.Click += new System.EventHandler(this.bt_InterfaceTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_InterfaceTest);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_InterfaceTest;
    }
}