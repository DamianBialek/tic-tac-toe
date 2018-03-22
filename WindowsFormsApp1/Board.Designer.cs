namespace TicTacToe
{
    partial class Board
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.label1 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.field1 = new System.Windows.Forms.RichTextBox();
            this.field2 = new System.Windows.Forms.RichTextBox();
            this.field3 = new System.Windows.Forms.RichTextBox();
            this.field4 = new System.Windows.Forms.RichTextBox();
            this.field5 = new System.Windows.Forms.RichTextBox();
            this.field6 = new System.Windows.Forms.RichTextBox();
            this.field7 = new System.Windows.Forms.RichTextBox();
            this.field8 = new System.Windows.Forms.RichTextBox();
            this.field9 = new System.Windows.Forms.RichTextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScoreX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelScoreY = new System.Windows.Forms.Label();
            this.continueGameButton = new System.Windows.Forms.Button();
            this.typeOfGameLabel = new System.Windows.Forms.Label();
            this.debugInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gracz:";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerName.Location = new System.Drawing.Point(140, 130);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(2, 39);
            this.playerName.TabIndex = 10;
            // 
            // field1
            // 
            this.field1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field1.Location = new System.Drawing.Point(29, 208);
            this.field1.Name = "field1";
            this.field1.ReadOnly = true;
            this.field1.Size = new System.Drawing.Size(54, 51);
            this.field1.TabIndex = 11;
            this.field1.Text = "";
            this.field1.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field2
            // 
            this.field2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field2.Location = new System.Drawing.Point(80, 208);
            this.field2.Name = "field2";
            this.field2.ReadOnly = true;
            this.field2.Size = new System.Drawing.Size(54, 51);
            this.field2.TabIndex = 12;
            this.field2.Text = "";
            this.field2.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field3
            // 
            this.field3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field3.Location = new System.Drawing.Point(130, 208);
            this.field3.Name = "field3";
            this.field3.ReadOnly = true;
            this.field3.Size = new System.Drawing.Size(54, 51);
            this.field3.TabIndex = 13;
            this.field3.Text = "";
            this.field3.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field4
            // 
            this.field4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field4.Location = new System.Drawing.Point(29, 256);
            this.field4.Name = "field4";
            this.field4.ReadOnly = true;
            this.field4.Size = new System.Drawing.Size(54, 51);
            this.field4.TabIndex = 14;
            this.field4.Text = "";
            this.field4.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field5
            // 
            this.field5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field5.Location = new System.Drawing.Point(80, 256);
            this.field5.Name = "field5";
            this.field5.ReadOnly = true;
            this.field5.Size = new System.Drawing.Size(54, 51);
            this.field5.TabIndex = 15;
            this.field5.Text = "";
            this.field5.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field6
            // 
            this.field6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field6.Location = new System.Drawing.Point(130, 256);
            this.field6.Name = "field6";
            this.field6.ReadOnly = true;
            this.field6.Size = new System.Drawing.Size(54, 51);
            this.field6.TabIndex = 16;
            this.field6.Text = "";
            this.field6.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field7
            // 
            this.field7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field7.Location = new System.Drawing.Point(29, 304);
            this.field7.Name = "field7";
            this.field7.ReadOnly = true;
            this.field7.Size = new System.Drawing.Size(54, 51);
            this.field7.TabIndex = 17;
            this.field7.Text = "";
            this.field7.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field8
            // 
            this.field8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field8.Location = new System.Drawing.Point(80, 304);
            this.field8.Name = "field8";
            this.field8.ReadOnly = true;
            this.field8.Size = new System.Drawing.Size(54, 51);
            this.field8.TabIndex = 18;
            this.field8.Text = "";
            this.field8.Click += new System.EventHandler(this.insertPlayer);
            // 
            // field9
            // 
            this.field9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.field9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field9.Location = new System.Drawing.Point(130, 304);
            this.field9.Name = "field9";
            this.field9.ReadOnly = true;
            this.field9.Size = new System.Drawing.Size(54, 51);
            this.field9.TabIndex = 19;
            this.field9.Text = "";
            this.field9.Click += new System.EventHandler(this.insertPlayer);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameButton.Location = new System.Drawing.Point(313, 304);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(160, 51);
            this.newGameButton.TabIndex = 20;
            this.newGameButton.Text = "Nowa gra";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGame);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(306, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "X:";
            // 
            // labelScoreX
            // 
            this.labelScoreX.AutoSize = true;
            this.labelScoreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScoreX.Location = new System.Drawing.Point(343, 132);
            this.labelScoreX.Name = "labelScoreX";
            this.labelScoreX.Size = new System.Drawing.Size(35, 37);
            this.labelScoreX.TabIndex = 22;
            this.labelScoreX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(394, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(467, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 37);
            this.label5.TabIndex = 24;
            this.label5.Text = ":O";
            // 
            // labelScoreY
            // 
            this.labelScoreY.AutoSize = true;
            this.labelScoreY.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScoreY.Location = new System.Drawing.Point(438, 132);
            this.labelScoreY.Name = "labelScoreY";
            this.labelScoreY.Size = new System.Drawing.Size(35, 37);
            this.labelScoreY.TabIndex = 25;
            this.labelScoreY.Text = "0";
            // 
            // continueGameButton
            // 
            this.continueGameButton.Enabled = false;
            this.continueGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueGameButton.Location = new System.Drawing.Point(313, 208);
            this.continueGameButton.Name = "continueGameButton";
            this.continueGameButton.Size = new System.Drawing.Size(160, 51);
            this.continueGameButton.TabIndex = 26;
            this.continueGameButton.Text = "Kontynuuj grę";
            this.continueGameButton.UseVisualStyleBackColor = true;
            this.continueGameButton.Visible = false;
            this.continueGameButton.Click += new System.EventHandler(this.continueGame);
            // 
            // typeOfGameLabel
            // 
            this.typeOfGameLabel.AutoSize = true;
            this.typeOfGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeOfGameLabel.Location = new System.Drawing.Point(186, 62);
            this.typeOfGameLabel.Name = "typeOfGameLabel";
            this.typeOfGameLabel.Size = new System.Drawing.Size(79, 29);
            this.typeOfGameLabel.TabIndex = 27;
            this.typeOfGameLabel.Text = "label3";
            // 
            // debugInfo
            // 
            this.debugInfo.AutoSize = true;
            this.debugInfo.Location = new System.Drawing.Point(26, 375);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(0, 13);
            this.debugInfo.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 43);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(479, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButtonMouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButtonMouseLeave);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.debugInfo);
            this.Controls.Add(this.typeOfGameLabel);
            this.Controls.Add(this.continueGameButton);
            this.Controls.Add(this.labelScoreY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelScoreX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Board_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.RichTextBox field1;
        private System.Windows.Forms.RichTextBox field2;
        private System.Windows.Forms.RichTextBox field3;
        private System.Windows.Forms.RichTextBox field4;
        private System.Windows.Forms.RichTextBox field5;
        private System.Windows.Forms.RichTextBox field6;
        private System.Windows.Forms.RichTextBox field7;
        private System.Windows.Forms.RichTextBox field8;
        private System.Windows.Forms.RichTextBox field9;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScoreX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelScoreY;
        private System.Windows.Forms.Button continueGameButton;
        private System.Windows.Forms.Label typeOfGameLabel;
        private System.Windows.Forms.Label debugInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
    }
}

