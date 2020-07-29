using System;
using System.Collections.Generic;

namespace leetCode_roman_to_ineger
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = Console.ReadLine();
            Console.WriteLine(RomanToInt(roman));
            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            int ans = 0;
            if(s.Contains("IV")){
                s = s.Replace("IV","");
                ans += 4;
            }
    
            if(s.Contains("IX")){
                s = s.Replace("IX","");
                ans += 9;
            }
    
            if(s.Contains("XL")){
                s = s.Replace("XL","");
                ans += 40;
            }
            if(s.Contains("XC")){
                s = s.Replace("XC","");
                ans += 90;
            }
    
            if(s.Contains("CD")){
                s = s.Replace("CD","");
                ans += 400;
            }
    
            if(s.Contains("CM")){
                s = s.Replace("CM","");
                ans += 900;
            }
    

            

            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            
            for (int i = 0; i < s.Length; i++)
            {
                ans+= map[s[i]];
            }


            return ans;
        }
    }
}