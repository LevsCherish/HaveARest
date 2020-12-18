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
            this.textBox_work = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_skip
            // 
            this.checkBox_skip.AutoSize = true;
            this.checkBox_skip.Location = new System.Drawing.Point(12, 12);
            this.checkBox_skip.Name = "checkBox_skip";
            this.checkBox_skip.Size = new System.Drawing.Size(125, 25);
            this.checkBox_skip.TabIndex = 0;
            this.checkBox_skip.Text = "是否跳过休息";
            this.checkBox_skip.UseVisualStyleBackColor = true;
            // 
            // checkBox_allScreen
            // 
            this.checkBox_allScreen.AutoSize = true;
            this.checkBox_allScreen.Location = new System.Drawing.Point(12, 43);
            this.checkBox_allScreen.Name = "checkBox_allScreen";
            this.checkBox_allScreen.Size = new System.Drawing.Size(125, 25);
            this.checkBox_allScreen.TabIndex = 1;
            this.checkBox_allScreen.Text = "强制全屏显示";
            this.checkBox_allScreen.UseVisualStyleBackColor = true;
            // 
            // button_saveset
            // 
            this.button_saveset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_saveset.Location = new System.Drawing.Point(148, 262);
            this.button_saveset.Name = "button_saveset";
            this.button_saveset.Size = new System.Drawing.Size(107, 40);
            this.button_saveset.TabIndex = 2;
            this.button_saveset.Text = "保存设置";
            this.button_saveset.UseVisualStyleBackColor = true;
            this.button_saveset.Click += new System.EventHandler(this.button_saveset_Click);
            // 
            // textBox_work
            // 
            this.textBox_work.Location = new System.Drawing.Point(10, 123);
            this.textBox_work.Name = "textBox_work";
            this.textBox_work.Size = new System.Drawing.Size(180, 29);
            this.textBox_work.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "工作时提示语句";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "休息时提示语句";
            // 
            // textBox_rest
            // 
            this.textBox_rest.Location = new System.Drawing.Point(10, 206);
            this.textBox_rest.Name = "textBox_rest";
            this.textBox_rest.Size = new System.Drawing.Size(180, 29);
            this.textBox_rest.TabIndex = 6;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_rest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_work);
            this.Controls.Add(this.checkBox_skip);
            this.Controls.Add(this.checkBox_allScreen);
            this.Controls.Add(this.button_saveset);
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
        private System.Windows.Forms.TextBox textBox_work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rest;
    }
}