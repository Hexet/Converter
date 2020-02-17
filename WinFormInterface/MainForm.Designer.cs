namespace WinFormInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exit = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.trackP1 = new System.Windows.Forms.TrackBar();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.trackP2 = new System.Windows.Forms.TrackBar();
            this.but0 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.butA = new System.Windows.Forms.Button();
            this.butB = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butD = new System.Windows.Forms.Button();
            this.butE = new System.Windows.Forms.Button();
            this.butF = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.butExecut = new System.Windows.Forms.Button();
            this.numP1 = new System.Windows.Forms.NumericUpDown();
            this.numP2 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP2)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(0, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 25);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.Control;
            this.history.Cursor = System.Windows.Forms.Cursors.Default;
            this.history.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.history.FlatAppearance.BorderSize = 0;
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.Location = new System.Drawing.Point(83, 0);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history.Size = new System.Drawing.Size(86, 25);
            this.history.TabIndex = 1;
            this.history.Text = "История";
            this.history.UseVisualStyleBackColor = false;
            // 
            // help
            // 
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help.Location = new System.Drawing.Point(166, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(86, 25);
            this.help.TabIndex = 2;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 56);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(329, 20);
            this.sourceTextBox.TabIndex = 3;
            this.sourceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackP1
            // 
            this.trackP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackP1.Location = new System.Drawing.Point(12, 103);
            this.trackP1.Maximum = 16;
            this.trackP1.Minimum = 2;
            this.trackP1.Name = "trackP1";
            this.trackP1.Size = new System.Drawing.Size(329, 45);
            this.trackP1.TabIndex = 4;
            this.trackP1.Value = 10;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 184);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(329, 20);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackP2
            // 
            this.trackP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackP2.Location = new System.Drawing.Point(12, 228);
            this.trackP2.Maximum = 16;
            this.trackP2.Minimum = 2;
            this.trackP2.Name = "trackP2";
            this.trackP2.Size = new System.Drawing.Size(329, 45);
            this.trackP2.TabIndex = 6;
            this.trackP2.Value = 16;
            // 
            // but0
            // 
            this.but0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but0.Location = new System.Drawing.Point(12, 314);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(57, 25);
            this.but0.TabIndex = 7;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            // 
            // but1
            // 
            this.but1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but1.Location = new System.Drawing.Point(103, 314);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(57, 25);
            this.but1.TabIndex = 8;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            // 
            // but2
            // 
            this.but2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but2.Location = new System.Drawing.Point(195, 314);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(57, 25);
            this.but2.TabIndex = 9;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but3.Location = new System.Drawing.Point(284, 314);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(57, 25);
            this.but3.TabIndex = 10;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            // 
            // but4
            // 
            this.but4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but4.Location = new System.Drawing.Point(12, 345);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(57, 25);
            this.but4.TabIndex = 11;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            // 
            // but5
            // 
            this.but5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but5.Location = new System.Drawing.Point(103, 345);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(57, 25);
            this.but5.TabIndex = 12;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            // 
            // but6
            // 
            this.but6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but6.Location = new System.Drawing.Point(195, 345);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(57, 25);
            this.but6.TabIndex = 13;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            // 
            // but7
            // 
            this.but7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but7.Location = new System.Drawing.Point(284, 345);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(57, 25);
            this.but7.TabIndex = 14;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            // 
            // but8
            // 
            this.but8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but8.Location = new System.Drawing.Point(12, 376);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(57, 25);
            this.but8.TabIndex = 15;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            // 
            // but9
            // 
            this.but9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but9.Location = new System.Drawing.Point(103, 376);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(57, 25);
            this.but9.TabIndex = 16;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            // 
            // butA
            // 
            this.butA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butA.Location = new System.Drawing.Point(195, 376);
            this.butA.Name = "butA";
            this.butA.Size = new System.Drawing.Size(57, 25);
            this.butA.TabIndex = 17;
            this.butA.Text = "A";
            this.butA.UseVisualStyleBackColor = true;
            // 
            // butB
            // 
            this.butB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butB.Location = new System.Drawing.Point(284, 376);
            this.butB.Name = "butB";
            this.butB.Size = new System.Drawing.Size(57, 25);
            this.butB.TabIndex = 18;
            this.butB.Text = "B";
            this.butB.UseVisualStyleBackColor = true;
            // 
            // butC
            // 
            this.butC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butC.Location = new System.Drawing.Point(12, 407);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(57, 25);
            this.butC.TabIndex = 19;
            this.butC.Text = "C";
            this.butC.UseVisualStyleBackColor = true;
            // 
            // butD
            // 
            this.butD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butD.Location = new System.Drawing.Point(103, 407);
            this.butD.Name = "butD";
            this.butD.Size = new System.Drawing.Size(57, 25);
            this.butD.TabIndex = 20;
            this.butD.Text = "D";
            this.butD.UseVisualStyleBackColor = true;
            // 
            // butE
            // 
            this.butE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butE.Location = new System.Drawing.Point(195, 407);
            this.butE.Name = "butE";
            this.butE.Size = new System.Drawing.Size(57, 25);
            this.butE.TabIndex = 21;
            this.butE.Text = "E";
            this.butE.UseVisualStyleBackColor = true;
            // 
            // butF
            // 
            this.butF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butF.Location = new System.Drawing.Point(284, 407);
            this.butF.Name = "butF";
            this.butF.Size = new System.Drawing.Size(57, 25);
            this.butF.TabIndex = 22;
            this.butF.Text = "F";
            this.butF.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button17.Location = new System.Drawing.Point(12, 438);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(57, 25);
            this.button17.TabIndex = 23;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button18.Location = new System.Drawing.Point(103, 438);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 25);
            this.button18.TabIndex = 24;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button19.Location = new System.Drawing.Point(195, 438);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(57, 25);
            this.button19.TabIndex = 25;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // butExecut
            // 
            this.butExecut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExecut.Location = new System.Drawing.Point(284, 438);
            this.butExecut.Name = "butExecut";
            this.butExecut.Size = new System.Drawing.Size(57, 25);
            this.butExecut.TabIndex = 26;
            this.butExecut.Text = "Execut";
            this.butExecut.UseVisualStyleBackColor = true;
            // 
            // numP1
            // 
            this.numP1.Location = new System.Drawing.Point(305, 141);
            this.numP1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numP1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numP1.Name = "numP1";
            this.numP1.Size = new System.Drawing.Size(36, 20);
            this.numP1.TabIndex = 27;
            this.numP1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numP2
            // 
            this.numP2.Location = new System.Drawing.Point(305, 265);
            this.numP2.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numP2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numP2.Name = "numP2";
            this.numP2.Size = new System.Drawing.Size(36, 20);
            this.numP2.TabIndex = 28;
            this.numP2.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 487);
            this.Controls.Add(this.numP2);
            this.Controls.Add(this.numP1);
            this.Controls.Add(this.butExecut);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.butF);
            this.Controls.Add(this.butE);
            this.Controls.Add(this.butD);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butB);
            this.Controls.Add(this.butA);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.trackP2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.trackP1);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.help);
            this.Controls.Add(this.history);
            this.Controls.Add(this.exit);
            this.Name = "MainForm";
            this.Text = "Конвертер";
            ((System.ComponentModel.ISupportInitialize)(this.trackP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TrackBar trackP1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TrackBar trackP2;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button butA;
        private System.Windows.Forms.Button butB;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butD;
        private System.Windows.Forms.Button butE;
        private System.Windows.Forms.Button butF;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button butExecut;
        private System.Windows.Forms.NumericUpDown numP1;
        private System.Windows.Forms.NumericUpDown numP2;
        private System.Windows.Forms.Timer timer1;

    }
}

