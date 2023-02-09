using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Application.Controllers
{
    public class ProductController1 : Controller
    {
        // GET: ProductController1
        string connectionString = @"Data Source=DESKTOP-E5JJ4PE\ABDULSQL;Initial Catalog=MVCCRUDDB;User ID=sa;Password=abdul542001;Pooling=False";
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dttblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PRODUCT", sqlCon);
                sqlDa.Fill(dttblProduct);
            }
                return View(dttblProduct);
        }

        // GET: ProductController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
