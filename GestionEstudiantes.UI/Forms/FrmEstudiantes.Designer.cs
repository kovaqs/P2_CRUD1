namespace GestionEstudiantes.UI.Forms
{
    partial class FrmEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbEstadoFiltro = new MaterialSkin.Controls.MaterialComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtNivel = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCarnet = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mExpansionPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(8, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 778);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.materialLabel2.Size = new System.Drawing.Size(210, 14);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Administra los estudiantes registrados";
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
            this.materialLabel1.Size = new System.Drawing.Size(180, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Estudiantes";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.mExpansionPanel1);
            this.panel2.Location = new System.Drawing.Point(36, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 622);
            this.panel2.TabIndex = 5;
            // 
            // mExpansionPanel1
            // 
            this.mExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mExpansionPanel1.CancelButtonText = "CANCELAR";
            this.mExpansionPanel1.Collapse = true;
            this.mExpansionPanel1.Controls.Add(this.txtNivel);
            this.mExpansionPanel1.Controls.Add(this.materialLabel3);
            this.mExpansionPanel1.Controls.Add(this.cbEstado);
            this.mExpansionPanel1.Controls.Add(this.dtFecha);
            this.mExpansionPanel1.Controls.Add(this.txtCorreo);
            this.mExpansionPanel1.Controls.Add(this.txtCarnet);
            this.mExpansionPanel1.Controls.Add(this.txtApellidos);
            this.mExpansionPanel1.Controls.Add(this.txtNombre);
            this.mExpansionPanel1.Depth = 0;
            this.mExpansionPanel1.Description = "Actualice o cambie los datos del estudiante";
            this.mExpansionPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mExpansionPanel1.ExpandHeight = 236;
            this.mExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mExpansionPanel1.Location = new System.Drawing.Point(0, 0);
            this.mExpansionPanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mExpansionPanel1.Name = "mExpansionPanel1";
            this.mExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mExpansionPanel1.Size = new System.Drawing.Size(782, 48);
            this.mExpansionPanel1.TabIndex = 112;
            this.mExpansionPanel1.Title = "Editar";
            this.mExpansionPanel1.ValidationButtonText = "Guardar";
            this.mExpansionPanel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.materialCard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 574);
            this.panel3.TabIndex = 113;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvEstudiantes);
            this.materialCard1.Controls.Add(this.panel4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(754, 546);
            this.materialCard1.TabIndex = 114;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AnimateReadOnly = false;
            this.txtBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBusqueda.HideSelection = true;
            this.txtBusqueda.Hint = "Buscar por Nombre, carnet...";
            this.txtBusqueda.LeadingIcon = null;
            this.txtBusqueda.Location = new System.Drawing.Point(14, 7);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PrefixSuffixText = null;
            this.txtBusqueda.ReadOnly = false;
            this.txtBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.ShortcutsEnabled = true;
            this.txtBusqueda.Size = new System.Drawing.Size(245, 36);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusqueda.TrailingIcon = null;
            this.txtBusqueda.UseAccent = false;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.UseTallSize = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cbEstadoFiltro
            // 
            this.cbEstadoFiltro.AutoResize = true;
            this.cbEstadoFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstadoFiltro.Depth = 0;
            this.cbEstadoFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstadoFiltro.DropDownHeight = 118;
            this.cbEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoFiltro.DropDownWidth = 121;
            this.cbEstadoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstadoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstadoFiltro.FormattingEnabled = true;
            this.cbEstadoFiltro.Hint = "Estado";
            this.cbEstadoFiltro.IntegralHeight = false;
            this.cbEstadoFiltro.ItemHeight = 29;
            this.cbEstadoFiltro.Location = new System.Drawing.Point(285, 7);
            this.cbEstadoFiltro.MaxDropDownItems = 4;
            this.cbEstadoFiltro.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstadoFiltro.Name = "cbEstadoFiltro";
            this.cbEstadoFiltro.Size = new System.Drawing.Size(121, 35);
            this.cbEstadoFiltro.StartIndex = 0;
            this.cbEstadoFiltro.TabIndex = 8;
            this.cbEstadoFiltro.UseAccent = false;
            this.cbEstadoFiltro.UseTallSize = false;
            this.cbEstadoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbEstadoFiltro_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.materialLabel4);
            this.panel4.Controls.Add(this.cbEstadoFiltro);
            this.panel4.Controls.Add(this.txtBusqueda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(14, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 76);
            this.panel4.TabIndex = 63;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiantes.ColumnHeadersHeight = 40;
            this.dgvEstudiantes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;
            this.dgvEstudiantes.Location = new System.Drawing.Point(14, 90);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dgvEstudiantes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(726, 442);
            this.dgvEstudiantes.TabIndex = 64;
            this.dgvEstudiantes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstudiantes_CellMouseDown);
            // 
            // txtNivel
            // 
            this.txtNivel.AnimateReadOnly = false;
            this.txtNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNivel.Depth = 0;
            this.txtNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNivel.HideSelection = true;
            this.txtNivel.Hint = "Nivel Académico";
            this.txtNivel.LeadingIcon = null;
            this.txtNivel.Location = new System.Drawing.Point(235, 116);
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
            this.txtNivel.Size = new System.Drawing.Size(195, 36);
            this.txtNivel.TabIndex = 124;
            this.txtNivel.TabStop = false;
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNivel.TrailingIcon = null;
            this.txtNivel.UseAccent = false;
            this.txtNivel.UseSystemPasswordChar = false;
            this.txtNivel.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel3.Location = new System.Drawing.Point(20, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 13);
            this.materialLabel3.TabIndex = 123;
            this.materialLabel3.Text = "Fecha de Nacimiento";
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
            this.cbEstado.Hint = "Estado";
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.ItemHeight = 29;
            this.cbEstado.Location = new System.Drawing.Point(639, 61);
            this.cbEstado.MaxDropDownItems = 4;
            this.cbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 35);
            this.cbEstado.StartIndex = 0;
            this.cbEstado.TabIndex = 122;
            this.cbEstado.UseAccent = false;
            this.cbEstado.UseTallSize = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(23, 126);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(206, 26);
            this.dtFecha.TabIndex = 121;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(436, 61);
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
            this.txtCorreo.Size = new System.Drawing.Size(189, 36);
            this.txtCorreo.TabIndex = 120;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseAccent = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.UseTallSize = false;
            // 
            // txtCarnet
            // 
            this.txtCarnet.AnimateReadOnly = false;
            this.txtCarnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCarnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCarnet.Depth = 0;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarnet.HideSelection = true;
            this.txtCarnet.Hint = "Carnet";
            this.txtCarnet.LeadingIcon = null;
            this.txtCarnet.Location = new System.Drawing.Point(436, 116);
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
            this.txtCarnet.Size = new System.Drawing.Size(189, 36);
            this.txtCarnet.TabIndex = 119;
            this.txtCarnet.TabStop = false;
            this.txtCarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCarnet.TrailingIcon = null;
            this.txtCarnet.UseAccent = false;
            this.txtCarnet.UseSystemPasswordChar = false;
            this.txtCarnet.UseTallSize = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AnimateReadOnly = false;
            this.txtApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.HideSelection = true;
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.LeadingIcon = null;
            this.txtApellidos.Location = new System.Drawing.Point(235, 61);
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
            this.txtApellidos.Size = new System.Drawing.Size(195, 36);
            this.txtApellidos.TabIndex = 118;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellidos.TrailingIcon = null;
            this.txtApellidos.UseAccent = false;
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.UseTallSize = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(22, 61);
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
            this.txtNombre.Size = new System.Drawing.Size(207, 36);
            this.txtNombre.TabIndex = 117;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseAccent = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.UseTallSize = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.estadoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.estadoToolStripMenuItem.Text = "Activar/Reactivar Estudiante";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.activarReactivarEstudianteToolStripMenuItem_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(16, 54);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(499, 14);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Clic derecho en el estudiante para mostrar más opciones (Editar, Eliminar, Activa" +
    "r/Reactivar)";
            this.materialLabel4.UseAccent = true;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 778);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.mExpansionPanel1.ResumeLayout(false);
            this.mExpansionPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialExpansionPanel mExpansionPanel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialComboBox cbEstadoFiltro;
        private MaterialSkin.Controls.MaterialTextBox2 txtBusqueda;
        private MaterialSkin.Controls.MaterialTextBox2 txtNivel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtCarnet;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellidos;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}