namespace ReadFileExercise
{
    partial class FrmOpenTextFile
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
            this.ReadTextListView = new System.Windows.Forms.ListView();
            this.NextButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ReadTextListView
            // 
            this.ReadTextListView.HideSelection = false;
            this.ReadTextListView.Location = new System.Drawing.Point(30, 24);
            this.ReadTextListView.Name = "ReadTextListView";
            this.ReadTextListView.Size = new System.Drawing.Size(637, 330);
            this.ReadTextListView.TabIndex = 0;
            this.ReadTextListView.UseCompatibleStateImageBehavior = false;
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(529, 378);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(137, 44);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "NEXT>";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(386, 378);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(137, 44);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "OPEN";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ReadTextListView);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.Load += new System.EventHandler(this.FrmOpenTextFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ReadTextListView;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

