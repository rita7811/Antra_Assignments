public class UnderstandingTypes
{
    public static void Main()
    {
        string[] type =
            {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong",
             "float", "double", "decimal"};
        int[] bytes = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16 };
        string[] minimumValues = {"-128", "0", "-32,768", "0", "-2,147,483,648", "0",
                                  "-9,223,372,036,854,775,808", "0", "±1.0e-45",
                                  "±5e-324", "±1.0 ×10e-28"};
        string[] maximumValues = {"127", "255", "32,767", "65,535", "2,147,483,647",
                                  "4,294,967,295", "9,223,372,036,854,775,807",
                                  "18,446,744,073,709,551,615", "±3.4e38", "±1.7e308",
                                  "±7.9e28"};

        Console.WriteLine("{0,-10} | {1,5} | {2,30} | {3,30}\n", "Type", "Bytes", "Minimum Values", "Maximum Values");
        for (int ctr = 0; ctr < type.Length; ctr++)
            Console.WriteLine("{0,-10} | {1,5} | {2,30} | {3,30}", type[ctr], bytes[ctr], minimumValues[ctr], maximumValues[ctr]);
        
    }
}

