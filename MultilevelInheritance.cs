using System;

namespace Object_Oriented_Programming_Inheritance
{
    internal class BOI
    {
        public double rate_boi = 6.5;

        public double CalculateBOIBalance(int amount, int year)
        {
            return amount + ((amount * rate_boi * year) / 100);
        }
    }
    internal class Union:BOI
    {
        public double rate_union = 7.0;

        public double CalculateUnionBalance(int amount, int year)
        {
            return amount + ((amount * rate_union * year) / 100);
        }
    }
    internal class SBI: Union
    {
        public double rate_sbi = 7.5;

        public double CalculateSBIBalance(int amount, int year)
        {
            return amount + ((amount * rate_sbi * year) / 100);
        }
    }
}
