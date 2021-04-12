
namespace MPL.MouseMove
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
            this.DelayMS = new System.Windows.Forms.NumericUpDown();
            this.DelayMS_Label = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMS)).BeginInit();
            this.SuspendLayout();
            // 
            // DelayMS
            // 
            this.DelayMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayMS.Location = new System.Drawing.Point(120, 12);
            this.DelayMS.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.DelayMS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DelayMS.Name = "DelayMS";
            this.DelayMS.Size = new System.Drawing.Size(72, 20);
            this.DelayMS.TabIndex = 1;
            this.DelayMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DelayMS.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DelayMS_Label
            // 
            this.DelayMS_Label.Location = new System.Drawing.Point(12, 10);
            this.DelayMS_Label.Name = "DelayMS_Label";
            this.DelayMS_Label.Size = new System.Drawing.Size(102, 20);
            this.DelayMS_Label.TabIndex = 0;
            this.DelayMS_Label.Text = "Update Delay (ms):";
            this.DelayMS_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(36, 43);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChangesButton.Location = new System.Drawing.Point(117, 43);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(75, 23);
            this.CancelChangesButton.TabIndex = 3;
            this.CancelChangesButton.Text = "Cancel";
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelChangesButton;
            this.ClientSize = new System.Drawing.Size(204, 78);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DelayMS_Label);
            this.Controls.Add(this.DelayMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 116);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 116);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.DelayMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DelayMS;
        private System.Windows.Forms.Label DelayMS_Label;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelChangesButton;
    }
}