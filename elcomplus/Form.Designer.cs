namespace elcomplus
{
    sealed partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new MaterialSkin.Controls.MaterialButton();
            this.lable = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.download = new MaterialSkin.Controls.MaterialButton();
            this.treeView = new System.Windows.Forms.TreeView();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Depth = 0;
            this.btn.DrawShadows = true;
            this.btn.HighEmphasis = true;
            this.btn.Icon = null;
            this.btn.Location = new System.Drawing.Point(4, 12);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(174, 36);
            this.btn.TabIndex = 2;
            this.btn.Text = "Выбрать XML-фаил!";
            this.btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn.UseAccentColor = false;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lable.AutoSize = true;
            this.lable.Depth = 0;
            this.lable.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lable.Location = new System.Drawing.Point(215, 20);
            this.lable.MouseState = MaterialSkin.MouseState.HOVER;
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(107, 19);
            this.lable.TabIndex = 3;
            this.lable.Text = "materialLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.56642F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.43359F));
            this.tableLayoutPanel1.Controls.Add(this.btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.download, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 367);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // download
            // 
            this.download.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.download.Depth = 0;
            this.download.DrawShadows = true;
            this.download.HighEmphasis = true;
            this.download.Icon = null;
            this.download.Location = new System.Drawing.Point(4, 71);
            this.download.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.download.MouseState = MaterialSkin.MouseState.HOVER;
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(193, 36);
            this.download.TabIndex = 2;
            this.download.Text = "Загрузить по ссылке";
            this.download.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.download.UseAccentColor = false;
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.treeView, 2);
            this.treeView.Location = new System.Drawing.Point(3, 122);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(795, 242);
            this.treeView.TabIndex = 4;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(215, 78);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(583, 23);
            this.textBox.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Text = "Элком+";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn;
        private MaterialSkin.Controls.MaterialLabel lable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton download;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox textBox;
    }
}

