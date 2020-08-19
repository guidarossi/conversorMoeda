namespace conversorMoeda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.realDolar = new System.Windows.Forms.RadioButton();
            this.dolarReal = new System.Windows.Forms.RadioButton();
            this.realEuro = new System.Windows.Forms.RadioButton();
            this.euroReal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt1
            // 
            resources.ApplyResources(this.txt1, "txt1");
            this.txt1.Name = "txt1";
            // 
            // realDolar
            // 
            resources.ApplyResources(this.realDolar, "realDolar");
            this.realDolar.Name = "realDolar";
            this.realDolar.TabStop = true;
            this.realDolar.UseVisualStyleBackColor = true;
            this.realDolar.CheckedChanged += new System.EventHandler(this.realDolar_CheckedChanged);
            // 
            // dolarReal
            // 
            resources.ApplyResources(this.dolarReal, "dolarReal");
            this.dolarReal.Name = "dolarReal";
            this.dolarReal.TabStop = true;
            this.dolarReal.UseVisualStyleBackColor = true;
            this.dolarReal.CheckedChanged += new System.EventHandler(this.dolarReal_CheckedChanged);
            // 
            // realEuro
            // 
            resources.ApplyResources(this.realEuro, "realEuro");
            this.realEuro.Name = "realEuro";
            this.realEuro.TabStop = true;
            this.realEuro.UseVisualStyleBackColor = true;
            this.realEuro.CheckedChanged += new System.EventHandler(this.realEuro_CheckedChanged);
            // 
            // euroReal
            // 
            resources.ApplyResources(this.euroReal, "euroReal");
            this.euroReal.Name = "euroReal";
            this.euroReal.TabStop = true;
            this.euroReal.UseVisualStyleBackColor = true;
            this.euroReal.CheckedChanged += new System.EventHandler(this.euroReal_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt2
            // 
            resources.ApplyResources(this.txt2, "txt2");
            this.txt2.Name = "txt2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::conversorMoeda.Properties.Resources.delete_delete_exit_1577;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::conversorMoeda.Properties.Resources.moneycoinorbuttonwithdollarsigninblackcircle_79870;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.euroReal);
            this.Controls.Add(this.realEuro);
            this.Controls.Add(this.dolarReal);
            this.Controls.Add(this.realDolar);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.RadioButton realDolar;
        private System.Windows.Forms.RadioButton dolarReal;
        private System.Windows.Forms.RadioButton realEuro;
        private System.Windows.Forms.RadioButton euroReal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
    }
}

