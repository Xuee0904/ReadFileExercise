namespace ReadFileExercise
{
    partial class FrmStudentRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UploadButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View record";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 310);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UploadButton
            // 
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.Location = new System.Drawing.Point(532, 377);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(137, 44);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "UPLOAD";
            this.UploadButton.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(389, 377);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(137, 44);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "FIND";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(246, 377);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(137, 44);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.Load += new System.EventHandler(this.FrmStudentRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button RegisterButton;
    }
}