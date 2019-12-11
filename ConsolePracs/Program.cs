using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int[] intArr = input.Split('/').Select(int.Parse).ToArray();
            var dateTime1 = new DateTime(intArr[0], intArr[1], intArr[2]);

            int monthDays = 0;
            if (dateTime1.Month - 1 <= 6)
                monthDays = ((dateTime1.Month - 1) * 31);
            else if (dateTime1.Month - 1 > 6 && dateTime1.Month - 1 <= 11)
                monthDays = (((dateTime1.Month - 1) - 6) * 30) + (6 * 31);

            var allSolarLeapDays = (dateTime1.Year - 1) / 4;
            var Calculation1 = (((dateTime1.Year - 1) * 365) + (monthDays) + dateTime1.Day + allSolarLeapDays);
            const int DaysDiffer = 226899;
            var ADLeapDays = allSolarLeapDays + 155;

            var yearCalpart1 = ((Calculation1 + DaysDiffer) - ADLeapDays);
            var yearCalfinal = ((yearCalpart1 / 365) + 1);

            var isADLeap = false;
            if (yearCalfinal % 4 == 0)
                isADLeap = true;
            if (yearCalfinal % 100 == 0)
                isADLeap = false;
            if (yearCalfinal % 400 == 0)
                isADLeap = true;

            int i = 0;
            var yearRemainder = (yearCalpart1 % 365);
            if (yearRemainder > 31)//Jan
            {
                yearRemainder -= 31;
                i++;
            }
            if (isADLeap == true && yearRemainder > 29 && i == 1)//Feb
            {
                yearRemainder -= 29;
                i++;
            }
            if (isADLeap == false && yearRemainder > 28 && i == 1)//FebIsLeap
            {
                yearRemainder -= 28;
                i++;
            }
            if (yearRemainder > 31 && i == 2)//March
            {
                yearRemainder -= 31;
                i++;
            }
            if (yearRemainder > 30 && i == 3) //aprill
            {
                yearRemainder -= 30;
                i++;
            }
            if (yearRemainder > 31 && i == 4)//Apr
            {
                yearRemainder -= 31;
                i++;
            }
            if (yearRemainder > 30 && i == 5)//Jun
            {
                yearRemainder -= 30;
                i++;
            }
            if (yearRemainder > 31 && i == 6)//July
            {
                yearRemainder -= 31;
                i++;
            }
            if (yearRemainder > 31 && i == 7)//Aug
            {
                yearRemainder -= 31;
                i++;
            }
            if (yearRemainder > 30 && i == 8)//Sep
            {
                yearRemainder -= 30;
                i++;
            }
            if (yearRemainder > 31 && i == 9)//Oct
            {
                yearRemainder -= 31;
                i++;
            }
            if (yearRemainder > 30 && i == 10)//Nov
            {
                yearRemainder -= 30;
                i++;
            }
            if (yearRemainder > 31 && i == 11)//Dec
            {
                yearRemainder -= 31;
                i++;
            }

            var dateAD = new DateTime(yearCalfinal, (i + 1), yearRemainder);
            Console.WriteLine(dateAD.Year + "/" + dateAD.Month + "/" + dateAD.Day);
        }
    }
}
