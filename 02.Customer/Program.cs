namespace _02.Customer
{
    using System;
    using Models;

    public class Program
    {
        public static void Main()
        {
            var cm1 = new Customer("Pesho", "Atanosov", "Peshev", 8508156699, "Street 1", "+359895445566", "pesho@gosho.bg",CustomerType.OneTime);

            var cm2 = new Customer("Pesho", "Atanosov", "Peshev", 8508156699, "Iztok", "+359895445566", "pesho@gosho.bg", CustomerType.Diamond);

            // Check if equal
            Console.WriteLine(cm1 == cm2);

            // Clone Cutomer
            var cm3 = (Customer)cm2.Clone();

            cm3.AddPayment(
                new Payment("Kola", 5444),
                new Payment("Apartment", 99999));

            Console.WriteLine(cm3);
            Console.WriteLine(cm2);

            // Compare Cutomers
            Console.WriteLine(cm2.CompareTo(cm1));
        }
    }
}