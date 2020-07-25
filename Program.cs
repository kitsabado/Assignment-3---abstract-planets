using System;

namespace Assignment_3
{
    /****************************************************************************************************
     * Author               : Kristopher G. Sabado
     * 
     * Studen Number        : 301118188
     * 
     * Date Last Modified   : July 23, 2020
     * 
     * Program Description  : This program simulates a lotto game in
     * which the player will be able to select a lotto game then the
     * program will be able to generate lottery tickets with random
     * numbers inside
     * 
     * Revision History     : 
     * 
     * Date         Author          Revision
     * 2020-07-23   kitsabado       Initial commit to add default .gitIgnore and .gitAttribute files.
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     ***************************************************************************************************/

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("******GIANT PLANET******");
            Console.Write("------------------------");
            Console.WriteLine("\nPLANET INFORMATION");

            //instantiate giant planet object
            GiantPlanet giantPlanet = new GiantPlanet("Giant Planet A", 45, 283.33, "Ice"); 

            //show output
            Console.WriteLine($"{giantPlanet.ToString()}\n");

            Console.WriteLine("\n******TERRESTRIAL PLANET******");
            Console.Write("-------------------------------");
            Console.WriteLine("\nPLANET INFORMATION");
            //instantiate terrestrial planet object
            TerrestrialPlanet terrestrial = new TerrestrialPlanet("Terrestrial Planet A", 10.5, 55.5, false); 

            //show output
            Console.WriteLine($"{terrestrial.ToString()}");




            Console.ReadKey();
        }

    }
}
