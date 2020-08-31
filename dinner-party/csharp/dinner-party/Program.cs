using System;
using System.Collections.Generic;
using System.Linq;

namespace dinner_party {
    class Program {

        static void Main (string[] args) {
            Console.Clear ();
            setTheTable ();
        }
        static void setTheTable () {

            List<DinnerGuest> table1 = new List<DinnerGuest> ();
            List<DinnerGuest> table2 = new List<DinnerGuest> ();



            List<DinnerGuest> attendingTonight = new List<DinnerGuest> () {
                new DinnerGuest () {
                        name = "Marilyn Monroe",
                            occupation = "entertainer",
                            bio = "(1926 - 1962) American actress, singer, model"
                    },
                    new DinnerGuest () {
                        name = "Abraham Lincoln",
                            occupation = "politician",
                            bio = "(1809 - 1865) US President during American civil war"
                    },
                    new DinnerGuest () {
                        name = "Martin Luther King",
                            occupation = "activist",
                            bio = "(1929 - 1968)  American civil rights campaigner"
                    },
                    new DinnerGuest () {
                        name = "Rosa Parks",
                            occupation = "activist",
                            bio = "(1913 - 2005)  American civil rights activist"
                    },
                    new DinnerGuest () {
                        name = "Peter Sellers",
                            occupation = "entertainer",
                            bio = "(1925 - 1980) British actor and comedian"
                    },
                    new DinnerGuest () {
                        name = "Alan Turing",
                            occupation = "computer scientist",
                            bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                    },
                    new DinnerGuest () {
                        name = "Admiral Grace Hopper (1906–1992) – developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
                            occupation = "computer scientist",
                            bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                    },
                    new DinnerGuest () {
                        name = "Indira Gandhi",
                            occupation = "politician",
                            bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                    }
            };

            foreach (var guest in attendingTonight) {
                List<string> table1Occupations = table1.Select (seated => seated.occupation).ToList ();
                if (table1Occupations.Contains (guest.occupation)) {
                    table2.Add (guest);
                } else {
                    table1.Add (guest);
                }
            };

            Console.WriteLine ("Table 1");
            foreach (var guest in table1) {
                Console.WriteLine ($"{guest.name} (${guest.occupation}) ${guest.bio}");
            }
            Console.WriteLine ("Table 2");
            foreach (var guest in table2) {
                Console.WriteLine ($"{guest.name} (${guest.occupation}) ${guest.bio}");
            }

        }
    }
}