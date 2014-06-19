namespace ExceptionProject
{
    using System;

    public class InvalidRangeExeption<T> : ApplicationException
    {
        public InvalidRangeExeption(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public T Min { get; set; }
        public T Max { get; set; }

        public override string Message
        {
            get
            {
                string result = string.Format("The value is out of the range [{0}:{1}]", this.Min, this.Max);
                return result;
            }
        }
    } 
}
