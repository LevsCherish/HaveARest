namespace HaveARest
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.checkBox_skip = new System.Windows.Forms.CheckBox();
            this.checkBox_allScreen = new System.Windows.Forms.CheckBox();
            this.button_saveset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_skip
            // 
            this.checkBox_skip.AutoSize = true;
            this.checkBox_skip.Location = new System.Drawing.Point(25, 23);
            this.checkBox_skip.Name = "checkBox_skip";
            this.checkBox_skip.Size = new System.Drawing.Size(154, 31);
            this.checkBox_skip.TabIndex = 0;
            this.checkBox_skip.Text = "是否可以跳过";
            this.checkBox_skip.UseVisualStyleBackColor = true;
            // 
            // checkBox_allScreen
            // 
            this.checkBox_allScreen.AutoSize = true;
            this.checkBox_allScreen.Location = new System.Drawing.Point(25, 54);
            this.checkBox_allScreen.Name = "checkBox_allScreen";
            this.checkBox_allScreen.Size = new System.Drawing.Size(154, 31);
            this.checkBox_allScreen.TabIndex = 1;
            this.checkBox_allScreen.Text = "强制全屏显示";
            this.checkBox_allScreen.UseVisualStyleBackColor = true;
            // 
            // button_saveset
            // 
            this.button_saveset.Location = new System.Drawing.Point(161, 330);
            this.button_saveset.Name = "button_saveset";
            this.button_saveset.Size = new System.Drawing.Size(107, 40);
            this.button_saveset.TabIndex = 2;
            this.button_saveset.Text = "保存设置";
            this.button_saveset.UseVisualStyleBackColor = true;
            this.button_saveset.Click += new System.EventHandler(this.button_saveset_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 382);
            this.Controls.Add(this.button_saveset);
            this.Controls.Add(this.checkBox_allScreen);
            this.Controls.Add(this.checkBox_skip);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_skip;
        private System.Windows.Forms.CheckBox checkBox_allScreen;
        private System.Windows.Forms.Button button_saveset;
    }
}