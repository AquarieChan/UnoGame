namespace UnoGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.stackCardLabel = new System.Windows.Forms.Label();
            this.playerCardsLabelList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AccessibleName = "currentPlayerLabel";
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(342, 93);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 13);
            this.currentPlayerLabel.TabIndex = 1;
            this.currentPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stackCardLabel
            // 
            this.stackCardLabel.AutoSize = true;
            this.stackCardLabel.Location = new System.Drawing.Point(345, 173);
            this.stackCardLabel.Name = "stackCardLabel";
            this.stackCardLabel.Size = new System.Drawing.Size(0, 13);
            this.stackCardLabel.TabIndex = 2;
            // 
            // playerCardsLabelList
            // 
            this.playerCardsLabelList.HideSelection = false;
            this.playerCardsLabelList.Location = new System.Drawing.Point(345, 263);
            this.playerCardsLabelList.Name = "playerCardsLabelList";
            this.playerCardsLabelList.Size = new System.Drawing.Size(121, 97);
            this.playerCardsLabelList.TabIndex = 3;
            this.playerCardsLabelList.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerCardsLabelList);
            this.Controls.Add(this.stackCardLabel);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label stackCardLabel;
        private System.Windows.Forms.ListView playerCardsLabelList;
    }
}