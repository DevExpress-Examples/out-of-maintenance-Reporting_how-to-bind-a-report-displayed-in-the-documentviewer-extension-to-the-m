using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace E5023.Models {
    public class Category {
        public int CategoryID {
            get;
            set;
        }

        public string CategoryName {
            get;
            set;
        }

        public string Description {
            get;
            set;
        }

        public byte[] Picture {
            get;
            set;
        }

        public static List<Category> GetCategories() {
            DataTable catData = DataHelper.ProcessSelectCommand("SELECT * FROM [Categories]");
            if (catData != null) {
                List<Category> categories = new List<Category>();
                foreach (DataRow row in catData.Rows) {
                    Category category = new Category() {
                        CategoryID = (int) row["CategoryID"],
                        CategoryName = (string) row["CategoryName"],
                        Description = (string) row["Description"],
                        Picture = (byte[]) row["Picture"]
                    };
                    categories.Add(category);
                }
                return categories;
            }
            return null;
        }
    }
}