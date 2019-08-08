using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodingForTheLongHaul.Tests
{
    [TestClass]
    public class ObjectInitializerTests
    {
        #region Nothing to see here
        private string firstName = "Derek";
        private string lastName = "Schwechel";
        private string address = "One Brewers Way";
        private string city = "Milwaukee";
        private string state = "Wisconsin";
        private string zipCode = "53214";
        private DateTime birthDate = DateTime.Now.AddYears(-36);
        private DateTime hireDate = DateTime.Now.AddYears(-4);
        private int salary = 100;
        private int fudgeFactor = 0;
        #endregion Nothing to see here

        [TestMethod]
        public void WithObjectInitializer()
        {
            ObjectInitializer newObject;
            try
            {
                newObject = new ObjectInitializer()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    ZipCode = zipCode,
                    BirthDate = birthDate,
                    HireDate = hireDate,
                    Age = GetAge(),
                    YearsAtCompany = GetYearsAtCompany(),
                    Salary = salary,
                    Bonus = salary * GetYearsAtCompany() / (100 * fudgeFactor),
                    VacationDays = GetVacationDays() / GetHoursPerDay(),
                    HoursPerDay = GetHoursPerDay() / GetDaysPerWeek(),
                    DaysPerWeek = GetDaysPerWeek() / GetYearsAtCompany()
                };
            }
            catch (Exception e)
            {
                var error = e;
                throw;
            }
            

            Assert.IsNotNull(newObject);
        }

        [TestMethod]
        public void WithoutObjectInitializer()
        {
            var newObject = new ObjectInitializer();

            try
            {
                newObject.FirstName = firstName;
                newObject.LastName = lastName;
                newObject.Address = address;
                newObject.City = city;
                newObject.State = state;
                newObject.ZipCode = zipCode;
                newObject.BirthDate = birthDate;
                newObject.HireDate = hireDate;
                newObject.Age = GetAge();
                newObject.YearsAtCompany = GetYearsAtCompany();
                newObject.Salary = salary;
                newObject.Bonus = salary * GetYearsAtCompany() / (100 * fudgeFactor);
                newObject.VacationDays = GetVacationDays() / GetHoursPerDay();
                newObject.HoursPerDay = GetHoursPerDay() / GetDaysPerWeek();
                newObject.DaysPerWeek = GetDaysPerWeek() / GetYearsAtCompany();
            }
            catch (Exception e)
            {
                var error = e;
                throw;
            }

            Assert.IsNotNull(newObject);
        }

        private int GetAge()
        {
            return DateTime.Now.Year - birthDate.Year;
        }

        private int GetYearsAtCompany()
        {
            return DateTime.Now.Year - hireDate.Year;
        }

        private int GetVacationDays()
        {
            return 10;
        }

        private int GetHoursPerDay()
        {
            return 8;
        }

        private int GetDaysPerWeek()
        {
            var haha = 0;
            return 5/haha;
        }
    }
}
