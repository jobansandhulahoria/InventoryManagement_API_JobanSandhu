using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement_API_JobanSandhu.Controllers
{
    public class StockMaintainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
