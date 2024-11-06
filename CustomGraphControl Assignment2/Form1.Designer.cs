namespace CustomGraphControl_Assignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAddData = new Button();
            textBoxInput = new TextBox();
            pieChartControl1 = new PieChartControl();
            SuspendLayout();
            // 
            // buttonAddData
            // 
            buttonAddData.Location = new Point(408, 83);
            buttonAddData.Name = "buttonAddData";
            buttonAddData.Size = new Size(112, 34);
            buttonAddData.TabIndex = 0;
            buttonAddData.Text = "Add Data";
            buttonAddData.UseVisualStyleBackColor = true;
            buttonAddData.Click += buttonAddData_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(611, 83);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(150, 31);
            textBoxInput.TabIndex = 1;
            // 
            // pieChartControl1
            // 
            pieChartControl1.Data = (List<float>)resources.GetObject("pieChartControl1.Data");
            pieChartControl1.Location = new Point(300, 266);
            pieChartControl1.Name = "pieChartControl1";
            pieChartControl1.Size = new Size(112, 34);
            pieChartControl1.TabIndex = 2;
            pieChartControl1.Text = "pieChartControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pieChartControl1);
            Controls.Add(textBoxInput);
            Controls.Add(buttonAddData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddData;
        private TextBox textBoxInput;
        private PieChartControl pieChartControl1;
        
    }
}
