using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhoneNumberDetection
{
    public class ProgrammePattern
    {
        private static readonly string[] Patterns = new string[]
        {
            @"\b\d{10}\b", // 10-digit numbers
            @"\b\d{3}[-\s]\d{3}[-\s]\d{4}\b", // 123-456-7890, 123 456 7890
            @"\+\d{1,3}[-\s]\d{1,4}[-\s]\d{3}[-\s]\d{4}\b", // +91-123-456-7890, +1-123-456-7890
            @"\(\d{1,4}\)\s*\d{6,10}\b", // (123) 4567890, (91) 1234567890
        };

        public string DetectPhoneNumbers(string input)
        {

            foreach (var pattern in Patterns)
            {
                var matches = Regex.IsMatch(input, pattern);
                if(matches == true)
                {
                    return input;
                }
            }

            return "";
        }
    }
}
