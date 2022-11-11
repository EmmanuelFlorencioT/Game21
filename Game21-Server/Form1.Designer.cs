namespace Game21_Server
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIntroPlayers = new System.Windows.Forms.Button();
            this.LabPlayer1IP = new System.Windows.Forms.Label();
            this.LabPlayer2IP = new System.Windows.Forms.Label();
            this.BtnStopIntro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIntroPlayers
            // 
            this.BtnIntroPlayers.Location = new System.Drawing.Point(63, 28);
            this.BtnIntroPlayers.Name = "BtnIntroPlayers";
            this.BtnIntroPlayers.Size = new System.Drawing.Size(125, 23);
            this.BtnIntroPlayers.TabIndex = 0;
            this.BtnIntroPlayers.Text = "Introduction Players";
            this.BtnIntroPlayers.UseVisualStyleBackColor = true;
            this.BtnIntroPlayers.Click += new System.EventHandler(this.BtnIntroPlayers_Click);
            // 
            // LabPlayer1IP
            // 
            this.LabPlayer1IP.AutoSize = true;
            this.LabPlayer1IP.Location = new System.Drawing.Point(48, 74);
            this.LabPlayer1IP.Name = "LabPlayer1IP";
            this.LabPlayer1IP.Size = new System.Drawing.Size(64, 13);
            this.LabPlayer1IP.TabIndex = 1;
            this.LabPlayer1IP.Text = "Player 1 IP: ";
            // 
            // LabPlayer2IP
            // 
            this.LabPlayer2IP.AutoSize = true;
            this.LabPlayer2IP.Location = new System.Drawing.Point(47, 100);
            this.LabPlayer2IP.Name = "LabPlayer2IP";
            this.LabPlayer2IP.Size = new System.Drawing.Size(64, 13);
            this.LabPlayer2IP.TabIndex = 2;
            this.LabPlayer2IP.Text = "Player 2 IP: ";
            // 
            // BtnStopIntro
            // 
            this.BtnStopIntro.Location = new System.Drawing.Point(63, 140);
            this.BtnStopIntro.Name = "BtnStopIntro";
            this.BtnStopIntro.Size = new System.Drawing.Size(125, 23);
            this.BtnStopIntro.TabIndex = 3;
            this.BtnStopIntro.Text = "Stop Introduction";
            this.BtnStopIntro.UseVisualStyleBackColor = true;
            this.BtnStopIntro.Click += new System.EventHandler(this.BtnStopIntro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStopIntro);
            this.Controls.Add(this.LabPlayer2IP);
            this.Controls.Add(this.LabPlayer1IP);
            this.Controls.Add(this.BtnIntroPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIntroPlayers;
        private System.Windows.Forms.Label LabPlayer1IP;
        private System.Windows.Forms.Label LabPlayer2IP;
        private System.Windows.Forms.Button BtnStopIntro;
    }
}

