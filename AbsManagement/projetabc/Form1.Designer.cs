
namespace projetabc
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.buttDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.butFormateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.butSecrétaire = new Guna.UI.WinForms.GunaAdvenceButton();
            this.butApprenants = new Guna.UI.WinForms.GunaAdvenceButton();
            this.butParamètres = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panDatabase = new Guna.UI.WinForms.GunaPanel();
            this.Panserch = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.Panserch);
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(1, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1327, 67);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.gunaPanel1.Controls.Add(this.butParamètres);
            this.gunaPanel1.Controls.Add(this.butApprenants);
            this.gunaPanel1.Controls.Add(this.butSecrétaire);
            this.gunaPanel1.Controls.Add(this.butFormateur);
            this.gunaPanel1.Controls.Add(this.buttDashboard);
            this.gunaPanel1.Location = new System.Drawing.Point(1, 73);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(218, 672);
            this.gunaPanel1.TabIndex = 1;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // buttDashboard
            // 
            this.buttDashboard.AnimationHoverSpeed = 0.07F;
            this.buttDashboard.AnimationSpeed = 0.03F;
            this.buttDashboard.BackColor = System.Drawing.SystemColors.Menu;
            this.buttDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.buttDashboard.BorderColor = System.Drawing.SystemColors.Menu;
            this.buttDashboard.CausesValidation = false;
            this.buttDashboard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttDashboard.CheckedBorderColor = System.Drawing.Color.Gray;
            this.buttDashboard.CheckedForeColor = System.Drawing.Color.Gray;
            this.buttDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("buttDashboard.CheckedImage")));
            this.buttDashboard.CheckedLineColor = System.Drawing.Color.Gray;
            this.buttDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.buttDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttDashboard.Image")));
            this.buttDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.buttDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttDashboard.Location = new System.Drawing.Point(16, 142);
            this.buttDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.buttDashboard.Name = "buttDashboard";
            this.buttDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.buttDashboard.OnHoverImage = null;
            this.buttDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttDashboard.OnPressedColor = System.Drawing.Color.Empty;
            this.buttDashboard.Size = new System.Drawing.Size(197, 48);
            this.buttDashboard.TabIndex = 2;
            this.buttDashboard.Text = "Dashboard";
            this.buttDashboard.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.buttDashboard.Click += new System.EventHandler(this.buttDashboard_Click);
            // 
            // butFormateur
            // 
            this.butFormateur.AnimationHoverSpeed = 0.07F;
            this.butFormateur.AnimationSpeed = 0.03F;
            this.butFormateur.BackColor = System.Drawing.SystemColors.Menu;
            this.butFormateur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.butFormateur.BorderColor = System.Drawing.SystemColors.Menu;
            this.butFormateur.CausesValidation = false;
            this.butFormateur.CheckedBaseColor = System.Drawing.Color.Gray;
            this.butFormateur.CheckedBorderColor = System.Drawing.Color.Gray;
            this.butFormateur.CheckedForeColor = System.Drawing.Color.Gray;
            this.butFormateur.CheckedImage = ((System.Drawing.Image)(resources.GetObject("butFormateur.CheckedImage")));
            this.butFormateur.CheckedLineColor = System.Drawing.Color.Gray;
            this.butFormateur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butFormateur.FocusedColor = System.Drawing.Color.Empty;
            this.butFormateur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFormateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butFormateur.Image = ((System.Drawing.Image)(resources.GetObject("butFormateur.Image")));
            this.butFormateur.ImageSize = new System.Drawing.Size(35, 35);
            this.butFormateur.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butFormateur.Location = new System.Drawing.Point(14, 213);
            this.butFormateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.butFormateur.Name = "butFormateur";
            this.butFormateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butFormateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butFormateur.OnHoverForeColor = System.Drawing.Color.White;
            this.butFormateur.OnHoverImage = null;
            this.butFormateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butFormateur.OnPressedColor = System.Drawing.Color.Empty;
            this.butFormateur.Size = new System.Drawing.Size(197, 48);
            this.butFormateur.TabIndex = 3;
            this.butFormateur.Text = "Formateur";
            this.butFormateur.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.butFormateur.Click += new System.EventHandler(this.butFormateur_Click);
            // 
            // butSecrétaire
            // 
            this.butSecrétaire.AnimationHoverSpeed = 0.07F;
            this.butSecrétaire.AnimationSpeed = 0.03F;
            this.butSecrétaire.BackColor = System.Drawing.SystemColors.Menu;
            this.butSecrétaire.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.butSecrétaire.BorderColor = System.Drawing.SystemColors.Menu;
            this.butSecrétaire.CausesValidation = false;
            this.butSecrétaire.CheckedBaseColor = System.Drawing.Color.Gray;
            this.butSecrétaire.CheckedBorderColor = System.Drawing.Color.Gray;
            this.butSecrétaire.CheckedForeColor = System.Drawing.Color.Gray;
            this.butSecrétaire.CheckedImage = ((System.Drawing.Image)(resources.GetObject("butSecrétaire.CheckedImage")));
            this.butSecrétaire.CheckedLineColor = System.Drawing.Color.Gray;
            this.butSecrétaire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butSecrétaire.FocusedColor = System.Drawing.Color.Empty;
            this.butSecrétaire.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSecrétaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butSecrétaire.Image = ((System.Drawing.Image)(resources.GetObject("butSecrétaire.Image")));
            this.butSecrétaire.ImageSize = new System.Drawing.Size(35, 35);
            this.butSecrétaire.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butSecrétaire.Location = new System.Drawing.Point(14, 291);
            this.butSecrétaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.butSecrétaire.Name = "butSecrétaire";
            this.butSecrétaire.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butSecrétaire.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butSecrétaire.OnHoverForeColor = System.Drawing.Color.White;
            this.butSecrétaire.OnHoverImage = null;
            this.butSecrétaire.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butSecrétaire.OnPressedColor = System.Drawing.Color.Empty;
            this.butSecrétaire.Size = new System.Drawing.Size(197, 48);
            this.butSecrétaire.TabIndex = 4;
            this.butSecrétaire.Text = "Secrétaire";
            this.butSecrétaire.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.butSecrétaire.Click += new System.EventHandler(this.butSecrétaire_Click);
            // 
            // butApprenants
            // 
            this.butApprenants.AnimationHoverSpeed = 0.07F;
            this.butApprenants.AnimationSpeed = 0.03F;
            this.butApprenants.BackColor = System.Drawing.SystemColors.Menu;
            this.butApprenants.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.butApprenants.BorderColor = System.Drawing.SystemColors.Menu;
            this.butApprenants.CausesValidation = false;
            this.butApprenants.CheckedBaseColor = System.Drawing.Color.Gray;
            this.butApprenants.CheckedBorderColor = System.Drawing.Color.Gray;
            this.butApprenants.CheckedForeColor = System.Drawing.Color.Gray;
            this.butApprenants.CheckedImage = ((System.Drawing.Image)(resources.GetObject("butApprenants.CheckedImage")));
            this.butApprenants.CheckedLineColor = System.Drawing.Color.Gray;
            this.butApprenants.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butApprenants.FocusedColor = System.Drawing.Color.Empty;
            this.butApprenants.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApprenants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butApprenants.Image = ((System.Drawing.Image)(resources.GetObject("butApprenants.Image")));
            this.butApprenants.ImageSize = new System.Drawing.Size(35, 35);
            this.butApprenants.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butApprenants.Location = new System.Drawing.Point(14, 361);
            this.butApprenants.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.butApprenants.Name = "butApprenants";
            this.butApprenants.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butApprenants.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butApprenants.OnHoverForeColor = System.Drawing.Color.White;
            this.butApprenants.OnHoverImage = null;
            this.butApprenants.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butApprenants.OnPressedColor = System.Drawing.Color.Empty;
            this.butApprenants.Size = new System.Drawing.Size(197, 48);
            this.butApprenants.TabIndex = 5;
            this.butApprenants.Text = "Apprenants";
            this.butApprenants.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.butApprenants.Click += new System.EventHandler(this.butApprenants_Click);
            // 
            // butParamètres
            // 
            this.butParamètres.AnimationHoverSpeed = 0.07F;
            this.butParamètres.AnimationSpeed = 0.03F;
            this.butParamètres.BackColor = System.Drawing.SystemColors.Menu;
            this.butParamètres.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.butParamètres.BorderColor = System.Drawing.SystemColors.Menu;
            this.butParamètres.CausesValidation = false;
            this.butParamètres.CheckedBaseColor = System.Drawing.Color.Gray;
            this.butParamètres.CheckedBorderColor = System.Drawing.Color.Gray;
            this.butParamètres.CheckedForeColor = System.Drawing.Color.Gray;
            this.butParamètres.CheckedImage = ((System.Drawing.Image)(resources.GetObject("butParamètres.CheckedImage")));
            this.butParamètres.CheckedLineColor = System.Drawing.Color.Gray;
            this.butParamètres.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butParamètres.FocusedColor = System.Drawing.Color.Empty;
            this.butParamètres.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParamètres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.butParamètres.Image = ((System.Drawing.Image)(resources.GetObject("butParamètres.Image")));
            this.butParamètres.ImageSize = new System.Drawing.Size(35, 35);
            this.butParamètres.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butParamètres.Location = new System.Drawing.Point(16, 426);
            this.butParamètres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.butParamètres.Name = "butParamètres";
            this.butParamètres.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butParamètres.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butParamètres.OnHoverForeColor = System.Drawing.Color.White;
            this.butParamètres.OnHoverImage = null;
            this.butParamètres.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.butParamètres.OnPressedColor = System.Drawing.Color.Empty;
            this.butParamètres.Size = new System.Drawing.Size(197, 48);
            this.butParamètres.TabIndex = 6;
            this.butParamètres.Text = "Paramètres";
            this.butParamètres.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.butParamètres.Click += new System.EventHandler(this.butParamètres_Click);
            // 
            // panDatabase
            // 
            this.panDatabase.Location = new System.Drawing.Point(1066, 304);
            this.panDatabase.Name = "panDatabase";
            this.panDatabase.Size = new System.Drawing.Size(200, 200);
            this.panDatabase.TabIndex = 2;
            // 
            // Panserch
            // 
            this.Panserch.BackColor = System.Drawing.Color.Transparent;
            this.Panserch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.Panserch.Location = new System.Drawing.Point(312, 12);
            this.Panserch.Name = "Panserch";
            this.Panserch.Radius = 10;
            this.Panserch.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(191)))));
            this.Panserch.ShadowDepth = 90;
            this.Panserch.Size = new System.Drawing.Size(242, 46);
            this.Panserch.TabIndex = 3;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1329, 747);
            this.Controls.Add(this.panDatabase);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "Form1";
            this.Text = "   Search                     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton buttDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton butFormateur;
        private Guna.UI.WinForms.GunaAdvenceButton butParamètres;
        private Guna.UI.WinForms.GunaAdvenceButton butApprenants;
        private Guna.UI.WinForms.GunaAdvenceButton butSecrétaire;
        private Guna.UI.WinForms.GunaPanel panDatabase;
        private Guna.UI.WinForms.GunaShadowPanel Panserch;
    }
}

