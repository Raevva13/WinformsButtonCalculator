using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsButtonCalculator.DataHolder;

namespace WinformsButtonCalculator
{
    public class OperationModul
    {
        /// <summary>
        /// Singleton
        /// </summary>
        private static readonly object lockObject = new object();
        private static OperationModul _instance;

        private OperationModul()
        { }


        public static OperationModul Instance
        {
            get
            {
                lock (lockObject)
                {
                    return _instance ??
                        (_instance = new OperationModul());
                }
            }
        }



        /// <summary>
        /// Count
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public ResultHolder Sum(double a, double b)
        {
            ResultHolder holder = new ResultHolder
            { Result = a + b };

            holder.ResultString = $"{a} + {b} = {holder.Result}";

            return holder;

        }


        /// <summary>resu
        /// Minus method with input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Substring(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a - b }; //result
            holder.ResultString = $"{a} - {b} = {holder.Result}"; //result string with calculation

            return holder;
        }




        /// <summary>
        /// Multiply method with input "a","b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Multiply(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a * b }; //result
            holder.ResultString = $"{a} * {b} = {holder.Result}"; //result string with calculation

            return holder;
        }




        /// <summary>
        /// Divided method with input "a", "b" and output Result and ResultString
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result, ResultString</returns>
        public ResultHolder Divided(double a, double b)
        {
            ResultHolder holder = new ResultHolder { Result = a / b }; //result
            holder.ResultString = $"{a} ÷ {b} = {holder.Result}"; //result string with calculation

            return holder;
        }

    }
}

