using System;
using System.Collections.Generic;

namespace dinner_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guestList = new List<Guest>();


            Guest marilynMonroe = new Guest();
            marilynMonroe.AddName("Marilyn Monroe");
            marilynMonroe.AddOccupation("entertainer");
            marilynMonroe.AddOccupation("(1926 - 1962) American actress, singer, model");
            guestList.Add(marilynMonroe);


            Guest abrahamLincoln = new Guest();
            abrahamLincoln.AddName("Abraham Lincoln");
            abrahamLincoln.AddOccupation("politician");
            abrahamLincoln.AddBio("(1809 - 1865) US President during American civil war");
            guestList.Add(abrahamLincoln);

            Guest martinLutherKing = new Guest();
            martinLutherKing.AddName("Martin Luther King");
            martinLutherKing.AddOccupation("activist");
            martinLutherKing.AddBio("(1929 - 1968)  American civil rights campaigner");
            guestList.Add(martinLutherKing);

            Guest roseParks = new Guest();
            roseParks.AddName("Rose Parks");
            roseParks.AddOccupation("activist");
            roseParks.AddBio("(1913 - 2005)  American civil rights activist");
            guestList.Add(roseParks);

            Guest peterSellers = new Guest();
            peterSellers.AddName("Peter Sellers");
            peterSellers.AddOccupation("entertainer");
            peterSellers.AddBio("(1925 - 1980) British actor and comedian");
            guestList.Add(peterSellers);

            Guest alanTuring = new Guest();
            alanTuring.AddName("Alan Turing");
            alanTuring.AddOccupation("computer scientist");
            alanTuring.AddBio("(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
            guestList.Add(alanTuring);

            Guest admiralGraceHopper = new Guest();
            admiralGraceHopper.AddName("Admiral Grace Hopper");
            admiralGraceHopper.AddOccupation("computer scientist");
            admiralGraceHopper.AddBio("(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");
            guestList.Add(admiralGraceHopper);

            Guest indiraGandhi = new Guest();
            indiraGandhi.AddName("Indira Gandhi");
            indiraGandhi.AddOccupation("politician");
            indiraGandhi.AddBio("(1917 - 1984) Prime Minister of India 1966 - 1977");
            guestList.Add(indiraGandhi);

            Table allTables = new Table();

            foreach (Guest guest in guestList)
            {
                if (!allTables.Table1.Contains(guest))
                {
                    allTables.Table1.Add(guest);
                }
                else
                {
                    allTables.Table2.Add(guest);
                }
            }



        }
    }
}
