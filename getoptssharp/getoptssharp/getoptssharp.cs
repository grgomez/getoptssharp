/*
 * Library getoptssharp
 * @author: German Gomez Urbina
 * @e-mail: grgomezu@gmail.com
 * 
 * Small library to parse command line arguments C-style.
 * 
 * This program will 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getoptssharp
{
    public class getoptssharp
    {
        public struct option
        {
            string flag;
            string value;
        }

        public static option opt;
        public static string arg;

        private static int index = 0;
        private const string opts_pattern = @"\S:?";
        // TODO
        private const string args_pattern = @"";
        

          
        /// <summary>
        /// parse the arguments provided based on the options in the form of "abc:"
        /// where a and b are switches, and c is a flag with a value.
        /// </summary>
        /// <param name="args">String of arguments</param>
        /// <param name="options">String of options in the form of "abc:d:e"</param>
        public bool getopts(string args, string opts)
        {

            if (string.IsNullOrEmpty(args) || string.IsNullOrEmpty(options))
            {
                // There must be arguments and options
                return false;
            }

            // TODO:
            // 1. Regex each option


            return true;
        }

    }
}
