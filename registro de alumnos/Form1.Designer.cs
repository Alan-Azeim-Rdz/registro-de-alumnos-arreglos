namespace registro_de_alumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterBtn = new Button();
            NombreTxt = new TextBox();
            EdadTxt = new TextBox();
            SemestreTxt = new TextBox();
            NameLabel = new Label();
            Semesterlabel = new Label();
            EdadLabel = new Label();
            StundentView = new ListView();
            ratingTxt = new TextBox();
            ratingTxt2 = new TextBox();
            PromBtn = new Button();
            ratingsLabel = new Label();
            ratingsLabel2 = new Label();
            promLabel = new Label();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // EnterBtn
            // 
            EnterBtn.Location = new Point(217, 128);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(130, 23);
            EnterBtn.TabIndex = 0;
            EnterBtn.Text = "ingresar datos";
            EnterBtn.UseVisualStyleBackColor = true;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(84, 26);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(100, 23);
            NombreTxt.TabIndex = 1;
            // 
            // EdadTxt
            // 
            EdadTxt.Location = new Point(84, 74);
            EdadTxt.Name = "EdadTxt";
            EdadTxt.Size = new Size(100, 23);
            EdadTxt.TabIndex = 2;
            // 
            // SemestreTxt
            // 
            SemestreTxt.Location = new Point(85, 128);
            SemestreTxt.Name = "SemestreTxt";
            SemestreTxt.Size = new Size(100, 23);
            SemestreTxt.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(24, 29);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(51, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Nombre";
            // 
            // Semesterlabel
            // 
            Semesterlabel.AutoSize = true;
            Semesterlabel.Location = new Point(24, 136);
            Semesterlabel.Name = "Semesterlabel";
            Semesterlabel.Size = new Size(55, 15);
            Semesterlabel.TabIndex = 5;
            Semesterlabel.Text = "Semestre";
            // 
            // EdadLabel
            // 
            EdadLabel.AutoSize = true;
            EdadLabel.Location = new Point(24, 82);
            EdadLabel.Name = "EdadLabel";
            EdadLabel.Size = new Size(33, 15);
            EdadLabel.TabIndex = 6;
            EdadLabel.Text = "Edad";
            // 
            // StundentView
            // 
            StundentView.Location = new Point(367, 12);
            StundentView.Name = "StundentView";
            StundentView.Size = new Size(603, 212);
            StundentView.TabIndex = 9;
            StundentView.UseCompatibleStateImageBehavior = false;
            StundentView.View = View.List;
            StundentView.SelectedIndexChanged += StundentView_SelectedIndexChanged;
            // 
            // ratingTxt
            // 
            ratingTxt.Location = new Point(84, 262);
            ratingTxt.Name = "ratingTxt";
            ratingTxt.Size = new Size(100, 23);
            ratingTxt.TabIndex = 10;
            // 
            // ratingTxt2
            // 
            ratingTxt2.Location = new Point(85, 326);
            ratingTxt2.Name = "ratingTxt2";
            ratingTxt2.Size = new Size(100, 23);
            ratingTxt2.TabIndex = 11;
            // 
            // PromBtn
            // 
            PromBtn.Location = new Point(217, 325);
            PromBtn.Name = "PromBtn";
            PromBtn.Size = new Size(130, 23);
            PromBtn.TabIndex = 12;
            PromBtn.Text = "ingresar datos";
            PromBtn.UseVisualStyleBackColor = true;
            PromBtn.Click += button1_Click;
            // 
            // ratingsLabel
            // 
            ratingsLabel.AutoSize = true;
            ratingsLabel.Location = new Point(4, 270);
            ratingsLabel.Name = "ratingsLabel";
            ratingsLabel.Size = new Size(69, 15);
            ratingsLabel.TabIndex = 13;
            ratingsLabel.Text = "Calificaion1";
            // 
            // ratingsLabel2
            // 
            ratingsLabel2.AutoSize = true;
            ratingsLabel2.Location = new Point(4, 333);
            ratingsLabel2.Name = "ratingsLabel2";
            ratingsLabel2.Size = new Size(75, 15);
            ratingsLabel2.TabIndex = 14;
            ratingsLabel2.Text = "Calificacion2";
            // 
            // promLabel
            // 
            promLabel.Location = new Point(448, 301);
            promLabel.Name = "promLabel";
            promLabel.Size = new Size(157, 47);
            promLabel.TabIndex = 15;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(199, 417);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(169, 23);
            ClearBtn.TabIndex = 16;
            ClearBtn.Text = "Borra las calificaciones";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 524);
            Controls.Add(ClearBtn);
            Controls.Add(promLabel);
            Controls.Add(ratingsLabel2);
            Controls.Add(ratingsLabel);
            Controls.Add(PromBtn);
            Controls.Add(ratingTxt2);
            Controls.Add(ratingTxt);
            Controls.Add(StundentView);
            Controls.Add(EdadLabel);
            Controls.Add(Semesterlabel);
            Controls.Add(NameLabel);
            Controls.Add(SemestreTxt);
            Controls.Add(EdadTxt);
            Controls.Add(NombreTxt);
            Controls.Add(EnterBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterBtn;
        private TextBox NombreTxt;
        private TextBox EdadTxt;
        private TextBox SemestreTxt;
        private Label NameLabel;
        private Label Semesterlabel;
        private Label EdadLabel;
        private ListView StundentView;
        private TextBox ratingTxt;
        private TextBox ratingTxt2;
        private Button PromBtn;
        private Label ratingsLabel;
        private Label ratingsLabel2;
        private Label promLabel;
        private Button ClearBtn;
    }
}
