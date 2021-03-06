﻿// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///  Main class to perform the operation.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n -------------- Desing Pattern -------------------\n");
                Console.WriteLine(" 1. Singleton pattern \n 2. Factory Pattern \n 3. Prototype Pattern \n 4. Exit");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SingletonPattern singleton = new SingletonPattern();
                        singleton.SingletonFactory();
                        break;
                    case 2:
                        FactoryPattern.MainFactory.Factory();
                        break;
                    case 3:
                        Prototype_Pattern.Employee emp = new Prototype_Pattern.Employee();
                        emp.PrototypeFunction();
                        break;

                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You entered wrong input please try again");
                        break;
                }
            }
        }

        /// <summary>
        /// Prints the student.
        /// </summary>
        ////private static void PrintStudent()
        ////{
            /*
            * Assuming Singleton is created from the student class
            * we refer to GetInstance property from the singleton class 
           */
        ////    Singleton fromstudent = Singleton.GetInstance;
        ////    fromstudent.PrintDetails("From Student");
        ////}

        ///// <summary>
        ///// Prints the employee.
        ///// </summary>
        ////private static void PrintEmployee()
        ////{
           /*
             * Assuming Singleton is created from the employee class
             * we refer to GetInstance property from the singleton class 
             */
        ////    Singleton fromemployee = Singleton.GetInstance;
        ////    fromemployee.PrintDetails("From Employee");
        ////}
    }
}
