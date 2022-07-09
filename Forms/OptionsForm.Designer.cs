/*
  Title Display plugin for KeePass Password Safe
  Copyright (C) 2009-2010 SEG Tech <me@gogogadgetscott.info>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

namespace TitleDisplay.Forms
{
    partial class OptionsForm
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
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Option7 = new System.Windows.Forms.RadioButton();
            this.Option6 = new System.Windows.Forms.RadioButton();
            this.Option5 = new System.Windows.Forms.RadioButton();
            this.Option4 = new System.Windows.Forms.RadioButton();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowProductName = new System.Windows.Forms.CheckBox();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTitleLen = new System.Windows.Forms.NumericUpDown();
            this.lblMaxTitleLen = new System.Windows.Forms.Label();
            this.ShowModifyDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTitleLen)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(371, 304);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 0;
            this.m_btnOK.Text = "&OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(452, 304);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "&Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(539, 60);
            this.m_bannerImage.TabIndex = 0;
            this.m_bannerImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Option7);
            this.groupBox1.Controls.Add(this.Option6);
            this.groupBox1.Controls.Add(this.Option5);
            this.groupBox1.Controls.Add(this.Option4);
            this.groupBox1.Controls.Add(this.txtCustom);
            this.groupBox1.Controls.Add(this.Option3);
            this.groupBox1.Controls.Add(this.Option2);
            this.groupBox1.Controls.Add(this.Option1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // Option7
            // 
            this.Option7.Location = new System.Drawing.Point(14, 77);
            this.Option7.Name = "Option7";
            this.Option7.Size = new System.Drawing.Size(240, 24);
            this.Option7.TabIndex = 7;
            this.Option7.TabStop = true;
            this.Option7.Text = "Option7";
            this.Option7.UseVisualStyleBackColor = true;
            this.Option7.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option6
            // 
            this.Option6.Location = new System.Drawing.Point(14, 167);
            this.Option6.Name = "Option6";
            this.Option6.Size = new System.Drawing.Size(240, 24);
            this.Option6.TabIndex = 6;
            this.Option6.TabStop = true;
            this.Option6.Text = "Option6";
            this.Option6.UseVisualStyleBackColor = true;
            this.Option6.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option5
            // 
            this.Option5.Location = new System.Drawing.Point(14, 137);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(240, 24);
            this.Option5.TabIndex = 5;
            this.Option5.TabStop = true;
            this.Option5.Text = "Option5";
            this.Option5.UseVisualStyleBackColor = true;
            this.Option5.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(14, 107);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(240, 24);
            this.Option4.TabIndex = 4;
            this.Option4.TabStop = true;
            this.Option4.Text = "Option4";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(19, 227);
            this.txtCustom.MaxLength = 50;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(235, 20);
            this.txtCustom.TabIndex = 3;
            this.txtCustom.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(14, 197);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(240, 24);
            this.Option3.TabIndex = 2;
            this.Option3.TabStop = true;
            this.Option3.Text = "Option3";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(14, 47);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(240, 24);
            this.Option2.TabIndex = 1;
            this.Option2.TabStop = true;
            this.Option2.Text = "Option2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(14, 17);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(240, 24);
            this.Option1.TabIndex = 0;
            this.Option1.TabStop = true;
            this.Option1.Text = "Option1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(284, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ShowProductName
            // 
            this.ShowProductName.Location = new System.Drawing.Point(283, 96);
            this.ShowProductName.Name = "ShowProductName";
            this.ShowProductName.Size = new System.Drawing.Size(246, 24);
            this.ShowProductName.TabIndex = 8;
            this.ShowProductName.Text = "ShowProductName";
            this.ShowProductName.UseVisualStyleBackColor = true;
            this.ShowProductName.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(283, 186);
            this.txtExample.Multiline = true;
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(246, 54);
            this.txtExample.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(283, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Example:";
            // 
            // MaxTitleLen
            // 
            this.MaxTitleLen.Location = new System.Drawing.Point(284, 126);
            this.MaxTitleLen.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MaxTitleLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxTitleLen.Name = "MaxTitleLen";
            this.MaxTitleLen.Size = new System.Drawing.Size(38, 20);
            this.MaxTitleLen.TabIndex = 12;
            this.MaxTitleLen.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MaxTitleLen.ValueChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // lblMaxTitleLen
            // 
            this.lblMaxTitleLen.Location = new System.Drawing.Point(328, 128);
            this.lblMaxTitleLen.Name = "lblMaxTitleLen";
            this.lblMaxTitleLen.Size = new System.Drawing.Size(136, 20);
            this.lblMaxTitleLen.TabIndex = 13;
            this.lblMaxTitleLen.Text = "lblMaxTitleLen";
            // 
            // ShowModifyDate
            // 
            this.ShowModifyDate.Location = new System.Drawing.Point(283, 71);
            this.ShowModifyDate.Name = "ShowModifyDate";
            this.ShowModifyDate.Size = new System.Drawing.Size(246, 24);
            this.ShowModifyDate.TabIndex = 14;
            this.ShowModifyDate.Text = "ShowModifyDate";
            this.ShowModifyDate.UseVisualStyleBackColor = true;
            this.ShowModifyDate.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(539, 338);
            this.Controls.Add(this.ShowModifyDate);
            this.Controls.Add(this.lblMaxTitleLen);
            this.Controls.Add(this.MaxTitleLen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.ShowProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_bannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTitleLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.NumericUpDown MaxTitleLen;
        private System.Windows.Forms.Label lblMaxTitleLen;
        private System.Windows.Forms.RadioButton Option7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.CheckBox ShowProductName;
        private System.Windows.Forms.RadioButton Option4;
        private System.Windows.Forms.RadioButton Option5;
        private System.Windows.Forms.RadioButton Option6;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        #endregion

        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.PictureBox m_bannerImage;
        private System.Windows.Forms.CheckBox ShowModifyDate;
    }
}