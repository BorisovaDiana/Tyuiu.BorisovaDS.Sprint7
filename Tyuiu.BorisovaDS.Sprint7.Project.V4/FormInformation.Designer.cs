
namespace Tyuiu.BorisovaDS.Sprint7.Project.V4
{
    partial class FormInformation
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
            this.groupBoxFormInformation_BDS = new System.Windows.Forms.GroupBox();
            this.groupBoxDesignInformation_BDS = new System.Windows.Forms.GroupBox();
            this.groupBoxDesignInfo_BDS = new System.Windows.Forms.GroupBox();
            this.buttonQuiqGuide_BDS = new System.Windows.Forms.Button();
            this.buttonInform_BDS = new System.Windows.Forms.Button();
            this.buttonExitInMenu_BDS = new System.Windows.Forms.Button();
            this.groupBoxFormInformation_BDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormInformation_BDS
            // 
            this.groupBoxFormInformation_BDS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxFormInformation_BDS.Controls.Add(this.buttonExitInMenu_BDS);
            this.groupBoxFormInformation_BDS.Controls.Add(this.buttonInform_BDS);
            this.groupBoxFormInformation_BDS.Controls.Add(this.buttonQuiqGuide_BDS);
            this.groupBoxFormInformation_BDS.Controls.Add(this.groupBoxDesignInformation_BDS);
            this.groupBoxFormInformation_BDS.Controls.Add(this.groupBoxDesignInfo_BDS);
            this.groupBoxFormInformation_BDS.Location = new System.Drawing.Point(-2, -14);
            this.groupBoxFormInformation_BDS.Name = "groupBoxFormInformation_BDS";
            this.groupBoxFormInformation_BDS.Size = new System.Drawing.Size(808, 470);
            this.groupBoxFormInformation_BDS.TabIndex = 0;
            this.groupBoxFormInformation_BDS.TabStop = false;
            // 
            // groupBoxDesignInformation_BDS
            // 
            this.groupBoxDesignInformation_BDS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDesignInformation_BDS.Location = new System.Drawing.Point(0, 408);
            this.groupBoxDesignInformation_BDS.Name = "groupBoxDesignInformation_BDS";
            this.groupBoxDesignInformation_BDS.Size = new System.Drawing.Size(808, 74);
            this.groupBoxDesignInformation_BDS.TabIndex = 1;
            this.groupBoxDesignInformation_BDS.TabStop = false;
            // 
            // groupBoxDesignInfo_BDS
            // 
            this.groupBoxDesignInfo_BDS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDesignInfo_BDS.Location = new System.Drawing.Point(0, -7);
            this.groupBoxDesignInfo_BDS.Name = "groupBoxDesignInfo_BDS";
            this.groupBoxDesignInfo_BDS.Size = new System.Drawing.Size(808, 72);
            this.groupBoxDesignInfo_BDS.TabIndex = 0;
            this.groupBoxDesignInfo_BDS.TabStop = false;
            // 
            // buttonQuiqGuide_BDS
            // 
            this.buttonQuiqGuide_BDS.Location = new System.Drawing.Point(233, 122);
            this.buttonQuiqGuide_BDS.Name = "buttonQuiqGuide_BDS";
            this.buttonQuiqGuide_BDS.Size = new System.Drawing.Size(290, 42);
            this.buttonQuiqGuide_BDS.TabIndex = 2;
            this.buttonQuiqGuide_BDS.Text = "Краткое руководство";
            this.buttonQuiqGuide_BDS.UseVisualStyleBackColor = true;
            this.buttonQuiqGuide_BDS.Click += new System.EventHandler(this.buttonQuiqGuide_BDS_Click);
            // 
            // buttonInform_BDS
            // 
            this.buttonInform_BDS.Location = new System.Drawing.Point(233, 213);
            this.buttonInform_BDS.Name = "buttonInform_BDS";
            this.buttonInform_BDS.Size = new System.Drawing.Size(290, 42);
            this.buttonInform_BDS.TabIndex = 3;
            this.buttonInform_BDS.Text = "Справочные данные";
            this.buttonInform_BDS.UseVisualStyleBackColor = true;
            this.buttonInform_BDS.Click += new System.EventHandler(this.buttonInform_BDS_Click);
            // 
            // buttonExitInMenu_BDS
            // 
            this.buttonExitInMenu_BDS.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitInMenu_BDS.Location = new System.Drawing.Point(233, 308);
            this.buttonExitInMenu_BDS.Name = "buttonExitInMenu_BDS";
            this.buttonExitInMenu_BDS.Size = new System.Drawing.Size(290, 42);
            this.buttonExitInMenu_BDS.TabIndex = 4;
            this.buttonExitInMenu_BDS.Text = "Вернуться в главное меню";
            this.buttonExitInMenu_BDS.UseVisualStyleBackColor = false;
            this.buttonExitInMenu_BDS.Click += new System.EventHandler(this.buttonExitInMenu_BDS_Click);
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFormInformation_BDS);
            this.Name = "FormInformation";
            this.groupBoxFormInformation_BDS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormInformation_BDS;
        private System.Windows.Forms.GroupBox groupBoxDesignInformation_BDS;
        private System.Windows.Forms.GroupBox groupBoxDesignInfo_BDS;
        private System.Windows.Forms.Button buttonExitInMenu_BDS;
        private System.Windows.Forms.Button buttonInform_BDS;
        private System.Windows.Forms.Button buttonQuiqGuide_BDS;
    }
}