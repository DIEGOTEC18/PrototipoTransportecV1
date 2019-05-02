namespace PrototipoTransportecV1
{
    partial class Form6
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label iDreporteLabel;
            System.Windows.Forms.Label iDcomentarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eFDataSet = new PrototipoTransportecV1.EFDataSet();
            this.tabla_comentariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabla_comentariosTableAdapter = new PrototipoTransportecV1.EFDataSetTableAdapters.Tabla_comentariosTableAdapter();
            this.tableAdapterManager = new PrototipoTransportecV1.EFDataSetTableAdapters.TableAdapterManager();
            this.tabla_comentariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabla_comentariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usuarioLabel1 = new System.Windows.Forms.Label();
            this.textoLabel1 = new System.Windows.Forms.Label();
            this.fechaLabel1 = new System.Windows.Forms.Label();
            this.horaLabel1 = new System.Windows.Forms.Label();
            this.iDreporteLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iDcomentarioLabel1 = new System.Windows.Forms.Label();
            this.searchComentarioToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDreporteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDreporteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchComentarioToolStripButton = new System.Windows.Forms.ToolStripButton();
            usuarioLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            iDreporteLabel = new System.Windows.Forms.Label();
            iDcomentarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_comentariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_comentariosBindingNavigator)).BeginInit();
            this.tabla_comentariosBindingNavigator.SuspendLayout();
            this.searchComentarioToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(15, 199);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(63, 16);
            usuarioLabel.TabIndex = 43;
            usuarioLabel.Text = "usuario:";
            usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(15, 332);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(50, 16);
            fechaLabel.TabIndex = 47;
            fechaLabel.Text = "fecha:";
            // 
            // iDreporteLabel
            // 
            iDreporteLabel.AutoSize = true;
            iDreporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDreporteLabel.Location = new System.Drawing.Point(332, 410);
            iDreporteLabel.Name = "iDreporteLabel";
            iDreporteLabel.Size = new System.Drawing.Size(77, 16);
            iDreporteLabel.TabIndex = 51;
            iDreporteLabel.Text = "IDreporte:";
            iDreporteLabel.Visible = false;
            // 
            // iDcomentarioLabel
            // 
            iDcomentarioLabel.AutoSize = true;
            iDcomentarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDcomentarioLabel.Location = new System.Drawing.Point(45, 417);
            iDcomentarioLabel.Name = "iDcomentarioLabel";
            iDcomentarioLabel.Size = new System.Drawing.Size(104, 16);
            iDcomentarioLabel.TabIndex = 41;
            iDcomentarioLabel.Text = "IDcomentario:";
            iDcomentarioLabel.Visible = false;
            iDcomentarioLabel.Click += new System.EventHandler(this.iDcomentarioLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(127, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(175, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 39;
            this.button1.Text = "Comentar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eFDataSet
            // 
            this.eFDataSet.DataSetName = "EFDataSet";
            this.eFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla_comentariosBindingSource
            // 
            this.tabla_comentariosBindingSource.DataMember = "Tabla_comentarios";
            this.tabla_comentariosBindingSource.DataSource = this.eFDataSet;
            // 
            // tabla_comentariosTableAdapter
            // 
            this.tabla_comentariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tabla_alumnosTableAdapter = null;
            this.tableAdapterManager.Tabla_asistenciasTableAdapter = null;
            this.tableAdapterManager.Tabla_comentariosTableAdapter = this.tabla_comentariosTableAdapter;
            this.tableAdapterManager.Tabla_reporteTableAdapter = null;
            this.tableAdapterManager.Tabla_rutasTableAdapter = null;
            this.tableAdapterManager.Tabla_usuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrototipoTransportecV1.EFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabla_comentariosBindingNavigator
            // 
            this.tabla_comentariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabla_comentariosBindingNavigator.BindingSource = this.tabla_comentariosBindingSource;
            this.tabla_comentariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabla_comentariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabla_comentariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tabla_comentariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabla_comentariosBindingNavigatorSaveItem});
            this.tabla_comentariosBindingNavigator.Location = new System.Drawing.Point(18, 163);
            this.tabla_comentariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabla_comentariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabla_comentariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabla_comentariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabla_comentariosBindingNavigator.Name = "tabla_comentariosBindingNavigator";
            this.tabla_comentariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabla_comentariosBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tabla_comentariosBindingNavigator.TabIndex = 41;
            this.tabla_comentariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabla_comentariosBindingNavigatorSaveItem
            // 
            this.tabla_comentariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabla_comentariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabla_comentariosBindingNavigatorSaveItem.Image")));
            this.tabla_comentariosBindingNavigatorSaveItem.Name = "tabla_comentariosBindingNavigatorSaveItem";
            this.tabla_comentariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabla_comentariosBindingNavigatorSaveItem.Text = "Save Data";
            this.tabla_comentariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabla_comentariosBindingNavigatorSaveItem_Click);
            // 
            // usuarioLabel1
            // 
            this.usuarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "usuario", true));
            this.usuarioLabel1.Location = new System.Drawing.Point(84, 201);
            this.usuarioLabel1.Name = "usuarioLabel1";
            this.usuarioLabel1.Size = new System.Drawing.Size(100, 23);
            this.usuarioLabel1.TabIndex = 44;
            this.usuarioLabel1.Text = "label1";
            // 
            // textoLabel1
            // 
            this.textoLabel1.BackColor = System.Drawing.Color.White;
            this.textoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "texto", true));
            this.textoLabel1.Location = new System.Drawing.Point(70, 236);
            this.textoLabel1.Name = "textoLabel1";
            this.textoLabel1.Size = new System.Drawing.Size(383, 85);
            this.textoLabel1.TabIndex = 46;
            this.textoLabel1.Text = "label1";
            this.textoLabel1.Click += new System.EventHandler(this.textoLabel1_Click);
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "fecha", true));
            this.fechaLabel1.Location = new System.Drawing.Point(71, 334);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(100, 23);
            this.fechaLabel1.TabIndex = 48;
            this.fechaLabel1.Text = "label1";
            // 
            // horaLabel1
            // 
            this.horaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "hora", true));
            this.horaLabel1.Location = new System.Drawing.Point(353, 325);
            this.horaLabel1.Name = "horaLabel1";
            this.horaLabel1.Size = new System.Drawing.Size(100, 23);
            this.horaLabel1.TabIndex = 50;
            this.horaLabel1.Text = "label1";
            this.horaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iDreporteLabel1
            // 
            this.iDreporteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "IDreporte", true));
            this.iDreporteLabel1.Location = new System.Drawing.Point(411, 410);
            this.iDreporteLabel1.Name = "iDreporteLabel1";
            this.iDreporteLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDreporteLabel1.TabIndex = 52;
            this.iDreporteLabel1.Text = "label1";
            this.iDreporteLabel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(15, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(499, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // iDcomentarioLabel1
            // 
            this.iDcomentarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_comentariosBindingSource, "IDcomentario", true));
            this.iDcomentarioLabel1.Location = new System.Drawing.Point(141, 417);
            this.iDcomentarioLabel1.Name = "iDcomentarioLabel1";
            this.iDcomentarioLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDcomentarioLabel1.TabIndex = 42;
            this.iDcomentarioLabel1.Text = "label1";
            this.iDcomentarioLabel1.Visible = false;
            // 
            // searchComentarioToolStrip
            // 
            this.searchComentarioToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDreporteToolStripLabel,
            this.iDreporteToolStripTextBox,
            this.searchComentarioToolStripButton});
            this.searchComentarioToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchComentarioToolStrip.Name = "searchComentarioToolStrip";
            this.searchComentarioToolStrip.Size = new System.Drawing.Size(534, 25);
            this.searchComentarioToolStrip.TabIndex = 54;
            this.searchComentarioToolStrip.Text = "searchComentarioToolStrip";
            this.searchComentarioToolStrip.Visible = false;
            // 
            // iDreporteToolStripLabel
            // 
            this.iDreporteToolStripLabel.Name = "iDreporteToolStripLabel";
            this.iDreporteToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.iDreporteToolStripLabel.Text = "IDreporte:";
            // 
            // iDreporteToolStripTextBox
            // 
            this.iDreporteToolStripTextBox.Name = "iDreporteToolStripTextBox";
            this.iDreporteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchComentarioToolStripButton
            // 
            this.searchComentarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchComentarioToolStripButton.Name = "searchComentarioToolStripButton";
            this.searchComentarioToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.searchComentarioToolStripButton.Text = "SearchComentario";
            this.searchComentarioToolStripButton.Click += new System.EventHandler(this.searchComentarioToolStripButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 460);
            this.Controls.Add(this.searchComentarioToolStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(iDcomentarioLabel);
            this.Controls.Add(this.iDcomentarioLabel1);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioLabel1);
            this.Controls.Add(this.textoLabel1);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaLabel1);
            this.Controls.Add(this.horaLabel1);
            this.Controls.Add(iDreporteLabel);
            this.Controls.Add(this.iDreporteLabel1);
            this.Controls.Add(this.tabla_comentariosBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "Comentarios";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_comentariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_comentariosBindingNavigator)).EndInit();
            this.tabla_comentariosBindingNavigator.ResumeLayout(false);
            this.tabla_comentariosBindingNavigator.PerformLayout();
            this.searchComentarioToolStrip.ResumeLayout(false);
            this.searchComentarioToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private EFDataSet eFDataSet;
        private System.Windows.Forms.BindingSource tabla_comentariosBindingSource;
        private EFDataSetTableAdapters.Tabla_comentariosTableAdapter tabla_comentariosTableAdapter;
        private EFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabla_comentariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabla_comentariosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label usuarioLabel1;
        private System.Windows.Forms.Label textoLabel1;
        private System.Windows.Forms.Label fechaLabel1;
        private System.Windows.Forms.Label horaLabel1;
        private System.Windows.Forms.Label iDreporteLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label iDcomentarioLabel1;
        private System.Windows.Forms.ToolStrip searchComentarioToolStrip;
        private System.Windows.Forms.ToolStripLabel iDreporteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDreporteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchComentarioToolStripButton;
    }
}