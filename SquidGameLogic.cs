using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SquidGameLogic
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int ourPlayer = random.Next(500)+1;
            List<int> allPlayers = new List<int>();
            List<int> takeDeadPlayers = new List<int>();
            int count = 0;
            bool isOurPlayerDead = false;

            for(int i=0; i < 500; i++)
            {
                allPlayers.Add(i+1);
            }


            int howManyDead = random.Next(500)+100;


            ///// 1.Competition /////

            for (int i=0; i < allPlayers.Count; i++)
            {
                int values = random.Next(500) +1;
                count++;

                if(count != howManyDead)
                {
                    for (int j = 0; j < allPlayers.Count; j++)
                    {
                        if (allPlayers[j] == values)
                        {
                            allPlayers.RemoveAt(j);
                        }

                        if(values == ourPlayer)
                        {
                            isOurPlayerDead = true;
                        }
                    }

                }

            }

            count = 0;

            /// 2. Competition ////

            howManyDead = random.Next(allPlayers.Count);

            for (int i=0; i < allPlayers.Count; i++)
            {
                int values = random.Next(allPlayers.Count) + 1;
                count++;
                if(count != howManyDead)
                {
                    for(int j=0; j < allPlayers.Count; j++)
                    {
                        if(values == allPlayers[j])
                        {
                            allPlayers.RemoveAt(j);
                        }

                        if (values == ourPlayer)
                        {
                            isOurPlayerDead = true;
                        }
                    }
                }
            }

            /// 3. Competition /// 
            count = 0;
            
           for(int i=0; i < allPlayers.Count; i++)
            {
                int values = random.Next(allPlayers.Count) + 1;

                if (values == ourPlayer)
                {
                    isOurPlayerDead = true;
                }

                if (allPlayers[i] == values)
                {
                    allPlayers.RemoveAt(i);

                }
                else
                {
                    int values2 = random.Next(allPlayers.Count) + 0;
                    allPlayers.RemoveAt(values2);
                }

            }

            /// 4.Competition //// 


            for (int i=0; i < allPlayers.Count * 10; i++)
            {
                int values2 = random.Next(allPlayers.Count) + 0;
                if (values2 == ourPlayer)
                {
                    isOurPlayerDead = true;
                }
                allPlayers.RemoveAt(values2);
            }

            // LAST Competition ///

            while (allPlayers.Count != 1)
            {
                 
                int values2 = random.Next(allPlayers.Count) + 0;
                if (values2 == ourPlayer)
                {
                    isOurPlayerDead = true;
                }
                allPlayers.RemoveAt(values2);
            }

            if (isOurPlayerDead)
            {
                Console.WriteLine(ourPlayer + " is dead.");
              
            }
            else
            {
                Console.WriteLine(ourPlayer + " is win.");
            }
            
            
            Console.WriteLine(allPlayers.Count + " Winner is: "+ allPlayers[0]);
            
        }
    }
}
