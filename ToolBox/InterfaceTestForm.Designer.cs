namespace ToolBox
{
    partial class InterfaceTestForm
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
            this.bt_Test = new System.Windows.Forms.Button();
            this.rt_Address = new System.Windows.Forms.RichTextBox();
            this.rt_InPara = new System.Windows.Forms.RichTextBox();
            this.rt_Result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Test
            // 
            this.bt_Test.Location = new System.Drawing.Point(653, 247);
            this.bt_Test.Name = "bt_Test";
            this.bt_Test.Size = new System.Drawing.Size(75, 23);
            this.bt_Test.TabIndex = 0;
            this.bt_Test.Text = "测试";
            this.bt_Test.UseVisualStyleBackColor = true;
            this.bt_Test.Click += new System.EventHandler(this.bt_Test_Click);
            // 
            // rt_Address
            // 
            this.rt_Address.Location = new System.Drawing.Point(129, 28);
            this.rt_Address.Name = "rt_Address";
            this.rt_Address.Size = new System.Drawing.Size(1065, 40);
            this.rt_Address.TabIndex = 1;
            this.rt_Address.Text = "";
            // 
            // rt_InPara
            // 
            this.rt_InPara.Location = new System.Drawing.Point(129, 74);
            this.rt_InPara.Name = "rt_InPara";
            this.rt_InPara.Size = new System.Drawing.Size(1065, 155);
            this.rt_InPara.TabIndex = 2;
            this.rt_InPara.Text = "";
            // 
            // rt_Result
            // 
            this.rt_Result.Location = new System.Drawing.Point(129, 276);
            this.rt_Result.Name = "rt_Result";
            this.rt_Result.Size = new System.Drawing.Size(1065, 517);
            this.rt_Result.TabIndex = 3;
            this.rt_Result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "入参：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "结果：";
            // 
            // InterfaceTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 805);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_Result);
            this.Controls.Add(this.rt_InPara);
            this.Controls.Add(this.rt_Address);
            this.Controls.Add(this.bt_Test);
            this.Name = "InterfaceTestForm";
            this.Text = "接口调试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_Test;
        private RichTextBox rt_Address;
        private RichTextBox rt_InPara;
        private RichTextBox rt_Result;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}