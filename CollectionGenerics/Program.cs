using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Del 1 - Stack

            Console.WriteLine("--Stack--");
            Console.WriteLine();
            Stack<Employee> StackEmp = new Stack<Employee>();

            Employee E1 = new Employee() { ID = 101, Name = "Lina", Gender = "Female", Salary = 20000 };
            Employee E2 = new Employee() { ID = 102, Name = "Linda", Gender = "Female", Salary = 21000 };
            Employee E3 = new Employee() { ID = 103, Name = "Jones", Gender = "Male", Salary = 22000 };
            Employee E4 = new Employee() { ID = 104, Name = "Josef", Gender = "Male", Salary = 23000 };
            Employee E5 = new Employee() { ID = 105, Name = "Noah", Gender = "Male", Salary = 24000 };

            StackEmp.Push(E1);
            StackEmp.Push(E2);
            StackEmp.Push(E3);
            StackEmp.Push(E4);
            StackEmp.Push(E5);

            Console.WriteLine("Retrieve Using Push Method:");
            foreach (var Employee in StackEmp)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", Employee.ID, Employee.Name, Employee.Gender, Employee.Salary);
                Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Retrieve Using Pop Method:");
            Employee EM1 = StackEmp.Pop();
            Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", EM1.ID, EM1.Name, EM1.Gender, EM1.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine();

            Employee EM2 = StackEmp.Pop();
            Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", EM2.ID, EM2.Name, EM2.Gender, EM2.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine();

            Employee EM3 = StackEmp.Pop();
            Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", EM3.ID, EM3.Name, EM3.Gender, EM3.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine();

            Employee EM4 = StackEmp.Pop();
            Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", EM4.ID, EM4.Name, EM4.Gender, EM4.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine();

            Employee EM5 = StackEmp.Pop();
            Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", EM5.ID, EM5.Name, EM5.Gender, EM5.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine();

            foreach (var Employee in StackEmp)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Gender = {2}, Salary = {3}", Employee.ID, Employee.Name, Employee.Gender, Employee.Salary);
                Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
                Console.WriteLine("");
            }

            StackEmp.Push(EM1);
            StackEmp.Push(EM2);
            StackEmp.Push(EM3);
            StackEmp.Push(EM4);
            StackEmp.Push(EM5);
            Console.WriteLine("------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Retrieve Using Peek Method:");
            Employee eS = StackEmp.Peek();
            Console.WriteLine(eS.ID + " - " + eS.Name + " - " + eS.Gender + " - " + eS.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);

            Employee eS1 = StackEmp.Peek();
            Console.WriteLine(eS1.ID + " - " + eS1.Name + " - " + eS1.Gender + " - " + eS1.Salary);
            Console.WriteLine("Total items left in the stack = " + StackEmp.Count);
            Console.WriteLine("------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Retrieve Using Contains Method:");
            if (StackEmp.Contains(EM3))
            {
                Console.WriteLine("Em3 is in the stack.");
            }
            else
            {
                Console.WriteLine("Em3 is NOT in the stack.");
            }

            // Del 2 - List
            Console.WriteLine("------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--List--");
            Console.WriteLine();
            Console.WriteLine("Retrieve Using Find Method:");
            List<Employee> listEmp = new List<Employee>();

            listEmp.Add(E1);
            listEmp.Add(E2);
            listEmp.Add(E3);
            listEmp.Add(E4);
            listEmp.Add(E5);

            if (listEmp.Contains(E2))
            {
                Console.WriteLine("Employee 2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list.");
            }

            Employee emp = listEmp.Find(e => e.Gender == "Male");
            Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
            Console.WriteLine("------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Retrieve Using Find All Method:");
            List<Employee> findemp = listEmp.FindAll(f => f.Gender == "Male");
            foreach (Employee item in findemp)
            {
                Console.WriteLine(item.ID + " - " + item.Name + " - " + item.Gender + " - " + item.Salary);
            }
            Console.WriteLine("------------------------------");

            Console.ReadKey();
        }
    }
}
