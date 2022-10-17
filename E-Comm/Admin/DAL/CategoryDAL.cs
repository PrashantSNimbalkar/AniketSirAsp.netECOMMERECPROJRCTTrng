using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using E_Comm.App_Code;
using E_Comm.Admin.Models;

namespace E_Comm.Admin.DAL
{
    public class CategoryDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public CategoryDAL()
        {
            con = new SqlConnection(DbConnectionStr.GetDbConnectionStr());
        }
        public int AddCategory(Category category)
        {
            return 1;
        }
        public int UpdateCategory(Category category)
        {
            return 1;
        }
        public Category GetCategoryById(int id)
        {
            Category c = new Category();
            return c;
        }
    }
}