using System;
using System.Reflection;

namespace LogDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            method1();
            method2();
            method3();
            method4();
            method5();

            Console.WriteLine("Press any key to finish...");
            Console.ReadLine();
        }

        private static void method1()
        {
            Log.Operatios.Info("Hi info", MethodBase.GetCurrentMethod().Name);
        }

        private static void method2()
        {
            Log.Operatios.Warning("Hi warning", MethodBase.GetCurrentMethod().Name);

        }

        private static void method3()
        {
            Log.Operatios.Error("Hi error", MethodBase.GetCurrentMethod().Name);
        }

        private static void method4()
        {
            Log.Operatios.Debug("Hi debug", MethodBase.GetCurrentMethod().Name);
        }

        private static void method5()
        {
            Log.Operatios.Fatal("Hi fatal", MethodBase.GetCurrentMethod().Name);
        }
    }
}
