using System;
using System.Collections.Generic;

namespace PhoneNumberDetection
{
    public class OutputValues
    {
        public static void DisplayPhoneNumbers(string phoneNumbers)
        {
            if (phoneNumbers == "")
            {
                Console.WriteLine("No phone number detected.");
                return;
            }

            Console.WriteLine($"Detected Phone Number: {phoneNumbers}");
        }
    }
}
