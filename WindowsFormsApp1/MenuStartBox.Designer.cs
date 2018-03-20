namespace TicTacToe
{
    partial class MenuStartBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStartBox));
            this.playervsplayer = new System.Windows.Forms.Button();
            this.playervscomputer = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playervsplayer
            // 
            this.playervsplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playervsplayer.Location = new System.Drawing.Point(118, 141);
            this.playervsplayer.Name = "playervsplayer";
            this.playervsplayer.Size = new System.Drawing.Size(223, 39);
            this.playervsplayer.TabIndex = 2;
            this.playervsplayer.Text = "Gracz vs Gracz";
            this.playervsplayer.UseVisualStyleBackColor = true;
            this.playervsplayer.Click += new System.EventHandler(this.playervsplayer_Click);
            // 
            // playervscomputer
            // 
            this.playervscomputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playervscomputer.Location = new System.Drawing.Point(118, 206);
            this.playervscomputer.Name = "playervscomputer";
            this.playervscomputer.Size = new System.Drawing.Size(223, 39);
            this.playervscomputer.TabIndex = 3;
            this.playervscomputer.Text = "Gracz vs Komputer";
            this.playervscomputer.UseVisualStyleBackColor = true;
            this.playervscomputer.Click += new System.EventHandler(this.playervscomputer_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplayerButton.Location = new System.Drawing.Point(118, 271);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(223, 39);
            this.multiplayerButton.TabIndex = 4;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.multiplayerButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 42);
            this.panel1.TabIndex = 5;
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
            this.closeButton.Location = new System.Drawing.Point(423, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButtonMouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButtonMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kółko i Krzyżyk";
            // 
            // MenuStartBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(462, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.playervscomputer);
            this.Controls.Add(this.playervsplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuStartBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-tac-toe - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuStartBox_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playervsplayer;
        private System.Windows.Forms.Button playervscomputer;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}