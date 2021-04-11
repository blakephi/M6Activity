
namespace M6Activity
{
    partial class mainForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.shiftBox = new System.Windows.Forms.TextBox();
            this.payBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(254, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Employee name: ";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(320, 415);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(160, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Information";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(254, 169);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(80, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Employee ID#: ";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(254, 199);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(119, 13);
            this.shiftLabel.TabIndex = 3;
            this.shiftLabel.Text = "Employee shift number: ";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(254, 229);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(100, 13);
            this.payLabel.TabIndex = 4;
            this.payLabel.Text = "Employee pay rate: ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(348, 136);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 5;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(340, 166);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(207, 20);
            this.numberBox.TabIndex = 6;
            // 
            // shiftBox
            // 
            this.shiftBox.Location = new System.Drawing.Point(379, 196);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(168, 20);
            this.shiftBox.TabIndex = 7;
            // 
            // payBox
            // 
            this.payBox.Location = new System.Drawing.Point(360, 226);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(187, 20);
            this.payBox.TabIndex = 8;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "mainForm";
            this.Text = "Worker Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox shiftBox;
        private System.Windows.Forms.TextBox payBox;
    }
}

