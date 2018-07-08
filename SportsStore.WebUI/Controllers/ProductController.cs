using SportsStore.Domain.Abstract;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepo)
        {
            repository = productRepo;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}