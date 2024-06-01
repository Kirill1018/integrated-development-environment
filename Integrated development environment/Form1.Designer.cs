namespace Integrated_development_environment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saving = new Button();
            opening = new Button();
            label1 = new Label();
            search = new TextBox();
            seek = new Button();
            codeSpace = new RichTextBox();
            conservation = new Button();
            rollBack = new Button();
            rollForw = new Button();
            projMak = new Button();
            SuspendLayout();
            // 
            // saving
            // 
            saving.Location = new Point(1, 1);
            saving.Name = "saving";
            saving.Size = new Size(75, 23);
            saving.TabIndex = 0;
            saving.Text = "сохранить";
            saving.UseVisualStyleBackColor = true;
            saving.Click += saving_Click;
            // 
            // opening
            // 
            opening.Location = new Point(82, 1);
            opening.Name = "opening";
            opening.Size = new Size(75, 23);
            opening.TabIndex = 1;
            opening.Text = "открыть";
            opening.UseVisualStyleBackColor = true;
            opening.Click += opening_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 5);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 2;
            label1.Text = "поиск ключевых слов";
            // 
            // search
            // 
            search.Location = new Point(298, 1);
            search.Name = "search";
            search.Size = new Size(100, 23);
            search.TabIndex = 3;
            // 
            // seek
            // 
            seek.Location = new Point(404, 1);
            seek.Name = "seek";
            seek.Size = new Size(75, 23);
            seek.TabIndex = 4;
            seek.Text = "найти";
            seek.UseVisualStyleBackColor = true;
            seek.Click += seek_Click;
            // 
            // codeSpace
            // 
            codeSpace.AcceptsTab = true;
            codeSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codeSpace.AutoWordSelection = true;
            codeSpace.Location = new Point(12, 30);
            codeSpace.Name = "codeSpace";
            codeSpace.Size = new Size(776, 408);
            codeSpace.TabIndex = 5;
            codeSpace.Text = "";
            codeSpace.TextChanged += codeSpace_TextChanged;
            codeSpace.KeyDown += codeSpace_KeyDown;
            // 
            // conservation
            // 
            conservation.Image = (Image)resources.GetObject("conservation.Image");
            conservation.Location = new Point(485, 1);
            conservation.Name = "conservation";
            conservation.Size = new Size(24, 23);
            conservation.TabIndex = 6;
            conservation.UseVisualStyleBackColor = true;
            conservation.Click += conservation_Click;
            // 
            // rollBack
            // 
            rollBack.Image = (Image)resources.GetObject("rollBack.Image");
            rollBack.Location = new Point(515, 1);
            rollBack.Name = "rollBack";
            rollBack.Size = new Size(24, 23);
            rollBack.TabIndex = 7;
            rollBack.UseVisualStyleBackColor = true;
            rollBack.Click += rollBack_Click;
            // 
            // rollForw
            // 
            rollForw.Image = (Image)resources.GetObject("rollForw.Image");
            rollForw.Location = new Point(545, 1);
            rollForw.Name = "rollForw";
            rollForw.Size = new Size(24, 23);
            rollForw.TabIndex = 8;
            rollForw.UseVisualStyleBackColor = true;
            rollForw.Click += rollForw_Click;
            // 
            // projMak
            // 
            projMak.Image = (Image)resources.GetObject("projMak.Image");
            projMak.Location = new Point(575, 1);
            projMak.Name = "projMak";
            projMak.Size = new Size(24, 23);
            projMak.TabIndex = 9;
            projMak.UseVisualStyleBackColor = true;
            projMak.Click += projMak_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projMak);
            Controls.Add(rollForw);
            Controls.Add(rollBack);
            Controls.Add(conservation);
            Controls.Add(codeSpace);
            Controls.Add(seek);
            Controls.Add(search);
            Controls.Add(label1);
            Controls.Add(opening);
            Controls.Add(saving);
            Name = "Form1";
            Text = "integrated development environment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saving;
        private Button opening;
        private Label label1;
        private TextBox search;
        private Button seek;
        private RichTextBox codeSpace;
        private Button conservation;
        private Button rollBack;
        private Button rollForw;
        private Button projMak;
    }
}
