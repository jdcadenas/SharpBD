namespace ejemploBd
{
	partial class GestionModulos
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvModulos;
    private System.Windows.Forms.TextBox txtNombreEs;
    private System.Windows.Forms.TextBox txtNombreEn;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnverpreguntas;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
    	this.dgvModulos = new System.Windows.Forms.DataGridView();
    	this.txtNombreEs = new System.Windows.Forms.TextBox();
    	this.txtNombreEn = new System.Windows.Forms.TextBox();
    	this.btnGuardar = new System.Windows.Forms.Button();
    	this.label1 = new System.Windows.Forms.Label();
    	this.label2 = new System.Windows.Forms.Label();
    	this.btnverpreguntas = new System.Windows.Forms.Button();
    	((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
    	this.SuspendLayout();
    	// 
    	// dgvModulos
    	// 
    	this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    	this.dgvModulos.Location = new System.Drawing.Point(12, 12);
    	this.dgvModulos.Name = "dgvModulos";
    	this.dgvModulos.Size = new System.Drawing.Size(360, 150);
    	this.dgvModulos.TabIndex = 0;
    	// 
    	// txtNombreEs
    	// 
    	this.txtNombreEs.Location = new System.Drawing.Point(118, 183);
    	this.txtNombreEs.Name = "txtNombreEs";
    	this.txtNombreEs.Size = new System.Drawing.Size(100, 20);
    	this.txtNombreEs.TabIndex = 8;
    	// 
    	// txtNombreEn
    	// 
    	this.txtNombreEn.Location = new System.Drawing.Point(118, 210);
    	this.txtNombreEn.Name = "txtNombreEn";
    	this.txtNombreEn.Size = new System.Drawing.Size(100, 20);
    	this.txtNombreEn.TabIndex = 7;
    	// 
    	// btnGuardar
    	// 
    	this.btnGuardar.Location = new System.Drawing.Point(297, 240);
    	this.btnGuardar.Name = "btnGuardar";
    	this.btnGuardar.Size = new System.Drawing.Size(75, 23);
    	this.btnGuardar.TabIndex = 3;
    	this.btnGuardar.Text = "Guardar";
    	this.btnGuardar.UseVisualStyleBackColor = true;
    	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
    	// 
    	// label1
    	// 
    	this.label1.Location = new System.Drawing.Point(12, 183);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(100, 23);
    	this.label1.TabIndex = 6;
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(12, 213);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(100, 23);
    	this.label2.TabIndex = 5;
    	// 
    	// btnverpreguntas
    	// 
    	this.btnverpreguntas.Location = new System.Drawing.Point(188, 240);
    	this.btnverpreguntas.Name = "btnverpreguntas";
    	this.btnverpreguntas.Size = new System.Drawing.Size(75, 23);
    	this.btnverpreguntas.TabIndex = 4;
    	this.btnverpreguntas.Text = "Ver Pregunta";
    	this.btnverpreguntas.UseVisualStyleBackColor = true;
    	// 
    	// GestionModulos
    	// 
    	this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
    	this.ClientSize = new System.Drawing.Size(384, 281);
    	this.Controls.Add(this.btnverpreguntas);
    	this.Controls.Add(this.label2);
    	this.Controls.Add(this.label1);
    	this.Controls.Add(this.btnGuardar);
    	this.Controls.Add(this.txtNombreEn);
    	this.Controls.Add(this.txtNombreEs);
    	this.Controls.Add(this.dgvModulos);
    	this.Name = "GestionModulos";
    	this.Text = "Gestión de Módulos Bilingües";
    	((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
	}}