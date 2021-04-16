using System;

namespace CustomerReview
{
    partial class CustomerReview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFoodRating = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReviewerPhone = new System.Windows.Forms.TextBox();
            this.txtReviewerEmail = new System.Windows.Forms.TextBox();
            this.txtReviewerName = new System.Windows.Forms.TextBox();
            this.cmbServiceRating = new System.Windows.Forms.ComboBox();
            this.cmbEnvironmentRating = new System.Windows.Forms.ComboBox();
            this.txtSuggestions = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridReview = new System.Windows.Forms.DataGridView();
            this.chartReview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviewer Name";
            // 
            // cmbFoodRating
            // 
            this.cmbFoodRating.FormattingEnabled = true;
            this.cmbFoodRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbFoodRating.Location = new System.Drawing.Point(455, 215);
            this.cmbFoodRating.Name = "cmbFoodRating";
            this.cmbFoodRating.Size = new System.Drawing.Size(158, 24);
            this.cmbFoodRating.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(455, 482);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 29);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reviewer Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reviewer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Food Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Service Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Environment Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Suggestions";
            // 
            // txtReviewerPhone
            // 
            this.txtReviewerPhone.Location = new System.Drawing.Point(455, 166);
            this.txtReviewerPhone.Name = "txtReviewerPhone";
            this.txtReviewerPhone.Size = new System.Drawing.Size(158, 22);
            this.txtReviewerPhone.TabIndex = 12;
            // 
            // txtReviewerEmail
            // 
            this.txtReviewerEmail.Location = new System.Drawing.Point(455, 119);
            this.txtReviewerEmail.Name = "txtReviewerEmail";
            this.txtReviewerEmail.Size = new System.Drawing.Size(158, 22);
            this.txtReviewerEmail.TabIndex = 13;
            // 
            // txtReviewerName
            // 
            this.txtReviewerName.Location = new System.Drawing.Point(455, 67);
            this.txtReviewerName.Name = "txtReviewerName";
            this.txtReviewerName.Size = new System.Drawing.Size(158, 22);
            this.txtReviewerName.TabIndex = 14;
            // 
            // cmbServiceRating
            // 
            this.cmbServiceRating.FormattingEnabled = true;
            this.cmbServiceRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbServiceRating.Location = new System.Drawing.Point(454, 265);
            this.cmbServiceRating.Name = "cmbServiceRating";
            this.cmbServiceRating.Size = new System.Drawing.Size(158, 24);
            this.cmbServiceRating.TabIndex = 15;
            // 
            // cmbEnvironmentRating
            // 
            this.cmbEnvironmentRating.FormattingEnabled = true;
            this.cmbEnvironmentRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEnvironmentRating.Location = new System.Drawing.Point(454, 317);
            this.cmbEnvironmentRating.Name = "cmbEnvironmentRating";
            this.cmbEnvironmentRating.Size = new System.Drawing.Size(158, 24);
            this.cmbEnvironmentRating.TabIndex = 16;
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.Location = new System.Drawing.Point(454, 367);
            this.txtSuggestions.Multiline = true;
            this.txtSuggestions.Name = "txtSuggestions";
            this.txtSuggestions.Size = new System.Drawing.Size(158, 98);
            this.txtSuggestions.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gridReview
            // 
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(718, 38);
            this.gridReview.Name = "gridReview";
            this.gridReview.RowHeadersWidth = 51;
            this.gridReview.RowTemplate.Height = 24;
            this.gridReview.Size = new System.Drawing.Size(240, 150);
            this.gridReview.TabIndex = 19;
            // 
            // chartReview
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReview.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReview.Legends.Add(legend1);
            this.chartReview.Location = new System.Drawing.Point(685, 223);
            this.chartReview.Name = "chartReview";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReview.Series.Add(series1);
            this.chartReview.Size = new System.Drawing.Size(327, 300);
            this.chartReview.TabIndex = 20;
            this.chartReview.Text = "chart1";
            // 
            // CustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chartReview);
            this.Controls.Add(this.gridReview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSuggestions);
            this.Controls.Add(this.cmbEnvironmentRating);
            this.Controls.Add(this.cmbServiceRating);
            this.Controls.Add(this.txtReviewerName);
            this.Controls.Add(this.txtReviewerEmail);
            this.Controls.Add(this.txtReviewerPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbFoodRating);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerReview";
            this.Text = "CustomerReview";
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFoodRating;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReviewerPhone;
        private System.Windows.Forms.TextBox txtReviewerEmail;
        private System.Windows.Forms.TextBox txtReviewerName;
        private System.Windows.Forms.ComboBox cmbServiceRating;
        private System.Windows.Forms.ComboBox cmbEnvironmentRating;
        private System.Windows.Forms.TextBox txtSuggestions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridReview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReview;
    }
}