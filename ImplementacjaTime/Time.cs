using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{

    /// <summary>
    /// This is main Time struct.
    /// </summary>
    public struct  Time : IEquatable<Time> , IComparable<Time>
    {
        
        public readonly byte hours;
        public readonly byte minutes;
        public readonly byte seconds;

        /// <summary>
        /// Time constructor takes three arguments, 
        /// used to create a Time object with a hour, minutes and seconds.
        /// </summary>
        /// <param name="hours"> A byte. If hours are greater than 24 a modulo operation is used. </param>
        /// <param name="minutes">A byte. If minutes are greater than 60 a modulo operation is used.</param>
        /// <param name="seconds">A byte. If seconds are greater than 60 a modulo operation is used.</param>
        public Time(byte hours, byte minutes, byte seconds)
        {
         
            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = (byte)(seconds % 60);    
        }

        /// <summary>
        /// Constructor with two arguments, 
        /// Creating a Time object with a hour and minutes. Seconds value is 0.
        /// </summary>
        /// <param name="hours"> A byte. If hours are greater than 24 a modulo operation is used. </param>
        /// <param name="minutes">A byte. If minutes are greater than 60 a modulo operation is used.</param>
        public Time(byte hours, byte minutes)
        {
          

            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = 0;
        }
        /// <summary>
        /// Constructor with one arguments, 
        /// Creating a specific hours Time object. Seconds and minutes value is 0.
        /// </summary>
        /// <param name="hours"> A byte. If hours are greater than 24 a modulo operation is used. </param>
        public Time(byte hours )
        {
 
            this.hours = (byte)(hours % 24);
            this.minutes = 0;
            this.seconds = 0;
        }



        //public Time(string time)
        //{
        //    string[] splitted = time.Split(':');


        //    this.hours = (byte)(splitted[0]);


        //}

        /// <summary>
        /// Overrided ToString() method that suits to the struct
        /// </summary>
        /// <returns> Return string with format HH:MM:SS</returns>
        public override string ToString()
        {
            
                return $"{hours}:{minutes}:{seconds}";
        }
        /// <summary>
        ///  Method Equals() is overrided
        /// </summary>
        /// <param name="other"></param>
        /// <returns> Returns a bool value whether two Times are equal</returns>
        public bool Equals(Time other)
        {
            return (this.hours == other.hours) && (this.minutes == other.minutes) && (this.seconds == other.seconds);
        }
        /// <summary>
        /// Overrided CompareTo() method
        /// </summary>
        /// <param name="other"></param>
        /// <returns> Returns 1 if object is greater, returns 0 if objects are equal, returns -1 if object is smaller</returns>
        public int CompareTo(Time other)
        {
            if (this.hours > other.hours) return 1;
            else if (this.hours == other.hours && this.minutes > other.minutes) return 1;
            else if (this.hours == other.hours && this.minutes == other.minutes && this.seconds > other.seconds) return 1;
            else if (this.Equals(other)) return 0;
            else return -1;
        }
        /// <summary>
        /// Overrided + operator
        /// </summary>
        /// <param name="left">First object</param>
        /// <param name="right">Second object</param>
        /// <returns>The sum of two Time objects </returns>
        public static Time operator +(Time left, Time right)
        {
            

            if ((left.hours + right.hours) > 23)
                //throw new ArgumentOutOfRangeException();
                return new Time((byte)(left.hours + right.hours %24), (byte)(left.minutes + right.minutes), (byte)(left.seconds + right.seconds));
            if ((byte)(left.seconds + right.seconds) == 60)
                if ((byte)(left.minutes + right.minutes) == 60)
                 return new Time((byte)(left.hours + right.hours + 1), (byte)(left.minutes + right.minutes + 1), (byte)(left.seconds + right.seconds));
            if ((byte)(left.seconds + right.seconds) == 60)
                return new Time((byte)(left.hours + right.hours ), (byte)(left.minutes + right.minutes + 1), (byte)(left.seconds + right.seconds));

            return new Time((byte)(left.hours + right.hours), (byte)(left.minutes + right.minutes), (byte)(left.seconds + right.seconds));
            //return new Time((byte)(left.hours + right.hours), (byte)(left.minutes + right.minutes), (byte)(left.seconds + right.seconds));

        }
        /// <summary>
        /// Overrided - operator
        /// </summary>
        /// <param name="left">First object</param>
        /// <param name="right">Second object</param>
        /// <returns>The difference between two Time objects</returns>
        public static Time operator -(Time left, Time right)
        {


            if ((left.hours - right.hours) < 0)
                //throw new ArgumentOutOfRangeException();
                return new Time((byte)((left.hours - right.hours + 24) % 24 ), (byte)(left.minutes - right.minutes), (byte)(left.seconds - right.seconds));
            if ((left.minutes - right.minutes) < 0 && (left.seconds - right.seconds) < 0)
                return new Time((byte)((left.hours - right.hours  +23) % 24), (byte)((left.minutes - right.minutes + 59 ) % 60), (byte)((left.seconds - right.seconds + 60) % 60));
            if ((left.minutes - right.minutes) < 0)
                return new Time((byte)((left.hours - right.hours +23) % 24), (byte)((left.minutes - right.minutes + 60) % 60), (byte)(left.seconds - right.seconds));
            if ((left.seconds - right.seconds) < 0)
                return new Time((byte)(left.hours - right.hours % 24), (byte)((left.minutes - right.minutes -1) % 60 ), (byte)((left.seconds - right.seconds+60) % 60));
            //if ((byte)(left.seconds + right.seconds) == 60)
            //    return new Time((byte)(left.hours + right.hours), (byte)(left.minutes + right.minutes + 1), (byte)(left.seconds + right.seconds));


            return new Time((byte)(left.hours - right.hours), (byte)(left.minutes - right.minutes), (byte)(left.seconds - right.seconds));

        }

        
        /// <summary>
        /// Method used to add TimePeriod object to Time object.
        /// </summary>
        /// <param name="other">TimePeriod object</param>
        /// <returns>Time object that is sum of Time object and TimePeriod object</returns>
        public Time Plus(TimePeriod other)
        {
            return new Time((byte)(hours + other.hours), (byte)(minutes + other.minutes), (byte)(seconds + other.seconds));
        }
        /// <summary>
        /// Static method used to add TimePeriod object to Time object.
        /// </summary>
        /// <param name="time">Time object</param>
        /// <param name="other">TimePeriod object</param>
        /// <returns>Time object that is sum of Time object and TimePeriod object</returns>
        public static Time Plus(Time time,TimePeriod other)
        {
            return new Time((byte)(time.hours + other.hours), (byte)(time.minutes + other.minutes), (byte)(time.seconds + other.seconds));
        }
        /// <summary>
        /// Overrided == operator
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether two Times are equal</returns>
        public static bool operator ==(Time left, Time right)
        {
            return left.Equals(right);
        }
        /// <summary>
        /// Overrided != operator
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether two Times are not equal</returns>
        public static bool operator !=(Time left, Time right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Overrided > operator
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is greater than second one</returns>
        public static bool operator >(Time left, Time right)
        {
            if (left.CompareTo(right) == 1)
                return true;
            if (left.CompareTo(right) == -1)
                return false;
            return false;
        }
        /// <summary>
        /// Overrided smaller operator
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is smaller than second one</returns>
        public static bool operator <(Time left, Time right)
        {
            if (left.CompareTo(right) == 1)
                return false;
            if (left.CompareTo(right) == -1)
                return true;
            return false;
        }
        /// <summary>
        /// Overrided >= operator
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is greater or equal to second one</returns>
        public static bool operator >=(Time left, Time right)
        {
            if (left.CompareTo(right) == 1 || left.CompareTo(right) == 0)
                return true;
            if (left.CompareTo(right) == -1)
                return false;
            return false;
        }
        /// <summary>
        /// Overrided Smaller or Equal operator 
        /// </summary>
        /// <param name="left">First time object</param>
        /// <param name="right">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is smaller or equal to second one</returns>
        public static bool operator <=(Time left, Time right)
        {
            if (left.CompareTo(right) == -1 || left.CompareTo(right) == 0)
                return true;
            if (left.CompareTo(right) == 1)
                return false;
            return false;
        }

    }
}