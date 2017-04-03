namespace TopGear
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMotorizacao = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.lblVelocidadeMaxima = new System.Windows.Forms.Label();
            this.lblQuantidadeMarchas = new System.Windows.Forms.Label();
            this.opala = new System.Windows.Forms.Button();
            this.mavekao = new System.Windows.Forms.Button();
            this.picOpalao = new System.Windows.Forms.PictureBox();
            this.picMavekao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOpalao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMavekao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(44, 26);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 14);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "lblModelo";
            this.lblModelo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(44, 78);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 14);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "lblMarcha";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(44, 128);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(40, 14);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "lblCor";
            // 
            // lblMotorizacao
            // 
            this.lblMotorizacao.AutoSize = true;
            this.lblMotorizacao.Location = new System.Drawing.Point(197, 26);
            this.lblMotorizacao.Name = "lblMotorizacao";
            this.lblMotorizacao.Size = new System.Drawing.Size(87, 14);
            this.lblMotorizacao.TabIndex = 3;
            this.lblMotorizacao.Text = "lblMotorizacao";
            this.lblMotorizacao.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(197, 78);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(100, 14);
            this.lblAnoFabricacao.TabIndex = 4;
            this.lblAnoFabricacao.Text = "lblAnoFabricacao";
            // 
            // lblVelocidadeMaxima
            // 
            this.lblVelocidadeMaxima.AutoSize = true;
            this.lblVelocidadeMaxima.Location = new System.Drawing.Point(197, 128);
            this.lblVelocidadeMaxima.Name = "lblVelocidadeMaxima";
            this.lblVelocidadeMaxima.Size = new System.Drawing.Size(122, 14);
            this.lblVelocidadeMaxima.TabIndex = 5;
            this.lblVelocidadeMaxima.Text = "lblVelocidadeMaxima";
            // 
            // lblQuantidadeMarchas
            // 
            this.lblQuantidadeMarchas.AutoSize = true;
            this.lblQuantidadeMarchas.Location = new System.Drawing.Point(387, 26);
            this.lblQuantidadeMarchas.Name = "lblQuantidadeMarchas";
            this.lblQuantidadeMarchas.Size = new System.Drawing.Size(129, 14);
            this.lblQuantidadeMarchas.TabIndex = 6;
            this.lblQuantidadeMarchas.Text = "lblQuantidadeMarchas";
            this.lblQuantidadeMarchas.Click += new System.EventHandler(this.label7_Click);
            // 
            // opala
            // 
            this.opala.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opala.Location = new System.Drawing.Point(47, 307);
            this.opala.Name = "opala";
            this.opala.Size = new System.Drawing.Size(105, 52);
            this.opala.TabIndex = 7;
            this.opala.Text = "Opalao 6 caneco turbo ";
            this.opala.UseVisualStyleBackColor = true;
            this.opala.Click += new System.EventHandler(this.button1_Click);
            // 
            // mavekao
            // 
            this.mavekao.Location = new System.Drawing.Point(349, 307);
            this.mavekao.Name = "mavekao";
            this.mavekao.Size = new System.Drawing.Size(99, 52);
            this.mavekao.TabIndex = 8;
            this.mavekao.Text = "Mevekao 302 cv v8 biturbo";
            this.mavekao.UseVisualStyleBackColor = true;
            this.mavekao.Click += new System.EventHandler(this.mavekao_Click);
            // 
            // picOpalao
            // 
            this.picOpalao.Image = ((System.Drawing.Image)(resources.GetObject("picOpalao.Image")));
            this.picOpalao.Location = new System.Drawing.Point(23, 169);
            this.picOpalao.Name = "picOpalao";
            this.picOpalao.Size = new System.Drawing.Size(180, 123);
            this.picOpalao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpalao.TabIndex = 9;
            this.picOpalao.TabStop = false;
            // 
            // picMavekao
            // 
            this.picMavekao.Image = ((System.Drawing.Image)(resources.GetObject("picMavekao.Image")));
            this.picMavekao.Location = new System.Drawing.Point(312, 169);
            this.picMavekao.Name = "picMavekao";
            this.picMavekao.Size = new System.Drawing.Size(180, 123);
            this.picMavekao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMavekao.TabIndex = 10;
            this.picMavekao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 371);
            this.Controls.Add(this.picMavekao);
            this.Controls.Add(this.picOpalao);
            this.Controls.Add(this.mavekao);
            this.Controls.Add(this.opala);
            this.Controls.Add(this.lblQuantidadeMarchas);
            this.Controls.Add(this.lblVelocidadeMaxima);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.lblMotorizacao);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOpalao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMavekao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMotorizacao;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.Label lblVelocidadeMaxima;
        private System.Windows.Forms.Label lblQuantidadeMarchas;
        private System.Windows.Forms.Button opala;
        private System.Windows.Forms.Button mavekao;
        private System.Windows.Forms.PictureBox picOpalao;
        private System.Windows.Forms.PictureBox picMavekao;
    }
}

