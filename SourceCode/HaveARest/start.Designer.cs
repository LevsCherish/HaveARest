namespace HaveARest
{
    partial class start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button_skip = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(180, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 124);
            this.label2.TabIndex = 0;
            this.label2.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(240, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "休息一下吧~";
            // 
            // button_skip
            // 
            this.button_skip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_skip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_skip.Location = new System.Drawing.Point(247, 315);
            this.button_skip.Name = "button_skip";
            this.button_skip.Size = new System.Drawing.Size(154, 47);
            this.button_skip.TabIndex = 3;
            this.button_skip.Text = "跳过休息";
            this.button_skip.UseVisualStyleBackColor = true;
            this.button_skip.Visible = false;
            this.button_skip.Click += new System.EventHandler(this.button_skip_Click);
            // 
            // label_close
            // 
            this.label_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_close.AutoSize = true;
            this.label_close.Location = new System.Drawing.Point(621, 2);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(26, 25);
            this.label_close.TabIndex = 4;
            this.label_close.Text = "×";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.button_skip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start";
            this.Load += new System.EventHandler(this.start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_skip;
        private System.Windows.Forms.Label label_close;
    }
}