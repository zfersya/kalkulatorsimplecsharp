namespace kalkulatorLibrary
{
    public static class point
    {
        public static double Penambahan(double num1, double num2)
        {
            return (num1 + num2);
        }
        public static double Pengurangan(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Perkalian(double num1, double num2)
        {
            return (num1 * num2);
        }
        public static double Pembagian(double num1, double num2)
        {
            if(num2 == 0) 
            { 
                throw new DivideByZeroException("Tidak Bisa Nol");
            }
            return (num1 / num2);
        }
        public static double Modulo(double num1, double num2)
        {
            return (num1 % num2);
        }
    }
}
