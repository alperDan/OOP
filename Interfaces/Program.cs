using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Customer ve Student Yazılan alan
            PersonManeger personManeger = new PersonManeger();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Alper",
                LastName = "Dan",
                Address = "İstanbul"
            };
            personManeger.Add(customer);
            Student student = new Student
            {
                Id = 2,
                FirstName = "Burçin",
                LastName = "Yolgörür",
                Departmant = "Satış"
            };
            personManeger.Add(student);
            #endregion

            #region DataBase Bağlama
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            #endregion

            #region Ek Gelebilcek Databaseleri Rahatça Bağladığımız Alan
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            #endregion



            Console.ReadLine();
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get ; set ; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get ; set ; }
            public string Departmant { get; set; }

        }

        class PersonManeger
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
}
