#region Imports

using System;

#endregion Imports

namespace CodingForTheLongHaul
{
    public class SmallRegions
    {
        #region Private Members

        private readonly string _message;

        #endregion Private Members

        #region Constructors

        public SmallRegions(string message)
        {
            _message = message;
        }

        #endregion Constructors

        #region Public Methods

        public string GetMessage(string name)
        {
            return $"{Filter(name)} says {_message}";
        }

        #endregion Public Methods

        #region Private Methods

        private string Filter(string name)
        {
            return name == "Derek" ? $"{name} The {new Random().Next(4, 9)}th" : name;
        }

        #endregion Private Methods
    }
}
