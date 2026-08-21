namespace GestionEstudiantes.UI.Forms
{
    partial class FrmEstudianteEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCarnet = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNivel = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 624);
            this.panel1.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel2.Location = new System.Drawing.Point(33, 65);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(276, 14);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Registra a un nuevo estudiante en la base de datos";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(29, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(266, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nuevo Estudiante";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnRegistrar);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.txtNivel);
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.cbEstado);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.dtFecha);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txtCorreo);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.txtCarnet);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.txtApellidos);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtNombre);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(36, 104);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(819, 497);
            this.materialCard1.TabIndex = 5;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(312, 253);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(58, 17);
            this.materialLabel8.TabIndex = 101;
            this.materialLabel8.Text = "@Estado";
            this.materialLabel8.UseAccent = true;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoResize = true;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado.Depth = 0;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado.DropDownHeight = 118;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.DropDownWidth = 121;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.ItemHeight = 29;
            this.cbEstado.Location = new System.Drawing.Point(315, 274);
            this.cbEstado.MaxDropDownItems = 4;
            this.cbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 35);
            this.cbEstado.StartIndex = 0;
            this.cbEstado.TabIndex = 100;
            this.cbEstado.UseAccent = false;
            this.cbEstado.UseTallSize = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.HighEmphasis = true;
            this.materialLabel7.Location = new System.Drawing.Point(23, 253);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(149, 17);
            this.materialLabel7.TabIndex = 99;
            this.materialLabel7.Text = "@Fecha de Nacimiento";
            this.materialLabel7.UseAccent = true;
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(26, 283);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(261, 26);
            this.dtFecha.TabIndex = 98;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(312, 168);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(132, 17);
            this.materialLabel6.TabIndex = 97;
            this.materialLabel6.Text = "@Correo Electronico";
            this.materialLabel6.UseAccent = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(23, 168);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 17);
            this.materialLabel5.TabIndex = 95;
            this.materialLabel5.Text = "@Carnet";
            this.materialLabel5.UseAccent = true;
            // 
            // txtCarnet
            // 
            this.txtCarnet.AnimateReadOnly = false;
            this.txtCarnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCarnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCarnet.Depth = 0;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarnet.HideSelection = true;
            this.txtCarnet.LeadingIcon = null;
            this.txtCarnet.Location = new System.Drawing.Point(26, 190);
            this.txtCarnet.MaxLength = 32767;
            this.txtCarnet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.PasswordChar = '\0';
            this.txtCarnet.PrefixSuffixText = null;
            this.txtCarnet.ReadOnly = false;
            this.txtCarnet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarnet.SelectedText = "";
            this.txtCarnet.SelectionLength = 0;
            this.txtCarnet.SelectionStart = 0;
            this.txtCarnet.ShortcutsEnabled = true;
            this.txtCarnet.Size = new System.Drawing.Size(245, 36);
            this.txtCarnet.TabIndex = 94;
            this.txtCarnet.TabStop = false;
            this.txtCarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCarnet.TrailingIcon = null;
            this.txtCarnet.UseAccent = false;
            this.txtCarnet.UseSystemPasswordChar = false;
            this.txtCarnet.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(312, 90);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(74, 17);
            this.materialLabel4.TabIndex = 93;
            this.materialLabel4.Text = "@Apellidos";
            this.materialLabel4.UseAccent = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AnimateReadOnly = false;
            this.txtApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.HideSelection = true;
            this.txtApellidos.LeadingIcon = null;
            this.txtApellidos.Location = new System.Drawing.Point(315, 112);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PrefixSuffixText = null;
            this.txtApellidos.ReadOnly = false;
            this.txtApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(245, 36);
            this.txtApellidos.TabIndex = 92;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellidos.TrailingIcon = null;
            this.txtApellidos.UseAccent = false;
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(23, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 17);
            this.materialLabel3.TabIndex = 91;
            this.materialLabel3.Text = "@Nombre";
            this.materialLabel3.UseAccent = true;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(26, 112);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(245, 36);
            this.txtNombre.TabIndex = 90;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseAccent = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.UseTallSize = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(23, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(147, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Datos del Estudiante";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel10.Location = new System.Drawing.Point(23, 43);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(253, 13);
            this.materialLabel10.TabIndex = 102;
            this.materialLabel10.Text = "Ingrese los datos completos del estudiante correctamente";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(315, 190);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(245, 36);
            this.txtCorreo.TabIndex = 96;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseAccent = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.UseTallSize = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel11.HighEmphasis = true;
            this.materialLabel11.Location = new System.Drawing.Point(23, 336);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(121, 17);
            this.materialLabel11.TabIndex = 104;
            this.materialLabel11.Text = "@Nivel Académico";
            this.materialLabel11.UseAccent = true;
            // 
            // txtNivel
            // 
            this.txtNivel.AnimateReadOnly = false;
            this.txtNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNivel.Depth = 0;
            this.txtNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNivel.HideSelection = true;
            this.txtNivel.LeadingIcon = null;
            this.txtNivel.Location = new System.Drawing.Point(26, 358);
            this.txtNivel.MaxLength = 32767;
            this.txtNivel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.PasswordChar = '\0';
            this.txtNivel.PrefixSuffixText = null;
            this.txtNivel.ReadOnly = false;
            this.txtNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNivel.SelectedText = "";
            this.txtNivel.SelectionLength = 0;
            this.txtNivel.SelectionStart = 0;
            this.txtNivel.ShortcutsEnabled = true;
            this.txtNivel.Size = new System.Drawing.Size(245, 36);
            this.txtNivel.TabIndex = 103;
            this.txtNivel.TabStop = false;
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNivel.TrailingIcon = null;
            this.txtNivel.UseAccent = false;
            this.txtNivel.UseSystemPasswordChar = false;
            this.txtNivel.UseTallSize = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(26, 426);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrar.TabIndex = 105;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(143, 426);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 106;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEstudianteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudianteEditor";
            this.Text = "FrmEstudianteEditor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cbEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtCarnet;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellidos;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtNivel;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
    }
}