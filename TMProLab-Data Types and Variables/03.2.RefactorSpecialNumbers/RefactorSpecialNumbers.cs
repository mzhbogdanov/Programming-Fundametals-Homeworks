using System;

    class RefactorSpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());                     
            bool special = false;
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                
                int digit = num;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
            special = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}",num,special);
            
            
            }
        }
    }

