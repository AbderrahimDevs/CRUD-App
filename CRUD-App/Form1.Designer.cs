
namespace CRUD_App
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiliere = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DPNaissance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.DGVEtudiants = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CmbGroupe = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // TxtMatricule
            // 
            this.TxtMatricule.BorderRadius = 5;
            this.TxtMatricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMatricule.DefaultText = "";
            this.TxtMatricule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMatricule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMatricule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMatricule.DisabledState.Parent = this.TxtMatricule;
            this.TxtMatricule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMatricule.Enabled = false;
            this.TxtMatricule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMatricule.FocusedState.Parent = this.TxtMatricule;
            this.TxtMatricule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMatricule.HoverState.Parent = this.TxtMatricule;
            this.TxtMatricule.Location = new System.Drawing.Point(207, 37);
            this.TxtMatricule.Name = "TxtMatricule";
            this.TxtMatricule.PasswordChar = '\0';
            this.TxtMatricule.PlaceholderText = "";
            this.TxtMatricule.SelectedText = "";
            this.TxtMatricule.ShadowDecoration.Parent = this.TxtMatricule;
            this.TxtMatricule.Size = new System.Drawing.Size(240, 36);
            this.TxtMatricule.TabIndex = 1;
            // 
            // TxtNom
            // 
            this.TxtNom.BorderRadius = 5;
            this.TxtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNom.DefaultText = "";
            this.TxtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNom.DisabledState.Parent = this.TxtNom;
            this.TxtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.FocusedState.Parent = this.TxtNom;
            this.TxtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.HoverState.Parent = this.TxtNom;
            this.TxtNom.Location = new System.Drawing.Point(207, 97);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PasswordChar = '\0';
            this.TxtNom.PlaceholderText = "";
            this.TxtNom.SelectedText = "";
            this.TxtNom.ShadowDecoration.Parent = this.TxtNom;
            this.TxtNom.Size = new System.Drawing.Size(240, 36);
            this.TxtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.BorderRadius = 5;
            this.TxtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrenom.DefaultText = "";
            this.TxtPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrenom.DisabledState.Parent = this.TxtPrenom;
            this.TxtPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrenom.FocusedState.Parent = this.TxtPrenom;
            this.TxtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrenom.HoverState.Parent = this.TxtPrenom;
            this.TxtPrenom.Location = new System.Drawing.Point(207, 157);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.PasswordChar = '\0';
            this.TxtPrenom.PlaceholderText = "";
            this.TxtPrenom.SelectedText = "";
            this.TxtPrenom.ShadowDecoration.Parent = this.TxtPrenom;
            this.TxtPrenom.Size = new System.Drawing.Size(240, 36);
            this.TxtPrenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // TxtFiliere
            // 
            this.TxtFiliere.BorderRadius = 5;
            this.TxtFiliere.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFiliere.DefaultText = "";
            this.TxtFiliere.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFiliere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFiliere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiliere.DisabledState.Parent = this.TxtFiliere;
            this.TxtFiliere.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiliere.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiliere.FocusedState.Parent = this.TxtFiliere;
            this.TxtFiliere.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiliere.HoverState.Parent = this.TxtFiliere;
            this.TxtFiliere.Location = new System.Drawing.Point(544, 37);
            this.TxtFiliere.Name = "TxtFiliere";
            this.TxtFiliere.PasswordChar = '\0';
            this.TxtFiliere.PlaceholderText = "";
            this.TxtFiliere.SelectedText = "";
            this.TxtFiliere.ShadowDecoration.Parent = this.TxtFiliere;
            this.TxtFiliere.Size = new System.Drawing.Size(240, 36);
            this.TxtFiliere.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filiére";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Groupe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Groupe";
            // 
            // DPNaissance
            // 
            this.DPNaissance.BorderRadius = 5;
            this.DPNaissance.CheckedState.Parent = this.DPNaissance;
            this.DPNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DPNaissance.HoverState.Parent = this.DPNaissance;
            this.DPNaissance.Location = new System.Drawing.Point(544, 157);
            this.DPNaissance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPNaissance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPNaissance.Name = "DPNaissance";
            this.DPNaissance.ShadowDecoration.Parent = this.DPNaissance;
            this.DPNaissance.Size = new System.Drawing.Size(240, 36);
            this.DPNaissance.TabIndex = 10;
            this.DPNaissance.Value = new System.DateTime(2023, 2, 22, 18, 48, 29, 333);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BorderRadius = 5;
            this.BtnAjouter.CheckedState.Parent = this.BtnAjouter;
            this.BtnAjouter.CustomImages.Parent = this.BtnAjouter;
            this.BtnAjouter.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.HoverState.Parent = this.BtnAjouter;
            this.BtnAjouter.Location = new System.Drawing.Point(230, 231);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(144, 40);
            this.BtnAjouter.TabIndex = 11;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BorderRadius = 5;
            this.BtnModifier.CheckedState.Parent = this.BtnModifier;
            this.BtnModifier.CustomImages.Parent = this.BtnModifier;
            this.BtnModifier.FillColor = System.Drawing.Color.Orange;
            this.BtnModifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.HoverState.Parent = this.BtnModifier;
            this.BtnModifier.Location = new System.Drawing.Point(388, 231);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(144, 40);
            this.BtnModifier.TabIndex = 12;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BorderRadius = 5;
            this.BtnSupprimer.CheckedState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.CustomImages.Parent = this.BtnSupprimer;
            this.BtnSupprimer.FillColor = System.Drawing.Color.Crimson;
            this.BtnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.HoverState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Location = new System.Drawing.Point(546, 231);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(144, 40);
            this.BtnSupprimer.TabIndex = 13;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // DGVEtudiants
            // 
            this.DGVEtudiants.AllowUserToAddRows = false;
            this.DGVEtudiants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVEtudiants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEtudiants.BackgroundColor = System.Drawing.Color.White;
            this.DGVEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVEtudiants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVEtudiants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEtudiants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEtudiants.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEtudiants.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVEtudiants.EnableHeadersVisualStyles = false;
            this.DGVEtudiants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVEtudiants.Location = new System.Drawing.Point(74, 299);
            this.DGVEtudiants.Name = "DGVEtudiants";
            this.DGVEtudiants.ReadOnly = true;
            this.DGVEtudiants.RowHeadersVisible = false;
            this.DGVEtudiants.RowTemplate.Height = 30;
            this.DGVEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEtudiants.Size = new System.Drawing.Size(773, 224);
            this.DGVEtudiants.TabIndex = 14;
            this.DGVEtudiants.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVEtudiants.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVEtudiants.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVEtudiants.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVEtudiants.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVEtudiants.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVEtudiants.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVEtudiants.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVEtudiants.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVEtudiants.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVEtudiants.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVEtudiants.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVEtudiants.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVEtudiants.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVEtudiants.ThemeStyle.ReadOnly = true;
            this.DGVEtudiants.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVEtudiants.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVEtudiants.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVEtudiants.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVEtudiants.ThemeStyle.RowsStyle.Height = 30;
            this.DGVEtudiants.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVEtudiants.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVEtudiants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEtudiants_CellDoubleClick);
            // 
            // CmbGroupe
            // 
            this.CmbGroupe.BackColor = System.Drawing.Color.Transparent;
            this.CmbGroupe.BorderRadius = 5;
            this.CmbGroupe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGroupe.FocusedColor = System.Drawing.Color.Empty;
            this.CmbGroupe.FocusedState.Parent = this.CmbGroupe;
            this.CmbGroupe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbGroupe.FormattingEnabled = true;
            this.CmbGroupe.HoverState.Parent = this.CmbGroupe;
            this.CmbGroupe.ItemHeight = 30;
            this.CmbGroupe.Items.AddRange(new object[] {
            "- Choisir le Group -",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CmbGroupe.ItemsAppearance.Parent = this.CmbGroupe;
            this.CmbGroupe.Location = new System.Drawing.Point(544, 97);
            this.CmbGroupe.Name = "CmbGroupe";
            this.CmbGroupe.ShadowDecoration.Parent = this.CmbGroupe;
            this.CmbGroupe.Size = new System.Drawing.Size(240, 36);
            this.CmbGroupe.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 535);
            this.Controls.Add(this.CmbGroupe);
            this.Controls.Add(this.DGVEtudiants);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.DPNaissance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFiliere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMatricule);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEtudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtMatricule;
        private Guna.UI2.WinForms.Guna2TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrenom;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiliere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPNaissance;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2DataGridView DGVEtudiants;
        private Guna.UI2.WinForms.Guna2ComboBox CmbGroupe;
    }
}

