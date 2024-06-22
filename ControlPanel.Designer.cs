namespace MaskePOS
{
    partial class ControlPanel
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
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.paddPage = new System.Windows.Forms.TabPage();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.paddBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.descrBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.selectImgBtn = new System.Windows.Forms.Button();
            this.imgLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pviewPage = new System.Windows.Forms.TabPage();
            this.uimageBox = new System.Windows.Forms.PictureBox();
            this.upriceBox = new System.Windows.Forms.TextBox();
            this.udescrBox = new System.Windows.Forms.TextBox();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.uselectImgBtn = new System.Windows.Forms.Button();
            this.uimageLabel = new System.Windows.Forms.Label();
            this.upriceLabel = new System.Windows.Forms.Label();
            this.udescrLabel = new System.Windows.Forms.Label();
            this.unameLabel = new System.Windows.Forms.Label();
            this.pupdateBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.pdeleteBtn = new System.Windows.Forms.Button();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.selectImg = new System.Windows.Forms.OpenFileDialog();
            this.tabsControl.SuspendLayout();
            this.paddPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.pviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uimageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.paddPage);
            this.tabsControl.Controls.Add(this.pviewPage);
            this.tabsControl.Location = new System.Drawing.Point(12, 12);
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(776, 414);
            this.tabsControl.TabIndex = 2;
            // 
            // paddPage
            // 
            this.paddPage.Controls.Add(this.productImg);
            this.paddPage.Controls.Add(this.paddBtn);
            this.paddPage.Controls.Add(this.priceBox);
            this.paddPage.Controls.Add(this.descrBox);
            this.paddPage.Controls.Add(this.nameBox);
            this.paddPage.Controls.Add(this.selectImgBtn);
            this.paddPage.Controls.Add(this.imgLabel);
            this.paddPage.Controls.Add(this.priceLabel);
            this.paddPage.Controls.Add(this.descrLabel);
            this.paddPage.Controls.Add(this.nameLabel);
            this.paddPage.Location = new System.Drawing.Point(4, 25);
            this.paddPage.Name = "paddPage";
            this.paddPage.Padding = new System.Windows.Forms.Padding(3);
            this.paddPage.Size = new System.Drawing.Size(768, 385);
            this.paddPage.TabIndex = 1;
            this.paddPage.Text = "Add Product";
            this.paddPage.UseVisualStyleBackColor = true;
            // 
            // productImg
            // 
            this.productImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImg.Location = new System.Drawing.Point(477, 32);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(250, 227);
            this.productImg.TabIndex = 10;
            this.productImg.TabStop = false;
            // 
            // paddBtn
            // 
            this.paddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddBtn.Location = new System.Drawing.Point(344, 303);
            this.paddBtn.Name = "paddBtn";
            this.paddBtn.Size = new System.Drawing.Size(135, 40);
            this.paddBtn.TabIndex = 9;
            this.paddBtn.Text = "Add Product";
            this.paddBtn.UseVisualStyleBackColor = true;
            this.paddBtn.Click += new System.EventHandler(this.paddBtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.AcceptsTab = true;
            this.priceBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(235, 97);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(135, 29);
            this.priceBox.TabIndex = 7;
            // 
            // descrBox
            // 
            this.descrBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrBox.Location = new System.Drawing.Point(235, 157);
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(135, 29);
            this.descrBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(235, 34);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 29);
            this.nameBox.TabIndex = 5;
            // 
            // selectImgBtn
            // 
            this.selectImgBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImgBtn.Location = new System.Drawing.Point(235, 219);
            this.selectImgBtn.Name = "selectImgBtn";
            this.selectImgBtn.Size = new System.Drawing.Size(135, 40);
            this.selectImgBtn.TabIndex = 4;
            this.selectImgBtn.Text = "Select Image";
            this.selectImgBtn.UseVisualStyleBackColor = true;
            this.selectImgBtn.Click += new System.EventHandler(this.selectImgBtn_Click);
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgLabel.Location = new System.Drawing.Point(128, 223);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(82, 29);
            this.imgLabel.TabIndex = 3;
            this.imgLabel.Text = "Image";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(144, 95);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(66, 29);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrLabel.Location = new System.Drawing.Point(73, 155);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(137, 29);
            this.descrLabel.TabIndex = 1;
            this.descrLabel.Text = "Description";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(131, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // pviewPage
            // 
            this.pviewPage.Controls.Add(this.uimageBox);
            this.pviewPage.Controls.Add(this.upriceBox);
            this.pviewPage.Controls.Add(this.udescrBox);
            this.pviewPage.Controls.Add(this.unameBox);
            this.pviewPage.Controls.Add(this.uselectImgBtn);
            this.pviewPage.Controls.Add(this.uimageLabel);
            this.pviewPage.Controls.Add(this.upriceLabel);
            this.pviewPage.Controls.Add(this.udescrLabel);
            this.pviewPage.Controls.Add(this.unameLabel);
            this.pviewPage.Controls.Add(this.pupdateBtn);
            this.pviewPage.Controls.Add(this.pageLabel);
            this.pviewPage.Controls.Add(this.nextBtn);
            this.pviewPage.Controls.Add(this.prevBtn);
            this.pviewPage.Controls.Add(this.pdeleteBtn);
            this.pviewPage.Controls.Add(this.productsGrid);
            this.pviewPage.Location = new System.Drawing.Point(4, 25);
            this.pviewPage.Name = "pviewPage";
            this.pviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.pviewPage.Size = new System.Drawing.Size(768, 385);
            this.pviewPage.TabIndex = 2;
            this.pviewPage.Text = "View Products";
            this.pviewPage.UseVisualStyleBackColor = true;
            // 
            // uimageBox
            // 
            this.uimageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uimageBox.Location = new System.Drawing.Point(588, 6);
            this.uimageBox.Name = "uimageBox";
            this.uimageBox.Size = new System.Drawing.Size(174, 157);
            this.uimageBox.TabIndex = 23;
            this.uimageBox.TabStop = false;
            // 
            // upriceBox
            // 
            this.upriceBox.AcceptsTab = true;
            this.upriceBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upriceBox.Location = new System.Drawing.Point(91, 40);
            this.upriceBox.Name = "upriceBox";
            this.upriceBox.Size = new System.Drawing.Size(135, 29);
            this.upriceBox.TabIndex = 22;
            // 
            // udescrBox
            // 
            this.udescrBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udescrBox.Location = new System.Drawing.Point(251, 38);
            this.udescrBox.Name = "udescrBox";
            this.udescrBox.Size = new System.Drawing.Size(219, 29);
            this.udescrBox.TabIndex = 21;
            // 
            // unameBox
            // 
            this.unameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameBox.Location = new System.Drawing.Point(91, 5);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(135, 29);
            this.unameBox.TabIndex = 20;
            // 
            // uselectImgBtn
            // 
            this.uselectImgBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uselectImgBtn.Location = new System.Drawing.Point(94, 96);
            this.uselectImgBtn.Name = "uselectImgBtn";
            this.uselectImgBtn.Size = new System.Drawing.Size(135, 40);
            this.uselectImgBtn.TabIndex = 19;
            this.uselectImgBtn.Text = "Select Image";
            this.uselectImgBtn.UseVisualStyleBackColor = true;
            // 
            // uimageLabel
            // 
            this.uimageLabel.AutoSize = true;
            this.uimageLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uimageLabel.Location = new System.Drawing.Point(6, 96);
            this.uimageLabel.Name = "uimageLabel";
            this.uimageLabel.Size = new System.Drawing.Size(82, 29);
            this.uimageLabel.TabIndex = 18;
            this.uimageLabel.Text = "Image";
            // 
            // upriceLabel
            // 
            this.upriceLabel.AutoSize = true;
            this.upriceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upriceLabel.Location = new System.Drawing.Point(6, 38);
            this.upriceLabel.Name = "upriceLabel";
            this.upriceLabel.Size = new System.Drawing.Size(66, 29);
            this.upriceLabel.TabIndex = 17;
            this.upriceLabel.Text = "Price";
            // 
            // udescrLabel
            // 
            this.udescrLabel.AutoSize = true;
            this.udescrLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udescrLabel.Location = new System.Drawing.Point(246, 5);
            this.udescrLabel.Name = "udescrLabel";
            this.udescrLabel.Size = new System.Drawing.Size(137, 29);
            this.udescrLabel.TabIndex = 16;
            this.udescrLabel.Text = "Description";
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLabel.Location = new System.Drawing.Point(6, 3);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(79, 29);
            this.unameLabel.TabIndex = 15;
            this.unameLabel.Text = "Name";
            // 
            // pupdateBtn
            // 
            this.pupdateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupdateBtn.Location = new System.Drawing.Point(314, 173);
            this.pupdateBtn.Name = "pupdateBtn";
            this.pupdateBtn.Size = new System.Drawing.Size(156, 40);
            this.pupdateBtn.TabIndex = 14;
            this.pupdateBtn.Text = "Update Product";
            this.pupdateBtn.UseVisualStyleBackColor = true;
            this.pupdateBtn.Click += new System.EventHandler(this.pupdateBtn_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel.Location = new System.Drawing.Point(679, 175);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(33, 38);
            this.pageLabel.TabIndex = 13;
            this.pageLabel.Text = "1";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(718, 173);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(44, 40);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.Location = new System.Drawing.Point(629, 173);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(44, 40);
            this.prevBtn.TabIndex = 11;
            this.prevBtn.Text = "<<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // pdeleteBtn
            // 
            this.pdeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdeleteBtn.Location = new System.Drawing.Point(6, 173);
            this.pdeleteBtn.Name = "pdeleteBtn";
            this.pdeleteBtn.Size = new System.Drawing.Size(147, 40);
            this.pdeleteBtn.TabIndex = 10;
            this.pdeleteBtn.Text = "Delete Product";
            this.pdeleteBtn.UseVisualStyleBackColor = true;
            this.pdeleteBtn.Click += new System.EventHandler(this.pdeleteBtn_Click);
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Location = new System.Drawing.Point(6, 219);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.RowTemplate.Height = 24;
            this.productsGrid.Size = new System.Drawing.Size(756, 160);
            this.productsGrid.TabIndex = 0;
            this.productsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellClick);
            // 
            // selectImg
            // 
            this.selectImg.FileName = "productImg";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsControl);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.tabsControl.ResumeLayout(false);
            this.paddPage.ResumeLayout(false);
            this.paddPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.pviewPage.ResumeLayout(false);
            this.pviewPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uimageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage paddPage;
        private System.Windows.Forms.TabPage pviewPage;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox descrBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button selectImgBtn;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.OpenFileDialog selectImg;
        private System.Windows.Forms.Button paddBtn;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Button pdeleteBtn;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.PictureBox productImg;
        private System.Windows.Forms.Button pupdateBtn;
        private System.Windows.Forms.PictureBox uimageBox;
        private System.Windows.Forms.TextBox upriceBox;
        private System.Windows.Forms.TextBox udescrBox;
        private System.Windows.Forms.TextBox unameBox;
        private System.Windows.Forms.Button uselectImgBtn;
        private System.Windows.Forms.Label uimageLabel;
        private System.Windows.Forms.Label upriceLabel;
        private System.Windows.Forms.Label udescrLabel;
        private System.Windows.Forms.Label unameLabel;
    }
}