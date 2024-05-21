using System;


namespace PhoneNumberDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = string.Empty;
            //InputValues1 inputValues = new InputValues1();
            Console.WriteLine("Type 1 to enter from file 2 to enter from console");
            string inputType=Console.ReadLine();
            if (inputType == "1")
            {
                Console.WriteLine("Enter the file path");
                string filePath = "";
                filePath = Console.ReadLine();  // give the directory with the file name "F:\NewTextDocument.txt"
                if (filePath == "")
                {
                    Console.WriteLine("File Path not specified");                }
                try
                {
                    inputText = InputValues.ReadFromFile(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return;
                }
            }
            else
            {
                inputText = InputValues.ReadFromConsole();
            }

            var detector = new ProgrammePattern();
            var phoneNumber = detector.DetectPhoneNumbers(inputText);
            OutputValues.DisplayPhoneNumbers(phoneNumber);
        }
    }

}
