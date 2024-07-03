using MaskePOS.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskePOS
{
    public partial class ControlPanel : Form
    {
        public int ProductsPerPage = 4;
        public int PageNumber = 1;
        public int prodId;

        public ControlPanel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            PageNumber = Int32.Parse(pageLabel.Text.ToString());

            tabsControl.SelectedIndexChanged += tabsControl_SelectedIndexChanged;
            productsGrid.SelectionChanged += productsGrid_SelectionChanged;
        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsGrid.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = productsGrid.SelectedRows[0];
                prodId = Int32.Parse(selectedRow.Cells["id"].Value.ToString());
            }
        }

        private void LoadProducts(int pageNumber)
        {
            var products = dbProducts.GetAllProductsSync(pageNumber, ProductsPerPage);
            productsGrid.DataSource = products;
        }

        private void tabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsControl.SelectedIndex == 1)
            {
                LoadProducts(1);
            }
        }

        private void selectImgBtn_Click(object sender, EventArgs e)
        {
            using (selectImg)
            {
                selectImg.InitialDirectory = "c:\\";
                selectImg.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                selectImg.FilterIndex = 1;
                selectImg.RestoreDirectory = true;

                if (selectImg.ShowDialog() == DialogResult.OK)
                {
                    string filePath = selectImg.FileName;
                    Image originalImage = Image.FromFile(filePath);
                    Image resizedImage = ResizeImage(originalImage, 250, 225);

                    productImg.Image = resizedImage;
                }
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedBitmap;
        }

        private void paddBtn_Click(object sender, EventArgs e)
        {
            string prodName = nameBox.Text.ToString();
            decimal prodPrice = 0;
            if (priceBox.Text != "")
            {
                prodPrice = decimal.Parse(priceBox.Text);
            }
            
            string prodDescr = descrBox.Text.ToString();
            Product product = new Product(prodName, prodPrice, prodDescr);

            var validation = ProductValidations.DataTypeValidation(product);
            if (validation)
            {
                dbProducts.AddProduct(product);
            }
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = productsGrid.Rows[e.RowIndex];

                prodId = Int32.Parse(row.Cells[0].Value.ToString());
                unameBox.Text = row.Cells[1].Value.ToString();
                upriceBox.Text = row.Cells[2].Value.ToString();
                udescrBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (PageNumber > 1)
            {
                string padder;

                PageNumber -= 1;
                if (PageNumber < 10) padder = "0";
                else padder = "";

                pageLabel.Text = padder + PageNumber.ToString();
                LoadProducts(PageNumber);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string padder;

            PageNumber += 1;
            if (PageNumber < 10) padder = "0";
            else padder = "";

            pageLabel.Text = padder + PageNumber.ToString();
            LoadProducts(PageNumber);
        }

        private void pupdateBtn_Click(object sender, EventArgs e)
        {
            string prodName = unameBox.Text.ToString();
            decimal prodPrice = 0;
            if (upriceBox.Text != "")
            {
                prodPrice = decimal.Parse(upriceBox.Text);
            }

            string prodDescr = udescrBox.Text.ToString();
            Product product = new Product(prodName, prodPrice, prodDescr);
            product.Id = prodId;

            var validation = ProductValidations.DataTypeValidation(product);
            if (validation)
            {
                dbProducts.UpdateProduct(product);
                clearSelection();
            }
        }

        private void clearSelection()
        {
            unameBox.Text = string.Empty;
            upriceBox.Text = string.Empty;
            udescrBox.Text = string.Empty;
            productsGrid.ClearSelection();
            prodId = 0;

            LoadProducts(Int32.Parse(pageLabel.Text.ToString()));
        }

        private void pdeleteBtn_Click(object sender, EventArgs e)
        {
            if (productsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product before deletion!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbProducts.DeleteProduct(prodId);
                LoadProducts(PageNumber);
            }
            else
            {
                MessageBox.Show("Product deletion cancelled!");
                LoadProducts(PageNumber);
            }
        }
    }
}
