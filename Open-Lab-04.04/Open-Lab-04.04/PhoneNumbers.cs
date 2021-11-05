using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string number = ($"({numbers[0]}");
            number += numbers[1];
            number += numbers[2];
            number += ($") {numbers[3]}");
            number += numbers[4];
            number += numbers[5];
            number += ($"-{numbers[6]}");
            number += numbers[7];
            number += numbers[8];
            number += numbers[9];
            return number;
        }
    }
}
