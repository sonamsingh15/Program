using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class CouponNumber
    {
        public void coupan() {

            Console.WriteLine("Enter the number of coupons that you want to generate");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length that you want");
            int length = Convert.ToInt32(Console.ReadLine());

            string nums = "0123456789";
            char[] charArray = nums.ToCharArray();
            HashSet<string> hashSet = new HashSet<string>();
            string str = "";
            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                    char c = nums[random.Next(charArray.Length)];
                    str = str + c;
                    hashSet.Add(str);
                }

                Console.WriteLine("Coupon numbers are: " + str);
            }

        }
    }
    

