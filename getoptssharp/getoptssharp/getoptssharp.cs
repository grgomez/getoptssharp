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
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getoptssharp
{
    public class getoptssharp
    {

        private static string _flag = string.Empty;
        private static string _value = string.Empty;
        private static string _arg = string.Empty;
        private static int _index = 0;
        private static int _opts_num = 0;
        private const string opts_pattern = @"\S:?";
        // TODO
        private const string args_pattern = @"";

        
        public static string flag
        {
            get { return _flag; }
        }

        public static string value
        {
            get { return _value; }
        }

        public static string arg
        {
            get { return _arg; }
        }     

          
        /// <summary>
        /// parse the arguments provided based on the options in the form of "abc:"
        /// where a and b are switches, and c is a flag with a value.
        /// </summary>
        /// <param name="args">String of arguments</param>
        /// <param name="options">String of options in the form of "abc:d:e"</param>
        public static bool getopts(string[] args, string opts)
        {

            if (args.Length == 0 || string.IsNullOrEmpty(opts))
            {
                // There must be arguments and options
                return false;
            }

            // TODO:
            // 2. In case of error during parsing use a special
            //  value to let user know something went wrong 
            //  avoiding throwing errors and things
            //  and the user can check an internal variable 
            //  to determine what went wrong.
            // 3. Create an overloaded getopts that supports long options 
            // In the form of --help, --blah in a list and will be matched 
            // to the opts variable by order.
            Regex rgx = new Regex(opts_pattern, RegexOptions.IgnoreCase);
            MatchCollection opts_matches = rgx.Matches(opts);
            _opts_num = opts_matches.Count;

            if (_opts_num > 0 && _index < args.Length)
            {
                string arg = args[_index++];

                foreach (Match match in opts_matches)
                {
                    // the delimeter ':' is absolute, but add flag delimeter private variable 
                    // to modify '-' to any other character (e.g.: '/')
                    if (match.Value.TrimEnd(':') == arg.TrimStart('-'))
                    {
                        _flag = arg;
                        break;
                    } 
                }
            }
            else
            {
                // No matches, return false
                return false;
            }

            return true;
        }

    }
}
