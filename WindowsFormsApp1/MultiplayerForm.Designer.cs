namespace TicTacToe
{
    partial class MultiplayerForm
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
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.createNewServerButton = new System.Windows.Forms.Button();
            this.joinToServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(91, 12);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostTextBox.TabIndex = 0;
            this.hostTextBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(91, 38);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "1024";
            // 
            // createNewServerButton
            // 
            this.createNewServerButton.Location = new System.Drawing.Point(30, 91);
            this.createNewServerButton.Name = "createNewServerButton";
            this.createNewServerButton.Size = new System.Drawing.Size(161, 23);
            this.createNewServerButton.TabIndex = 4;
            this.createNewServerButton.Text = "Utwórz nowy serwer";
            this.createNewServerButton.UseVisualStyleBackColor = true;
            this.createNewServerButton.Click += new System.EventHandler(this.createNewServerButton_Click);
            // 
            // joinToServerButton
            // 
            this.joinToServerButton.Location = new System.Drawing.Point(30, 120);
            this.joinToServerButton.Name = "joinToServerButton";
            this.joinToServerButton.Size = new System.Drawing.Size(161, 23);
            this.joinToServerButton.TabIndex = 5;
            this.joinToServerButton.Text = "Dołącz do serwera";
            this.joinToServerButton.UseVisualStyleBackColor = true;
            this.joinToServerButton.Click += new System.EventHandler(this.joinToServerButton_Click);
            // 
            // MultiplayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 169);
            this.Controls.Add(this.joinToServerButton);
            this.Controls.Add(this.createNewServerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostTextBox);
            this.Name = "MultiplayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button createNewServerButton;
        private System.Windows.Forms.Button joinToServerButton;
    }
}