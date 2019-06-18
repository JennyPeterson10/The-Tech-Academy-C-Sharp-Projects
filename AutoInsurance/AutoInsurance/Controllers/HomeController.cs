using AutoInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Coverage(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, int speedingTickets, bool? dui, bool? fullCoverage, decimal? quote)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(Convert.ToString(dateOfBirth)) || string.IsNullOrEmpty(Convert.ToString(carYear))
                || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var user = new User
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        EmailAddress = emailAddress,
                        DateOfBirth = dateOfBirth,
                        CarYear = carYear,
                        CarMake = carMake,
                        CarModel = carModel,
                        DUI = dui,
                        SpeedingTickets = speedingTickets,
                        FullCoverage = fullCoverage
                    };

                    // The following determines the quote based on user input
                    decimal coverageCost = 50m;
                    int age = DateTime.Now.Year - dateOfBirth.Year;
                    if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear) age = age - 1;
                    // Add $25 if age under 25 and over 18
                    if (age < 25 && age >= 18) coverageCost += 25;
                    // Add $100 if age under 18
                    if (age < 18) coverageCost += 100;
                    // Add $25 if age over 100
                    if (age > 100) coverageCost += 25;
                    // Add 25 if car year is before 2000 or after 2015 
                    if (carYear < 2000 || carYear > 2015) coverageCost += 25;
                    // Add $25 if car make is a Porsche
                    if (carMake == "Porsche") coverageCost += 25;
                    // Add additional $25 if make is a Porsche and model is a 911 Carrera
                    if (carMake == "Porsche" && carModel == "911 Carrera") coverageCost += 25;
                    // Add $10 per speeding ticket
                    int speedingCost = 10 * speedingTickets;
                    coverageCost += speedingCost;
                    // Add 25% if user has had DUI
                    if (dui == true) quote = 1.25m * coverageCost;
                    else quote = coverageCost;
                    // Add 50% if full coverage
                    if (fullCoverage == true) quote = 1.5m * quote;
                    user.Quote = Convert.ToDouble(quote);

                    db.Users.Add(user);
                    db.SaveChanges();

                    ViewBag.quote = user.Quote;
                }              
            }        
            return View("Success");
        }

        public ActionResult Success(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var users = db.Users.ToList();
                return View(users);
            }      
        }
    }
}