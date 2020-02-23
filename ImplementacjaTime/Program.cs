using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{
   

    class Program
    {
        static void Main(string[] args)
        {

            Time timeNrONe = new Time(12, 0, 0);
            Time timeNrTwo = new Time(12, 1);
            Time timeNrThree = new Time(12);
            Time timeNrFour = new Time();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( $"timeNrONe: {timeNrONe}" );
            Console.WriteLine($"timeNrTwo: {timeNrTwo}");
            Console.WriteLine($"timeNrThree: {timeNrThree}");
            Console.WriteLine($"timeNrFour: {timeNrFour}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Time test \n");
            Console.ForegroundColor = ConsoleColor.White;
            TimePeriod timePeriodTest = new TimePeriod(2, 20, 20);

            Console.WriteLine($"{timeNrONe} {timeNrTwo}                     = equals {timeNrONe.Equals(timeNrTwo)}");
            Console.WriteLine($"{timeNrONe} {timeNrTwo}                     = compare {timeNrONe.CompareTo(timeNrTwo)}");
            Console.WriteLine($"{timeNrONe} + {timeNrTwo}                   = {timeNrONe + timeNrTwo}");
            Console.WriteLine($"{timeNrONe} - {timeNrTwo}                   = {timeNrONe - timeNrTwo}");
            Console.WriteLine($"{timeNrONe}.Plus({timePeriodTest})               = {timeNrONe.Plus(timePeriodTest)}");
            Console.WriteLine($"Time.Plus({timeNrONe}, {timePeriodTest})         = {Time.Plus(timeNrONe,timePeriodTest)}");
            Console.WriteLine($"{timeNrONe} == {timeNrTwo}                  = {timeNrONe == timeNrTwo}");
            Console.WriteLine($"{timeNrONe} != {timeNrTwo}                  = {timeNrONe != timeNrTwo}");
            Console.WriteLine($"{timeNrONe} > {timeNrTwo}                   = {timeNrONe > timeNrTwo}");
            Console.WriteLine($"{timeNrONe} < {timeNrTwo}                   = {timeNrONe < timeNrTwo}");
            Console.WriteLine($"{timeNrONe} >= {timeNrTwo}                  = {timeNrONe >= timeNrTwo}");
            Console.WriteLine($"{timeNrONe} <= {timeNrTwo}                  = {timeNrONe <= timeNrTwo}\n");


            TimePeriod timePeriod1 = new TimePeriod(12, 0, 0);
            TimePeriod timePeriod2 = new TimePeriod(12, 1);
            TimePeriod timePeriod3 = new TimePeriod(12);
            TimePeriod timePeriod4 = new TimePeriod();
            TimePeriod timePeriod5 = new TimePeriod(timeNrONe, timeNrTwo);
            Console.WriteLine($"timePeriod1: {timePeriod1}");
            Console.WriteLine($"timePeriod2: {timePeriod2}");
            Console.WriteLine($"timePeriod3: {timePeriod3}");
            Console.WriteLine($"timePeriod4: {timePeriod4}");
            Console.WriteLine($"timePeriod5(timeNrONe,timeNrTwo): {timePeriod5}");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("TimePeriod test \n");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"{timePeriod1} {timePeriod2}                     = equals {timePeriod1.Equals(timePeriod2)}");
            Console.WriteLine($"{timePeriod1} {timePeriod2}                     = compare {timePeriod1.CompareTo(timePeriod2)}");
            Console.WriteLine($"{timePeriod1} + {timePeriod2}                   = {timePeriod1 + timePeriod2}");
            Console.WriteLine($"{timePeriod1} - {timePeriod2}                   = {timePeriod1 - timePeriod2}");
            Console.WriteLine($"{timePeriod1}.Plus({timePeriodTest})              = {timePeriod1.Plus(timePeriodTest)}");
            Console.WriteLine($"TimePeriod.Plus({timePeriod1}, {timePeriodTest})  = {TimePeriod.Plus(timePeriod1, timePeriodTest)}");
            Console.WriteLine($"{timePeriod1} == {timePeriod2}                  = {timePeriod1 == timePeriod2}");
            Console.WriteLine($"{timePeriod1} != {timePeriod2}                  = {timePeriod1 != timePeriod2}");
            Console.WriteLine($"{timePeriod1} > {timePeriod2}                   = {timePeriod1 > timePeriod2}");
            Console.WriteLine($"{timePeriod1} < {timePeriod2}                   = {timePeriod1 < timePeriod2}");
            Console.WriteLine($"{timePeriod1} >= {timePeriod2}                  = {timePeriod1 >= timePeriod2}");
            Console.WriteLine($"{timePeriod1} <= {timePeriod2}                  = {timePeriod1 <= timePeriod2}\n");









        }
    }
}