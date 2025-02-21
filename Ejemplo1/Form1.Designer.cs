namespace Ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbtWizird = new System.Windows.Forms.RadioButton();
            this.rbtMugel = new System.Windows.Forms.RadioButton();
            this.rbtSkills = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cboColorFav = new System.Windows.Forms.ComboBox();
            this.lbNumeroFavorito = new System.Windows.Forms.Label();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(380, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(249, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(311, 263);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(197, 146);
            this.lwElementos.TabIndex = 2;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(280, 54);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(280, 93);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(90, 13);
            this.lbFechaNac.TabIndex = 4;
            this.lbFechaNac.Text = "FechaNacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(380, 86);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(378, 129);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(130, 17);
            this.ckbChocolate.TabIndex = 6;
            this.ckbChocolate.Text = "Te gusta el Chocolote";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(260, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(184, 31);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Perfil Persona";
            // 
            // rbtWizird
            // 
            this.rbtWizird.AutoSize = true;
            this.rbtWizird.Checked = true;
            this.rbtWizird.Location = new System.Drawing.Point(6, 43);
            this.rbtWizird.Name = "rbtWizird";
            this.rbtWizird.Size = new System.Drawing.Size(58, 17);
            this.rbtWizird.TabIndex = 8;
            this.rbtWizird.TabStop = true;
            this.rbtWizird.Text = "Wizard";
            this.rbtWizird.UseVisualStyleBackColor = true;
            // 
            // rbtMugel
            // 
            this.rbtMugel.AutoSize = true;
            this.rbtMugel.Location = new System.Drawing.Point(109, 43);
            this.rbtMugel.Name = "rbtMugel";
            this.rbtMugel.Size = new System.Drawing.Size(54, 17);
            this.rbtMugel.TabIndex = 9;
            this.rbtMugel.Text = "Mugel";
            this.rbtMugel.UseVisualStyleBackColor = true;
            // 
            // rbtSkills
            // 
            this.rbtSkills.AutoSize = true;
            this.rbtSkills.Location = new System.Drawing.Point(200, 43);
            this.rbtSkills.Name = "rbtSkills";
            this.rbtSkills.Size = new System.Drawing.Size(49, 17);
            this.rbtSkills.TabIndex = 10;
            this.rbtSkills.Text = "Skills";
            this.rbtSkills.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtMugel);
            this.gbxTipo.Controls.Add(this.rbtSkills);
            this.gbxTipo.Controls.Add(this.rbtWizird);
            this.gbxTipo.Location = new System.Drawing.Point(240, 152);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(372, 98);
            this.gbxTipo.TabIndex = 11;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(38, 298);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(72, 13);
            this.lbColor.TabIndex = 12;
            this.lbColor.Text = "Color Favorito";
            // 
            // cboColorFav
            // 
            this.cboColorFav.FormattingEnabled = true;
            this.cboColorFav.Location = new System.Drawing.Point(141, 290);
            this.cboColorFav.Name = "cboColorFav";
            this.cboColorFav.Size = new System.Drawing.Size(121, 21);
            this.cboColorFav.TabIndex = 13;
            // 
            // lbNumeroFavorito
            // 
            this.lbNumeroFavorito.AutoSize = true;
            this.lbNumeroFavorito.Location = new System.Drawing.Point(38, 258);
            this.lbNumeroFavorito.Name = "lbNumeroFavorito";
            this.lbNumeroFavorito.Size = new System.Drawing.Size(85, 13);
            this.lbNumeroFavorito.TabIndex = 14;
            this.lbNumeroFavorito.Text = "Numero Favorito";
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Location = new System.Drawing.Point(141, 256);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(121, 20);
            this.numNumeroFavorito.TabIndex = 15;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(666, 359);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 16;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.lbNumeroFavorito);
            this.Controls.Add(this.cboColorFav);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbFechaNac);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbtWizird;
        private System.Windows.Forms.RadioButton rbtMugel;
        private System.Windows.Forms.RadioButton rbtSkills;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cboColorFav;
        private System.Windows.Forms.Label lbNumeroFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

