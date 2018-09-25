using System;

namespace SmashggNet.Exceptions
{
    /// <summary>
    /// Used when the expand does not have a string variant yet, in normal use this should never happen.
    /// </summary>
    public class ExpandNotFoundException : Exception
    {
        public ExpandNotFoundException()
        {
        }

        public ExpandNotFoundException(string message) : base(message)
        {
        }
    }
}