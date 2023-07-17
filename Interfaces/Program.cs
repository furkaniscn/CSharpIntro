using System;

namespace Interfaces
{
    internal class Program
    {
        // interface newlenemez
        static void Main(string[] args)
        {
            
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        // Unimplemented operation
        public void Add();
        public void Update();
        // Implemented operation
        //{
        //    Console.WriteLine("Eklendi.");
        //}
    }
    // inherits-class ------------------------ implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }

    class InternManager : IPersonManager// Yeni bir kod eklerken diğer kodlara dokunmadık. Stajyer ekleme örneği
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)// Parametreyi interface verdik çünkü diğer 2 class implemente ediyor.
        {
            personManager.Add();
        }
        //public void AddEmployee(EmployeeManager employeeManager)
        //{
        //    employeeManager.Add();
        //}
    }
}
