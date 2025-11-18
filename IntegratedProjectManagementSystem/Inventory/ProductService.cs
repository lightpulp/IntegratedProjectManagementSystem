using IntegratedProjectManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedProjectManagementSystem.Inventory
{
    internal class ProductService
    {
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string Dimension { get; set; }
            public decimal SalePrice { get; set; }
            public bool IsActive { get; set; }
            public byte[] ProductImage { get; set; }
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT ProductId, ProductName, Description, Category, Dimension, 
                   SalePrice, IsActive, ProductImage
            FROM Products 
            ORDER BY ProductName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] productImage = null;
                        if (!reader.IsDBNull("ProductImage"))
                        {
                            productImage = (byte[])reader["ProductImage"];
                        }

                        products.Add(new Product
                        {
                            ProductId = reader.GetInt32("ProductId"),
                            ProductName = reader.GetString("ProductName"),
                            Description = reader.IsDBNull("Description") ? "" : reader.GetString("Description"),
                            Category = reader.IsDBNull("Category") ? "" : reader.GetString("Category"),
                            Dimension = reader.IsDBNull("Dimension") ? "" : reader.GetString("Dimension"),
                            SalePrice = reader.GetDecimal("SalePrice"),
                            IsActive = reader.GetBoolean("IsActive"),
                            ProductImage = productImage
                        });
                    }
                }
            }

            return products;
        }
    }
}
