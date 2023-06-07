using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad07_04
{
    //định nghĩa lớp custom ngoại lệ chỉ cho nhập số nguyên dương
    public class InvalidInputNumber : Exception
    {
        public InvalidInputNumber():base("Hay nhap 1 so >0") { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap 1 so :");
            //nhập và tung ngoại lệ
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    //in ra dãy số *100
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}
