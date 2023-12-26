
namespace Tyuiu.BorisovaDS.Sprint7.Project.V4
{
    partial class FormMain
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
            this.groupBoxMainMenu_BDS = new System.Windows.Forms.GroupBox();
            this.groupBoxDesignMainTwo_BDS = new System.Windows.Forms.GroupBox();
            this.labelMainMenu_BDS = new System.Windows.Forms.Label();
            this.groupBoxDesignMain_BDS = new System.Windows.Forms.GroupBox();
            this.buttonInformation_BDS = new System.Windows.Forms.Button();
            this.buttonInformationAboutBooks_BDS = new System.Windows.Forms.Button();
            this.buttonExit_BDS = new System.Windows.Forms.Button();
            this.groupBoxMainMenu_BDS.SuspendLayout();
            this.groupBoxDesignMainTwo_BDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMainMenu_BDS
            // 
            this.groupBoxMainMenu_BDS.Controls.Add(this.buttonExit_BDS);
            this.groupBoxMainMenu_BDS.Controls.Add(this.groupBoxDesignMainTwo_BDS);
            this.groupBoxMainMenu_BDS.Controls.Add(this.groupBoxDesignMain_BDS);
            this.groupBoxMainMenu_BDS.Controls.Add(this.buttonInformation_BDS);
            this.groupBoxMainMenu_BDS.Controls.Add(this.buttonInformationAboutBooks_BDS);
            this.groupBoxMainMenu_BDS.Location = new System.Drawing.Point(-3, -14);
            this.groupBoxMainMenu_BDS.Name = "groupBoxMainMenu_BDS";
            this.groupBoxMainMenu_BDS.Size = new System.Drawing.Size(808, 470);
            this.groupBoxMainMenu_BDS.TabIndex = 0;
            this.groupBoxMainMenu_BDS.TabStop = false;
            // 
            // groupBoxDesignMainTwo_BDS
            // 
            this.groupBoxDesignMainTwo_BDS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDesignMainTwo_BDS.Controls.Add(this.labelMainMenu_BDS);
            this.groupBoxDesignMainTwo_BDS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDesignMainTwo_BDS.Name = "groupBoxDesignMainTwo_BDS";
            this.groupBoxDesignMainTwo_BDS.Size = new System.Drawing.Size(808, 64);
            this.groupBoxDesignMainTwo_BDS.TabIndex = 5;
            this.groupBoxDesignMainTwo_BDS.TabStop = false;
            // 
            // labelMainMenu_BDS
            // 
            this.labelMainMenu_BDS.AutoSize = true;
            this.labelMainMenu_BDS.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelMainMenu_BDS.Location = new System.Drawing.Point(351, 23);
            this.labelMainMenu_BDS.Name = "labelMainMenu_BDS";
            this.labelMainMenu_BDS.Size = new System.Drawing.Size(94, 13);
            this.labelMainMenu_BDS.TabIndex = 2;
            this.labelMainMenu_BDS.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // groupBoxDesignMain_BDS
            // 
            this.groupBoxDesignMain_BDS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDesignMain_BDS.Location = new System.Drawing.Point(-16, 416);
            this.groupBoxDesignMain_BDS.Name = "groupBoxDesignMain_BDS";
            this.groupBoxDesignMain_BDS.Size = new System.Drawing.Size(824, 54);
            this.groupBoxDesignMain_BDS.TabIndex = 4;
            this.groupBoxDesignMain_BDS.TabStop = false;
            // 
            // buttonInformation_BDS
            // 
            this.buttonInformation_BDS.Location = new System.Drawing.Point(235, 214);
            this.buttonInformation_BDS.Name = "buttonInformation_BDS";
            this.buttonInformation_BDS.Size = new System.Drawing.Size(316, 70);
            this.buttonInformation_BDS.TabIndex = 3;
            this.buttonInformation_BDS.Text = "Информация";
            this.buttonInformation_BDS.UseVisualStyleBackColor = true;
            this.buttonInformation_BDS.Click += new System.EventHandler(this.buttonInformation_BDS_Click);
            // 
            // buttonInformationAboutBooks_BDS
            // 
            this.buttonInformationAboutBooks_BDS.Location = new System.Drawing.Point(235, 111);
            this.buttonInformationAboutBooks_BDS.Name = "buttonInformationAboutBooks_BDS";
            this.buttonInformationAboutBooks_BDS.Size = new System.Drawing.Size(316, 70);
            this.buttonInformationAboutBooks_BDS.TabIndex = 0;
            this.buttonInformationAboutBooks_BDS.Text = "Книги";
            this.buttonInformationAboutBooks_BDS.UseVisualStyleBackColor = true;
            this.buttonInformationAboutBooks_BDS.Click += new System.EventHandler(this.buttonInformationAboutBooks_BDS_Click);
            // 
            // buttonExit_BDS
            // 
            this.buttonExit_BDS.Location = new System.Drawing.Point(235, 318);
            this.buttonExit_BDS.Name = "buttonExit_BDS";
            this.buttonExit_BDS.Size = new System.Drawing.Size(316, 70);
            this.buttonExit_BDS.TabIndex = 6;
            this.buttonExit_BDS.Text = "Выйти из приложения";
            this.buttonExit_BDS.UseVisualStyleBackColor = true;
            this.buttonExit_BDS.Click += new System.EventHandler(this.buttonExit_BDS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMainMenu_BDS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxMainMenu_BDS.ResumeLayout(false);
            this.groupBoxDesignMainTwo_BDS.ResumeLayout(false);
            this.groupBoxDesignMainTwo_BDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMainMenu_BDS;
        private System.Windows.Forms.GroupBox groupBoxDesignMainTwo_BDS;
        private System.Windows.Forms.Label labelMainMenu_BDS;
        private System.Windows.Forms.GroupBox groupBoxDesignMain_BDS;
        private System.Windows.Forms.Button buttonInformation_BDS;
        private System.Windows.Forms.Button buttonInformationAboutBooks_BDS;
        private System.Windows.Forms.Button buttonExit_BDS;
    }
}

