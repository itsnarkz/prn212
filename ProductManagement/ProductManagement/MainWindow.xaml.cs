using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maxid = 4;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public MainWindow()
        {
            InitializeComponent();
            productService = new ProductService();
            categoryService = new CategoryService();
        }

        public void resetInput()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtUnitsInStock.Text = "";
            cboCategory.SelectedValue = 0;
        }

        public void LoadCategoryList()
        {
            try
            {
                var catList = categoryService.GetCategories();
                cboCategory.ItemsSource = catList;
                cboCategory.DisplayMemberPath = "categoryName";
                cboCategory.SelectedValuePath = "categoryId";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading categories!");
            }
        }

        public void LoadProductList()
        {
            try
            {
                var list = productService.getAllProducts();
                dgData.ItemsSource = null;
                dgData.ItemsSource = list;
                //MessageBox.Show(list.ElementAt(3).name);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading products!");
            }
            finally
            {
                resetInput();
            }
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCategoryList();
            LoadProductList();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product();
                product.id = maxid++;
                product.name = txtProductName.Text;
                product.unitPrice = Decimal.Parse(txtPrice.Text);
                product.unitsInStock = short.Parse(txtUnitsInStock.Text);
                if (cboCategory.SelectedValue == null) throw new Exception("Select product category!");
                product.categoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                productService.saveProduct(product);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                LoadProductList();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtProductID.Text.Length > 0)
                {
                    Product product = new Product();
                    product.id = int.Parse(txtProductID.Text);
                    product.name = txtProductName.Text;
                    product.unitPrice = Decimal.Parse(txtPrice.Text);
                    product.unitsInStock = short.Parse(txtUnitsInStock.Text);
                    product.categoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    productService.updateProduct(product);
                } else
                {
                    MessageBox.Show("You must select a product!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadProductList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtProductID.Text.Length > 0)
                {
                    Product product = new Product();
                    product.id = int.Parse(txtProductID.Text);
                    product.name = txtProductName.Text;
                    product.unitPrice = Decimal.Parse(txtPrice.Text);
                    product.unitsInStock = short.Parse(txtUnitsInStock.Text);
                    product.categoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    productService.deleteProduct(product);
                }
                else
                {
                    MessageBox.Show("You must select a product!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadProductList();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataGrid dataGrid = sender as DataGrid;
                DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dgData.SelectedIndex);

                DataGridCell rowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

                string id = ((TextBlock)rowColumn.Content).Text;

                Product product = productService.GetProductById(Int32.Parse(id));

                txtProductID.Text = id;
                txtProductName.Text = product.name;
                txtPrice.Text = product.unitPrice.ToString();
                txtUnitsInStock.Text = product.unitsInStock.ToString();
                cboCategory.SelectedValue = product.categoryId;
            } catch(Exception ex)
            {
                return;
            }
        }
    }
}
