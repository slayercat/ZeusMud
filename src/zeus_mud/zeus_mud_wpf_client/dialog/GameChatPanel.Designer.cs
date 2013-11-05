namespace zeus_mud.dialog
{
    partial class GameChatPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDebugRefresh = new System.Windows.Forms.Button();
            this.cefWebBrowser1 = new Xilium.CefGlue.WindowsForms.CefWebBrowser();
            this.SuspendLayout();
            // 
            // btnDebugRefresh
            // 
            this.btnDebugRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebugRefresh.Location = new System.Drawing.Point(195, 3);
            this.btnDebugRefresh.Name = "btnDebugRefresh";
            this.btnDebugRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnDebugRefresh.TabIndex = 4;
            this.btnDebugRefresh.Text = "刷新";
            this.btnDebugRefresh.UseVisualStyleBackColor = true;
            this.btnDebugRefresh.Click += new System.EventHandler(this.btnDebugRefresh_Click);
            // 
            // cefWebBrowser1
            // 
            this.cefWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cefWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.cefWebBrowser1.Name = "cefWebBrowser1";
            this.cefWebBrowser1.Size = new System.Drawing.Size(270, 92);
            this.cefWebBrowser1.TabIndex = 5;
            this.cefWebBrowser1.Text = "cefWebBrowser1";
            // 
            // GameChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDebugRefresh);
            this.Controls.Add(this.cefWebBrowser1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameChatPanel";
            this.Size = new System.Drawing.Size(299, 106);
            this.Load += new System.EventHandler(this.GameChatPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDebugRefresh;
        private Xilium.CefGlue.WindowsForms.CefWebBrowser cefWebBrowser1;

    }
}
