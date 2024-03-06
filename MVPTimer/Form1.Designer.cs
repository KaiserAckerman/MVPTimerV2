using System.Windows.Forms;

namespace MVPTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton1 = new System.Windows.Forms.Button();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.timerLabel1 = new System.Windows.Forms.Label();
            this.MvpName = new System.Windows.Forms.Label();
            this.FallenUBI = new System.Windows.Forms.LinkLabel();
            this.Elemento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Elemento1 = new System.Windows.Forms.Label();
            this.IfritUBI = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel2 = new System.Windows.Forms.Label();
            this.resetButton2 = new System.Windows.Forms.Button();
            this.startButton2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton1
            // 
            this.startButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton1.Location = new System.Drawing.Point(52, 147);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(75, 23);
            this.startButton1.TabIndex = 0;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // resetButton1
            // 
            this.resetButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton1.Location = new System.Drawing.Point(153, 147);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(75, 23);
            this.resetButton1.TabIndex = 1;
            this.resetButton1.Text = "Reset";
            this.resetButton1.UseVisualStyleBackColor = false;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // timerLabel1
            // 
            this.timerLabel1.AutoSize = true;
            this.timerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timerLabel1.Location = new System.Drawing.Point(93, 102);
            this.timerLabel1.Name = "timerLabel1";
            this.timerLabel1.Size = new System.Drawing.Size(90, 25);
            this.timerLabel1.TabIndex = 2;
            this.timerLabel1.Text = "00:00:00";
            // 
            // MvpName
            // 
            this.MvpName.AutoSize = true;
            this.MvpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MvpName.Location = new System.Drawing.Point(48, 34);
            this.MvpName.Name = "MvpName";
            this.MvpName.Size = new System.Drawing.Size(180, 20);
            this.MvpName.TabIndex = 3;
            this.MvpName.Text = "Fallen Bishop Hibram";
            this.MvpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FallenUBI
            // 
            this.FallenUBI.AutoSize = true;
            this.FallenUBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FallenUBI.Location = new System.Drawing.Point(105, 69);
            this.FallenUBI.Name = "FallenUBI";
            this.FallenUBI.Size = new System.Drawing.Size(64, 17);
            this.FallenUBI.TabIndex = 4;
            this.FallenUBI.TabStop = true;
            this.FallenUBI.Text = "Abbey02";
            this.FallenUBI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FallenUBI.VisitedLinkColor = System.Drawing.Color.Blue;
            this.FallenUBI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UbicacionMVP_LinkClicked);
            // 
            // Elemento
            // 
            this.Elemento.AutoSize = true;
            this.Elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Elemento.ForeColor = System.Drawing.Color.Silver;
            this.Elemento.Location = new System.Drawing.Point(117, 54);
            this.Elemento.Name = "Elemento";
            this.Elemento.Size = new System.Drawing.Size(39, 15);
            this.Elemento.TabIndex = 5;
            this.Elemento.Text = "(Holy)";
            this.Elemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(38, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 155);
            this.panel1.TabIndex = 6;
            // 
            // Elemento1
            // 
            this.Elemento1.AutoSize = true;
            this.Elemento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Elemento1.ForeColor = System.Drawing.Color.DarkCyan;
            this.Elemento1.Location = new System.Drawing.Point(75, 29);
            this.Elemento1.Name = "Elemento1";
            this.Elemento1.Size = new System.Drawing.Size(47, 15);
            this.Elemento1.TabIndex = 12;
            this.Elemento1.Text = "(Water)";
            this.Elemento1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IfritUBI
            // 
            this.IfritUBI.AutoSize = true;
            this.IfritUBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IfritUBI.Location = new System.Drawing.Point(310, 69);
            this.IfritUBI.Name = "IfritUBI";
            this.IfritUBI.Size = new System.Drawing.Size(64, 17);
            this.IfritUBI.TabIndex = 11;
            this.IfritUBI.TabStop = true;
            this.IfritUBI.Text = "thor_v03";
            this.IfritUBI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IfritUBI.VisitedLinkColor = System.Drawing.Color.Blue;
            this.IfritUBI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IfritUBI_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ifrit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel2
            // 
            this.timerLabel2.AutoSize = true;
            this.timerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timerLabel2.Location = new System.Drawing.Point(298, 102);
            this.timerLabel2.Name = "timerLabel2";
            this.timerLabel2.Size = new System.Drawing.Size(90, 25);
            this.timerLabel2.TabIndex = 9;
            this.timerLabel2.Text = "00:00:00";
            // 
            // resetButton2
            // 
            this.resetButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton2.Location = new System.Drawing.Point(358, 147);
            this.resetButton2.Name = "resetButton2";
            this.resetButton2.Size = new System.Drawing.Size(75, 23);
            this.resetButton2.TabIndex = 8;
            this.resetButton2.Text = "Reset";
            this.resetButton2.UseVisualStyleBackColor = false;
            this.resetButton2.Click += new System.EventHandler(this.resetButton2_Click);
            // 
            // startButton2
            // 
            this.startButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton2.Location = new System.Drawing.Point(257, 147);
            this.startButton2.Name = "startButton2";
            this.startButton2.Size = new System.Drawing.Size(75, 23);
            this.startButton2.TabIndex = 7;
            this.startButton2.Text = "Start";
            this.startButton2.UseVisualStyleBackColor = false;
            this.startButton2.Click += new System.EventHandler(this.startButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.Elemento1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(243, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 155);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.IfritUBI);
            this.Controls.Add(this.timerLabel2);
            this.Controls.Add(this.resetButton2);
            this.Controls.Add(this.startButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Elemento);
            this.Controls.Add(this.FallenUBI);
            this.Controls.Add(this.MvpName);
            this.Controls.Add(this.timerLabel1);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton1;
        private Button resetButton1;
        private Label timerLabel1;
        private Label MvpName;
        private LinkLabel FallenUBI;
        private Label Elemento;
        private Panel panel1;
        private Label Elemento1;
        private LinkLabel IfritUBI;
        private Label label2;
        private Label timerLabel2;
        private Button resetButton2;
        private Button startButton2;
        private Panel panel2;
    }
}

