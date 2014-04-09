using System;

namespace MVPApplication.View
{
    partial class ListViewForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sourceListView = new System.Windows.Forms.ListView();
            this.destListView = new System.Windows.Forms.ListView();
            this.browseButton = new System.Windows.Forms.Button();
            this.toDestinationButton = new System.Windows.Forms.Button();
            this.toSourceButton = new System.Windows.Forms.Button();
            this.clearSourceButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.sourceListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.destListView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toDestinationButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toSourceButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearSourceButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sourceListView
            // 
            this.sourceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceListView.Location = new System.Drawing.Point(3, 53);
            this.sourceListView.Name = "sourceListView";
            this.tableLayoutPanel1.SetRowSpan(this.sourceListView, 4);
            this.sourceListView.Size = new System.Drawing.Size(288, 496);
            this.sourceListView.TabIndex = 0;
            this.sourceListView.UseCompatibleStateImageBehavior = false;
            // 
            // destListView
            // 
            this.destListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destListView.Location = new System.Drawing.Point(372, 53);
            this.destListView.Name = "destListView";
            this.tableLayoutPanel1.SetRowSpan(this.destListView, 4);
            this.destListView.Size = new System.Drawing.Size(288, 496);
            this.destListView.TabIndex = 1;
            this.destListView.UseCompatibleStateImageBehavior = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(297, 53);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(69, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // toDestinationButton
            // 
            this.toDestinationButton.Location = new System.Drawing.Point(297, 103);
            this.toDestinationButton.Name = "toDestinationButton";
            this.toDestinationButton.Size = new System.Drawing.Size(69, 23);
            this.toDestinationButton.TabIndex = 3;
            this.toDestinationButton.Text = "->";
            this.toDestinationButton.UseVisualStyleBackColor = true;
            this.toDestinationButton.Click += new System.EventHandler(this.toDestinationButton_Click);
            // 
            // toSourceButton
            // 
            this.toSourceButton.Location = new System.Drawing.Point(297, 153);
            this.toSourceButton.Name = "toSourceButton";
            this.toSourceButton.Size = new System.Drawing.Size(69, 23);
            this.toSourceButton.TabIndex = 4;
            this.toSourceButton.Text = "<-";
            this.toSourceButton.UseVisualStyleBackColor = true;
            this.toSourceButton.Click += new System.EventHandler(this.toSourceButton_Click);
            // 
            // clearSourceButton
            // 
            this.clearSourceButton.Location = new System.Drawing.Point(297, 217);
            this.clearSourceButton.Name = "clearSourceButton";
            this.clearSourceButton.Size = new System.Drawing.Size(69, 23);
            this.clearSourceButton.TabIndex = 5;
            this.clearSourceButton.Text = "Clear";
            this.clearSourceButton.UseVisualStyleBackColor = true;
            this.clearSourceButton.Click += new System.EventHandler(this.clearSourceButton_Click);
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListViewForm";
            this.Text = "MVP Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public void BrowseFiles()
        {
            throw new System.NotImplementedException();
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView sourceListView;
        private System.Windows.Forms.ListView destListView;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button toDestinationButton;
        private System.Windows.Forms.Button toSourceButton;
        private System.Windows.Forms.Button clearSourceButton;
    }
}

