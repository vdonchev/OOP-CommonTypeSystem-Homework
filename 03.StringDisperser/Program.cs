namespace _03.StringDisperser
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("pesho");
            StringDisperser stringDisperser2 = new StringDisperser("pesho");

            // foreach
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
           
            // check if equal
            Console.WriteLine(stringDisperser.Equals(stringDisperser2)); // true

            // check if equal with opearator != & ==
            Console.WriteLine(stringDisperser != stringDisperser2); // true
            Console.WriteLine(stringDisperser == stringDisperser2); // false

            // clone and check if reference is the same
            var stringDisperser3 = (StringDisperser)stringDisperser.Clone();
            Console.WriteLine(ReferenceEquals(stringDisperser, stringDisperser3)); // false

            // compare two StringDispersers
            var stringDisperser4 = new StringDisperser("pesho", "gosho", "vanio");
            Console.WriteLine(stringDisperser.CompareTo(stringDisperser4));
        }
    }
}
