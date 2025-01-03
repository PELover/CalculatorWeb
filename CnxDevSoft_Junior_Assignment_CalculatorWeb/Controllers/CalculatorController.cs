using Microsoft.AspNetCore.Mvc;
using CnxDevSoft_Junior_Assignment_CalculatorWeb.Models;
using System.Collections.Generic;

namespace CnxDevSoft_Junior_Assignment_CalculatorWeb.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }
        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            switch (model.operators)
            {
                case "+":
                    model.result = (model.x + model.y);
                    break;
                case "-":
                    model.result = (model.x - model.y);
                    break;
                case "*":
                    model.result = (model.x * model.y);
                    break;
                case "/":
                    model.result = (model.x / model.y);
                    break;
                case "%":
                    model.result = (model.x % model.y);
                    break;
            }
            CalculatorModel.resulthistory.Add($"{model.x} {model.operators} {model.y} = {model.result}");
            return View(model);
        }
    }
}
