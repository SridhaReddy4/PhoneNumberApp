using System;
using System.IO;

namespace PhoneNumberDetection
{
    public class InputValues
    {
        public static string ReadFromConsole()
        {
            Console.WriteLine("Enter the phone number:");
            return Console.ReadLine();
        }

        public static string ReadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            throw new FileNotFoundException("The specified file was not found.");
        }
    }
}
