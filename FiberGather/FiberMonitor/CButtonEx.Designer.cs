﻿namespace FiberMonitor
{
    partial class CButtonEx
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CButtonEx_MouseClick);
            this.label1.MouseLeave += new System.EventHandler(this.CButtonEx_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CButtonEx_MouseMove);
            // 
            // CButtonEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Name = "CButtonEx";
            this.Size = new System.Drawing.Size(71, 56);
            this.Load += new System.EventHandler(this.CButtonEx_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CButtonEx_MouseClick);
            this.MouseLeave += new System.EventHandler(this.CButtonEx_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CButtonEx_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

    }
}
