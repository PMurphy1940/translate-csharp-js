using System;
using System.Collections.Generic;

namespace Wish_List
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("My wishes...");
            List<Wish> wishes = GetWishes();

            foreach (Wish thisWish in wishes)
            {
                Console.WriteLine($"{thisWish.wish}");
            }
        }

        public static List<Wish> GetWishes()
        {
            List<Wish> wishes = new List<Wish> {
                new Wish {
                    wish = "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'"
                },
                new Wish {
                    wish = "The ability to think of interesting wishes on short notice"
                },
                new Wish {
                   wish = "A washtub of Skittles"
                },
                new Wish {
                    wish = "World peace, but not the kind of world peace where all the humans are removed from existence"
                },
                new Wish {
                    wish ="A TV that is NOT internet-capable"
                },
                new Wish {
                    wish = "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
                }
            };
            return wishes;
        }
    }
    public class Wish{
        public string wish { get; set; }
    }
}
