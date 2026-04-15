using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace ExercismApp
{
    public class RunEncoding
    {
        public static string Encode(string input)
        {
            StringBuilder encoded = new StringBuilder();
            int count = 0;

            for(int index = 0; index < input.Length-1 ; index++)
            {
                if( input[index] == input[index+1])
                {
                    count = count + 1;
                    if(index == input.Length-2)
                    {
                        encoded.Append(count+1).Append(input[index]);
                    }
                }
                else
                {
                    if(count == 0)
                        encoded.Append(input[index]); 
                    else 
                        encoded.Append(count+1).Append(input[index]);
                    count = 0;
                }
            }
            if(count == 0)
            {
                encoded.Append(input[input.Length-1]); 
            }
            return encoded.ToString();
        }
    
        public static string Decode(string input)
        {
            StringBuilder decoded = new StringBuilder();
            int index = 0; 
            while(index < input.Length)
            {
                if(Char.IsDigit(input[index]) )
                {
                    int number;
                    int finalNumber = 0;
                    char letter = '\0';
                    int innerLoopLastCounter = 0;

                    for(int i = index; i < input.Length; i++)
                    {
                        int.TryParse(input[i].ToString(), out number);
                        if(Char.IsDigit(input[i]))
                            finalNumber = finalNumber*10 + number;
                        else
                        {
                            char.TryParse(input[i].ToString(), out char result);
                            letter = result;
                            innerLoopLastCounter = i;
                            break;
                        }
                    }
                    index = innerLoopLastCounter+1;
                    decoded.Append(new string(letter,finalNumber));
                }
                else
                {
                    decoded.Append(input[index]);
                    index = index + 1;
                }
            }
            return decoded.ToString();
        }
    }
}