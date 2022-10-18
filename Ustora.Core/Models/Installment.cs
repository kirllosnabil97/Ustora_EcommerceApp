using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class Installment:BaseClass
    {
     
    
        public int Installmentduration { get; set; }
      
        public string NationalNumber { get; set; } 
        public string Governorate { get; set; } 
        public string Social_status { get; set; } 
    

        public DateOnly DateNational { get; set; }
      

        public string FirstName { get; set; } 
       

      
     
        public string LastName { get; set; } 
     

        public string? FamilyName { get; set; }

        public string? Area { get; set; } 
      

        public string FirstAddress { get; set; } 


        public string SecondAddress { get; set; } 
      
        public string MobileNumber { get; set; } 

        public string MobileNumber2 { get; set; } 

  
       
        public string Email { get; set; } 
       
        public string JobName { get; set; } 
       

        public string Company { get; set; } 

     

        public double Salary { get; set; }
     
        public string CompanyAddress { get; set; } 

        public string Installmentmonthly { get; set; }

        public int InstallmentPeriodmonthly { get; set; }
        public string ItemPrice { get; set; }


        public string InstallmentWay { get; set; } 
     
        public ICollection<City>? Cities { get; set; } = new List<City>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();



    }
}
