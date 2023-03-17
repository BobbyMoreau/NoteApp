namespace NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddItemButton = new System.Windows.Forms.Button();
            this.noteBodyLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.readItemButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.newItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddItemButton.Location = new System.Drawing.Point(188, 323);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(108, 47);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // noteBodyLabel
            // 
            this.noteBodyLabel.AutoSize = true;
            this.noteBodyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noteBodyLabel.Location = new System.Drawing.Point(53, 88);
            this.noteBodyLabel.Name = "noteBodyLabel";
            this.noteBodyLabel.Size = new System.Drawing.Size(125, 16);
            this.noteBodyLabel.TabIndex = 3;
            this.noteBodyLabel.Text = "Write your new Item;";
            this.noteBodyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(53, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 16);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(56, 53);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(206, 22);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 250);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // readItemButton
            // 
            this.readItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.readItemButton.Location = new System.Drawing.Point(395, 322);
            this.readItemButton.Name = "readItemButton";
            this.readItemButton.Size = new System.Drawing.Size(116, 46);
            this.readItemButton.TabIndex = 7;
            this.readItemButton.Text = "Read Item";
            this.readItemButton.UseVisualStyleBackColor = false;
            this.readItemButton.Click += new System.EventHandler(this.readItemButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Location = new System.Drawing.Point(522, 323);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 45);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(56, 107);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(240, 196);
            this.textBoxNote.TabIndex = 9;
            // 
            // newItemButton
            // 
            this.newItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newItemButton.Location = new System.Drawing.Point(56, 322);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(103, 47);
            this.newItemButton.TabIndex = 10;
            this.newItemButton.Text = "New Item";
            this.newItemButton.UseVisualStyleBackColor = false;
            this.newItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(691, 405);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readItemButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.noteBodyLabel);
            this.Controls.Add(this.AddItemButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NoteApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label noteBodyLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button readItemButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button newItemButton;
    }
}

