using CRMLight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRMLight.Employees
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        private static readonly IEmployeeRepository _employee = new EmployeeRepository();
         
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CRMLight.Models.Employee newEmployee = new CRMLight.Models.Employee();
            newEmployee.Company = txtbCompany.Text;
            newEmployee.FirstName = txtbFirstName.Text;
            newEmployee.LastName = txtbLastName.Text;
            newEmployee.Email = txtbEmail.Text;
            newEmployee.JobTitle = txtbJobTitle.Text;

            newEmployee.WorkPhone = txtbWorkphone.Text;
            newEmployee.HomePhone = txtbHomephone.Text;
            newEmployee.MobilePhone = txtbMobilePhone.Text;
            newEmployee.Fax = txtbFax.Text;

            newEmployee.Website = txtbWebsite.Text;
            //newEmployee.Notes = employee.Notes;
            _employee.AddEmployee(newEmployee);

          
        }
    }
}