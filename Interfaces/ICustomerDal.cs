using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Customer Dal Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Customer Dal Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Customer Dal Güncellendi");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Customer Dal Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Customer Dal Silindi");
            
        }

        public void Update()
        {
            Console.WriteLine("Oracle Customer Dal Güncellendi");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
