using System;

namespace assignment2
{
    class Math
    {
        
        {
            /* Values of X
            type variablename = value; */
            // ax^2 + 11x - 35 = 0
            // x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
            public static void
            SolveQuadratic(double a, double b, double c)
            {
                double sqrtpart = b * b - 4 * a * c;
                double x, x1, x2, img;
                if (sqrtpart > 0)
                {
                    x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                    x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                    Console.WriteLine("Two Real Solutions: {0,8:f4} or {1,8:f4}", x1, x2); 
                }
                else if (sqrtpart < 0)
                {
                    sqrtpart = -sqrtpart;
                    x = -b / (2 * a);
                    lmg = System.Math.Sqrt(sqrtpart) / (2 * a);
                    Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);

                }
                else
                {
                    x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                    Console.WriteLine("One Real Solution: {0,8:f4}", x); 

                }
            }
             
             static void Main(string[] args)
             {
                 int a = 6, b = 11, c = -35;
                 // 6x^2 + 11x - 35 =0
                 SolveQuadratic(6, 11, -35);

                 // convert Fahrenheit to Celsius 

                 int main()
                 {
                     float fahrenheit, Celsius;

                     // get the limit of fibonacci series
                     printf("Enter Fahrenheit: \n");
                     scanf("%f", &fahrenheit);

                     celsius = (fahrenheit - 32) * 5 / 9;
                     
                     printf("Celsius: %f \n", celsius);
                     return 0;
                 }

                 // Determine if a user input is palindrome.
                 /* What is a palindrome?
                 Palindrome is a word, phrase or sequence that reads the same backwards as forwards. For example 'madam*/

                 int main()
                 {
                     char str[100], revstr[100];
                     int i, j, len, flag;
                     flag = 0;

                     printf("\n Please Enter any string : ");
                     gets(str);
                     len = strlen(str);
                     j = 0

                     for(i=len - 1; i >= 0; i--)
                     {
                         revstr[j++] = str[i];
                     }
                     revstr[i] = '\0';

                     for(i=0; i < len; i++)
                     {
                         if(str[i] != revstr[i])
                         {
                             flag = 1;
                             break;
                         }
                     }
                     if(flag == 0)
                     {
                         printf("\n %s is a Palindrome String", str); //printf is for C and not C#
                     }
                     else 
                     {
                         printf("\n %s is Not a Palindrome String", str);
                     }
                     return 0;
                 }
        }
    }
}
