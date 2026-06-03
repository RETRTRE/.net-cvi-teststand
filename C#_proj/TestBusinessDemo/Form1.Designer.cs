namespace TestBusinessDemo
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadRange = new System.Windows.Forms.Button();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txtMeasuredValue = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadRange
            // 
            this.btnLoadRange.Location = new System.Drawing.Point(181, 209);
            this.btnLoadRange.Name = "btnLoadRange";
            this.btnLoadRange.Size = new System.Drawing.Size(133, 40);
            this.btnLoadRange.TabIndex = 0;
            this.btnLoadRange.Text = "获取范围";
            this.btnLoadRange.UseVisualStyleBackColor = true;
            this.btnLoadRange.Click += new System.EventHandler(this.btnLoadRange_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "UUT1",
            "UUT2"});
            this.cmbModel.Location = new System.Drawing.Point(194, 145);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 20);
            this.cmbModel.TabIndex = 1;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // txtMeasuredValue
            // 
            this.txtMeasuredValue.Location = new System.Drawing.Point(388, 185);
            this.txtMeasuredValue.Name = "txtMeasuredValue";
            this.txtMeasuredValue.Size = new System.Drawing.Size(100, 21);
            this.txtMeasuredValue.TabIndex = 2;
            this.txtMeasuredValue.TextChanged += new System.EventHandler(this.txtMeasuredValue_TextChanged);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(182, 282);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(133, 40);
            this.btnEvaluate.TabIndex = 0;
            this.btnEvaluate.Text = "判断结果";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Location = new System.Drawing.Point(182, 355);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(133, 40);
            this.btnExportJson.TabIndex = 0;
            this.btnExportJson.Text = "导出JSON";
            this.btnExportJson.UseVisualStyleBackColor = true;
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(402, 248);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(53, 12);
            this.lblRange.TabIndex = 3;
            this.lblRange.Text = "显示范围";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(402, 296);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "显示结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.txtMeasuredValue);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.btnExportJson);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnLoadRange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadRange;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtMeasuredValue;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblResult;
    }
}

