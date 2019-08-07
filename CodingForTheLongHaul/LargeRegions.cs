#region Imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Dynamic;
using System.Drawing;
using System.Data.Common;
using System.Threading;
using System.Timers;






/* And 20 other references that are no longer being used */









#endregion Imports

namespace CodingForTheLongHaul
{
    public class LargeRegions
    {
        #region Private Members

        private readonly string _argument1;
        private readonly string _argument2;
        private readonly string _argument3;
        private readonly string _argument4;
        private readonly string _argument5;
        private readonly string _argument6;
        private readonly string _argument7;
        private readonly string _argument8;
        private readonly string _argument9;
        private readonly string _argument10;
        private readonly string _argument11;
        private readonly string _argument12;
        private readonly string _argument13;
        private readonly string _argument14;
        private readonly string _argument15;
        private readonly string _argument16;

        #endregion Private Members

        #region Constructors

        public LargeRegions()
        {

        }

        public LargeRegions(string argument1, string argument2, string argument3, string argument4, string argument5)
        {
            _argument1 = argument1;
            _argument2 = argument2;
            _argument3 = argument3;
            _argument4 = argument4;
            _argument5 = argument5;
        }

        public LargeRegions(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6,
                            string argument7, string argument8, string argument9, string argument10, string argument11)
        {
            _argument1 = argument1;
            _argument2 = argument2;
            _argument3 = argument3;
            _argument4 = argument4;
            _argument5 = argument5;
            _argument6 = argument6;
            _argument7 = argument7;
            _argument8 = argument8;
            _argument9 = argument9;
            _argument10 = argument10;
            _argument11 = argument11;
        }

        public LargeRegions(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6,
                            string argument7, string argument8, string argument9, string argument10, string argument11, string argument12,
                            string argument13, string argument14, string argument15, string argument16)
        {
            _argument1 = argument1;
            _argument2 = argument2;
            _argument3 = argument3;
            _argument4 = argument4;
            _argument5 = argument5;
            _argument6 = argument6;
            _argument7 = argument7;
            _argument8 = argument8;
            _argument9 = argument9;
            _argument10 = argument10;
            _argument11 = argument11;
            _argument12 = argument12;
            _argument13 = argument13;
            _argument14 = argument14;
            _argument15 = argument15;
            _argument16 = argument16;
        }

        #endregion Constructors

        #region Public Methods

        public string GiveMeTwoSums(int x1, int y1, int x2, int y2)
        {
            var total1 = AddTwoNumbers(x1, y1);
            var total2 = AddTwoNumbers(x2, y2);
            var result = Concat(total1.ToString(), total2.ToString());

            return result;
        }

        public IList<string> PutThemTogetherInOrder()
        {
            var result = PutThemTogether();
            result = result.OrderBy(s => s).ToList();
            return result;
        }

        public int GetMeARandomNumber(int low, int high)
        {
            var random = new Random();
            return random.Next(low, high);
        }

        public void WhoWroteThisAwesomeMethod()
        {













































































            /* Best logic ever! */
















































































































































































































        }

        #endregion Public Methods

        #region Private Methods

        public string GetArgument1()
        {
            return _argument1;
        }

        private IList<string> PutThemTogether()
        {
            var result = new List<string>();
            result.Add(_argument1);
            result.Add(_argument2);
            result.Add(_argument3);
            result.Add(_argument4);
            result.Add(_argument5);
            result.Add(_argument6);
            result.Add(_argument7);
            result.Add(_argument8);
            result.Add(_argument9);
            result.Add(_argument10);

            return result;
        }

        private int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        private string Concat(string a, string b)
        {
            return $"{a} {b}";
        }

        private double SomeOtherMethod()
        {
            return 0;
        }

        private void JustMakingWhitespace()
        {























































































































            /* There is usually a lot of good stuff in here */


































































































































        }

        #endregion Private Methods
    }
}
