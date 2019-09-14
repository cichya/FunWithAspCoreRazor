using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithAspCoreRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ListModel : PageModel
    {
        public IList<Employee> Employees { get; private set; }

        public void OnGet()
        {
            this.Employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Jan",
                    LastName = "Kowalski"
                }
            };
        }
    }
}