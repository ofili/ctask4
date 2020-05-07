using Microsoft.AspNetCore.Mvc;
using System;

namespace Calculate.Controllers
{
     public class CalController : Controller
     {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string firstNumber, string secondNumber)
        {
            //Convert input to int
            int n1 = int.Parse(firstNumber);
            int n2 = int.Parse(secondNumber);
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;

            
            //Calculate squart root
            double Sn1 = (Math.Sqrt(n1));
            double Sn2 = (Math.Sqrt(n2));
            ViewBag.Sn1 = Sn1;
            ViewBag.Sn2 = Sn2;

            //Set result
            if (n1 < n2 || n2 < n1)
            {
                if (n1 <= 0 || n2 <= 0)

                    ViewBag.zero = "Your number must be greater than zero, try again!";
            } else
                ViewBag.same = "Your numbers cannot be equal, try again!";
        ViewBag.Result =  (n1 > n2)  ? Sn1 : Sn2;
            ViewBag.high = (n1 > n2) ? n1 : n2;
            ViewBag.low = (n1 <= n2) ? n1 : n2;
        return View();
        }
     };
}