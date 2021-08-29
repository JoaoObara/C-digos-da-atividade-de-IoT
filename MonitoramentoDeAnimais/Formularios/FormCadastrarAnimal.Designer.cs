
namespace MonitoramentoDeAnimais.Formularios
{
    partial class FormCadastrarAnimal
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
            this.edNumeroId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdMacho = new System.Windows.Forms.RadioButton();
            this.rdFemea = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edNumeroIdMae = new System.Windows.Forms.TextBox();
            this.edNumeroIdPai = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.edPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edNumeroId
            // 
            this.edNumeroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNumeroId.Location = new System.Drawing.Point(378, 132);
            this.edNumeroId.Name = "edNumeroId";
            this.edNumeroId.Size = new System.Drawing.Size(174, 27);
            this.edNumeroId.TabIndex = 0;
            this.edNumeroId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edNumeroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edNumeroId_KeyPress);
            this.edNumeroId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edNumeroId_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de nascimento";
            // 
            // dtNasc
            // 
            this.dtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNasc.Location = new System.Drawing.Point(47, 132);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(281, 27);
            this.dtNasc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de identidentificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // rdMacho
            // 
            this.rdMacho.AutoSize = true;
            this.rdMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMacho.Location = new System.Drawing.Point(47, 238);
            this.rdMacho.Name = "rdMacho";
            this.rdMacho.Size = new System.Drawing.Size(80, 24);
            this.rdMacho.TabIndex = 5;
            this.rdMacho.TabStop = true;
            this.rdMacho.Text = "Macho";
            this.rdMacho.UseVisualStyleBackColor = true;
            this.rdMacho.Click += new System.EventHandler(this.rdMacho_Click);
            // 
            // rdFemea
            // 
            this.rdFemea.AutoSize = true;
            this.rdFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemea.Location = new System.Drawing.Point(148, 238);
            this.rdFemea.Name = "rdFemea";
            this.rdFemea.Size = new System.Drawing.Size(81, 24);
            this.rdFemea.TabIndex = 6;
            this.rdFemea.TabStop = true;
            this.rdFemea.Text = "Fêmea";
            this.rdFemea.UseVisualStyleBackColor = true;
            this.rdFemea.Click += new System.EventHandler(this.rdFemea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(700, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id da mãe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id do pai";
            // 
            // edNumeroIdMae
            // 
            this.edNumeroIdMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNumeroIdMae.Location = new System.Drawing.Point(704, 238);
            this.edNumeroIdMae.Name = "edNumeroIdMae";
            this.edNumeroIdMae.Size = new System.Drawing.Size(103, 27);
            this.edNumeroIdMae.TabIndex = 4;
            this.edNumeroIdMae.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edNumeroIdMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edNumeroIdMae_KeyPress);
            this.edNumeroIdMae.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edNumeroIdMae_KeyUp);
            // 
            // edNumeroIdPai
            // 
            this.edNumeroIdPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNumeroIdPai.Location = new System.Drawing.Point(534, 238);
            this.edNumeroIdPai.Name = "edNumeroIdPai";
            this.edNumeroIdPai.Size = new System.Drawing.Size(103, 27);
            this.edNumeroIdPai.TabIndex = 3;
            this.edNumeroIdPai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edNumeroIdPai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edNumeroIdPai_KeyPress);
            this.edNumeroIdPai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edNumeroIdPai_KeyUp);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(115, 346);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(174, 92);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(581, 346);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(174, 92);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // edPeso
            // 
            this.edPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edPeso.Location = new System.Drawing.Point(704, 132);
            this.edPeso.Name = "edPeso";
            this.edPeso.Size = new System.Drawing.Size(103, 27);
            this.edPeso.TabIndex = 1;
            this.edPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edPeso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edPeso_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Peso(Kg)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // edEstado
            // 
            this.edEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edEstado.Location = new System.Drawing.Point(288, 237);
            this.edEstado.Name = "edEstado";
            this.edEstado.Size = new System.Drawing.Size(181, 27);
            this.edEstado.TabIndex = 2;
            this.edEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edEstado_KeyUp);
            // 
            // FormCadastrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 475);
            this.Controls.Add(this.edPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.edNumeroIdPai);
            this.Controls.Add(this.edNumeroIdMae);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdFemea);
            this.Controls.Add(this.rdMacho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edNumeroId);
            this.Controls.Add(this.edEstado);
            this.Name = "FormCadastrarAnimal";
            this.Text = "Cadastrar Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edNumeroId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdMacho;
        private System.Windows.Forms.RadioButton rdFemea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edNumeroIdMae;
        private System.Windows.Forms.TextBox edNumeroIdPai;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox edPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edEstado;
    }
}