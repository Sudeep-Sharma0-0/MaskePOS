using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using FuzzySharp;
using System.Collections;

namespace MaskePOS
{
    public partial class ProductsDisplay : Form
    {
        public int ProductsPerPage = 12;
        public int PageNumber = 1;
        public List<Product> products = new List<Product> { };
        public List<Product> searchResults = new List<Product> { };
        public List<Product> addedProducts = new List<Product>() { };

        public ProductsDisplay()
        {
            InitializeComponent();
            displayProducts();

            productsPage.SelectedIndexChanged += productsPage_SelectedIndexChanged;
        }

        private void LoadProducts()
        {
            products = dbProducts.GetAllProductsSync(PageNumber, ProductsPerPage);
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
                displayProducts();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string padder;

            PageNumber += 1;
            if (PageNumber < 10) padder = "0";
            else padder = "";

            pageLabel.Text = padder + PageNumber.ToString();
            displayProducts();
        }

        private void displayProducts()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            LoadProducts();
            for (int i = 0; i < products.Count; i++)
            {
                string name = "plabel" + (i + 1);
                string price = "pprice" + (i + 1);
                string descr = "pdescr" + (i + 1);

                Label nameLabel = FindControl(this, name) as Label;
                Label priceLabel = FindControl(this, price) as Label;
                Label descrLabel = FindControl(this, descr) as Label;

                if (nameLabel != null && priceLabel != null && descrLabel != null)
                {
                    nameLabel.Text = textInfo.ToTitleCase(products[i].Name);
                    priceLabel.Text = $"${products[i].Price}";
                    descrLabel.Text = products[i].Desc;
                }
            }
        }

        private Control FindControl(Control parent, string name)
        {
            if (parent.Name == name)
                return parent;

            foreach (Control ctrl in parent.Controls)
            {
                Control foundCtrl = FindControl(ctrl, name);
                if (foundCtrl != null)
                    return foundCtrl;
            }

            return null;
        }

        private void psearchBtn_Click(object sender, EventArgs e)
        {
            PerformFuzzySearch();
        }

        private async void PerformFuzzySearch()
        {
            try
            {
                productsDisplayTable.Visible = false;
                loadingBar.Style = ProgressBarStyle.Continuous;
                loadingBar.Style = ProgressBarStyle.Marquee;
                loadingBar.Visible = true;
                await Task.Delay(100);

                string searchQuery = psearchBox.Text.Trim().ToLower();
                List<Product> allProducts = await dbProducts.GetAllProductsAsync();
                List<string> productNames = allProducts.Select(p => p.Name.ToLower()).ToList();

                var matches = Process.ExtractAll(searchQuery, productNames, p => p, cutoff: 80);

                if (matches.Any())
                {
                    List<string> resultNames = matches.Select(r => r.Value).ToList();
                    searchResults = allProducts
                        .Where(p => resultNames.Contains(p.Name.ToLower()))
                        .ToList();
                }
                else
                {
                    MessageBox.Show("No search results found!");
                }
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error performing fuzzy search: {ex.Message}");
            }
            finally
            {
                loadingBar.Visible = false;
                productsDisplayTable.Visible = true;
            }
        }

        private void UpdateDisplay()
        {
            loadingBar.Visible = true;
            productsDisplayTable.Controls.Clear();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            for (int i = 0; i < searchResults.Count && i < 12; i++)
            {
                Panel panel = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Location = new Point(0, 0),
                    Padding = new Padding(0, 0, 0, 0),
                    Margin = new Padding(0, 0, 0, 0),
                };

                Label nameLabel = new Label
                {
                    Name = "plabel" + (i + 1),
                    Text = textInfo.ToTitleCase(searchResults[i].Name),
                    Location = new Point(11, 5),
                    Size = new Size(137, 27),
                    Font = new Font("Microsoft YaHei UI", 12),
                };
                panel.Controls.Add(nameLabel);

                Label priceLabel = new Label
                {
                    Name = "pprice" + (i + 1),
                    Text = $"${searchResults[i].Price}",
                    Location = new Point(149, 5),
                    Size = new Size(58, 27),
                    AutoSize = true,
                    Font = new Font("Microsoft YaHei UI", 12),
                };
                panel.Controls.Add(priceLabel);

                Label descrLabel = new Label
                {
                    Name = "pdescr" + (i + 1),
                    Text = searchResults[i].Desc,
                    Location = new Point(4, 118),
                    Size = new Size(145, 20),
                    Font = new Font("Microsoft YaHei UI", 9),
                };
                panel.Controls.Add(descrLabel);

                PictureBox pictureBox = new PictureBox
                {
                    Name = "pictureBox" + (i + 1),
                    Location = new Point(8, 34),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(210, 80),
                };
                panel.Controls.Add(pictureBox);

                Button addBtn = new Button
                {
                    Name = "paddbtn" + (i + 1),
                    Text = "Add",
                    Location = new Point(149, 118),
                    Size = new Size(70, 28),
                    Font = new Font("Microsoft YaHei UI", 12),
                    Tag = searchResults[i],
                };
                addBtn.Click += AddButton_Click;
                panel.Controls.Add(addBtn);

                productsDisplayTable.Controls.Add(panel, i % 4, i / 4);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Button addButton = sender as Button;
            if (addButton != null)
            {
                Product product = addButton.Tag as Product;
                if (product != null)
                {
                    addedProducts.Add(product);
                    MessageBox.Show($"{product.Name} has been added to the list.");
                }
            }
        }

        private void psearchBox_TextChanged(object sender, EventArgs e)
        {
            if (psearchBox.Text.Length > 0)
            {
                PerformFuzzySearch();
                UpdateDisplay();
            }
            else
            {
                displayProducts();
            }
        }

        private void productsPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsPage.SelectedTab == cartPage)
            {
                
            }
        }
    }
}