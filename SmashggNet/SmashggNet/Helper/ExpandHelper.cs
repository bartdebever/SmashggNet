using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmashggNet.Exceptions;
using SmashggNet.Models;

namespace SmashggNet.Helper
{
    public static class ExpandHelper
    {
        private static string DefaultExpand => "expand[]=";

        /// <summary>
        /// Creates an expand string for the request based on the provided list
        /// </summary>
        /// <param name="expands">The expand collection needing to be made into a string</param>
        /// <returns></returns>
        public static string GetExpandStringFromCollection(ICollection<Expand> expands)
        {
            if (!expands.Any())
                return null;

            var stringBuilder = new StringBuilder("?");
            foreach (var expand in expands)
            {
                GetStringFromExpand(expand, ref stringBuilder);
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1); //Removes the last & sign at the end.

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Adds the expand string to the <see cref="StringBuilder"/> based on the enum provided
        /// </summary>
        /// <param name="expand">The enum needing to be converted to an expand string</param>
        /// <param name="stringBuilder">The string builder we want to expand into</param>
        private static void GetStringFromExpand(Expand expand, ref StringBuilder stringBuilder)
        {
            switch (expand)
            {
                default:
                    throw new ExpandNotFoundException();

                case Expand.Event:
                    stringBuilder.Append($"{DefaultExpand}event&^^");
                    return;

                case Expand.Groups:
                    stringBuilder.Append($"{DefaultExpand}groups&");
                    return;

                case Expand.Phase:
                    stringBuilder.Append($"{DefaultExpand}phase&");
                    return;

                case Expand.Stations:
                    stringBuilder.Append($"{DefaultExpand}stations&");
                    return;
            }
            
        }
    }
}