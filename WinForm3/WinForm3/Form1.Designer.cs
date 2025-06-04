namespace WinForm3
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
            TextBox textBoxT;
            buttonCTF = new Button();
            buttonFTC = new Button();
            labelResult = new Label();
            labelMain = new Label();
            button1 = new Button();
            textBoxT = new TextBox();
            SuspendLayout();
            // 
            // textBoxT
            // 
            textBoxT.Cursor = Cursors.IBeam;
            textBoxT.ForeColor = SystemColors.WindowFrame;
            textBoxT.Location = new Point(12, 27);
            textBoxT.Name = "textBoxT";
            textBoxT.PlaceholderText = "Введите значение";
            textBoxT.Size = new Size(176, 23);
            textBoxT.TabIndex = 0;
            textBoxT.Tag = "Введите значение";
            textBoxT.TextChanged += textBoxT_TextChanged;
            // 
            // buttonCTF
            // 
            buttonCTF.Location = new Point(12, 56);
            buttonCTF.Name = "buttonCTF";
            buttonCTF.Size = new Size(85, 23);
            buttonCTF.TabIndex = 1;
            buttonCTF.Text = "В Фаренгейт";
            buttonCTF.UseVisualStyleBackColor = true;
            buttonCTF.Click += buttonCTF_Click;
            // 
            // buttonFTC
            // 
            buttonFTC.Location = new Point(103, 56);
            buttonFTC.Name = "buttonFTC";
            buttonFTC.Size = new Size(85, 23);
            buttonFTC.TabIndex = 2;
            buttonFTC.Text = "В Цельсий";
            buttonFTC.UseVisualStyleBackColor = true;
            buttonFTC.Click += buttonFTC_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(194, 30);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат:";
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Location = new Point(12, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(132, 15);
            labelMain.TabIndex = 4;
            labelMain.Text = "Конвертер температур";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(249, 65);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 6;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(311, 87);
            Controls.Add(button1);
            Controls.Add(labelMain);
            Controls.Add(labelResult);
            Controls.Add(buttonFTC);
            Controls.Add(buttonCTF);
            Controls.Add(textBoxT);
            Name = "Form1";
            Text = "Задание 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxT;
        private Button buttonCTF;
        private Button buttonFTC;
        private Label labelResult;
        private Label labelMain;
        private Button button1;
    }
}
