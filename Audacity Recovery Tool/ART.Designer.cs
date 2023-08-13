
namespace Audacity_Recovery_Tool
{
    partial class ART
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
            this.lbl_versiontext = new System.Windows.Forms.Label();
            this.btn_v2 = new System.Windows.Forms.Button();
            this.btn_v3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_searchFolder = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.openFolder = new System.Windows.Forms.OpenFileDialog();
            this.check_stereo = new System.Windows.Forms.CheckBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_versiontext
            // 
            this.lbl_versiontext.AutoSize = true;
            this.lbl_versiontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versiontext.Location = new System.Drawing.Point(11, 98);
            this.lbl_versiontext.Name = "lbl_versiontext";
            this.lbl_versiontext.Size = new System.Drawing.Size(189, 16);
            this.lbl_versiontext.TabIndex = 0;
            this.lbl_versiontext.Text = "Choose your Audacity version:";
            // 
            // btn_v2
            // 
            this.btn_v2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_v2.Location = new System.Drawing.Point(259, 92);
            this.btn_v2.Name = "btn_v2";
            this.btn_v2.Size = new System.Drawing.Size(52, 28);
            this.btn_v2.TabIndex = 1;
            this.btn_v2.Text = "v2";
            this.btn_v2.UseVisualStyleBackColor = true;
            this.btn_v2.Click += new System.EventHandler(this.btn_v2_Click);
            // 
            // btn_v3
            // 
            this.btn_v3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_v3.Location = new System.Drawing.Point(317, 92);
            this.btn_v3.Name = "btn_v3";
            this.btn_v3.Size = new System.Drawing.Size(52, 28);
            this.btn_v3.TabIndex = 2;
            this.btn_v3.Text = "v3";
            this.btn_v3.UseVisualStyleBackColor = true;
            this.btn_v3.Click += new System.EventHandler(this.btn_v3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_help);
            this.groupBox1.Controls.Add(this.btn_searchFolder);
            this.groupBox1.Controls.Add(this.txt_path);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SessionData";
            // 
            // btn_searchFolder
            // 
            this.btn_searchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchFolder.Location = new System.Drawing.Point(259, 19);
            this.btn_searchFolder.Name = "btn_searchFolder";
            this.btn_searchFolder.Size = new System.Drawing.Size(32, 22);
            this.btn_searchFolder.TabIndex = 1;
            this.btn_searchFolder.Text = "...";
            this.btn_searchFolder.UseVisualStyleBackColor = true;
            this.btn_searchFolder.Click += new System.EventHandler(this.btn_searchFolder_Click);
            // 
            // txt_path
            // 
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_path.Location = new System.Drawing.Point(6, 20);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(247, 20);
            this.txt_path.TabIndex = 0;
            // 
            // openFolder
            // 
            this.openFolder.FileName = "openFolder";
            // 
            // check_stereo
            // 
            this.check_stereo.AutoSize = true;
            this.check_stereo.Location = new System.Drawing.Point(14, 69);
            this.check_stereo.Name = "check_stereo";
            this.check_stereo.Size = new System.Drawing.Size(57, 17);
            this.check_stereo.TabIndex = 4;
            this.check_stereo.Text = "Stereo";
            this.check_stereo.UseVisualStyleBackColor = true;
            this.check_stereo.CheckedChanged += new System.EventHandler(this.check_stereo_CheckedChanged);
            // 
            // btn_help
            // 
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Location = new System.Drawing.Point(297, 19);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(50, 23);
            this.btn_help.TabIndex = 5;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // ART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 132);
            this.Controls.Add(this.check_stereo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_v3);
            this.Controls.Add(this.btn_v2);
            this.Controls.Add(this.lbl_versiontext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ART";
            this.Text = "Audacity Recovery Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_versiontext;
        private System.Windows.Forms.Button btn_v2;
        private System.Windows.Forms.Button btn_v3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_searchFolder;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.OpenFileDialog openFolder;
        private System.Windows.Forms.CheckBox check_stereo;
        private System.Windows.Forms.Button btn_help;
    }
}

