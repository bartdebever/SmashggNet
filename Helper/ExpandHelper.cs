using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmashggHandler.Exceptions;
using SmashggHandler.Models;

namespace SmashggHandler.Helper
{
    public static class ExpandHelper
    {
        public static string GetExpandStringFromCollection(ICollection<Expand> expands)
        {
            if (!expands.Any())
                return null;

            var stringBuilder = new StringBuilder("?");
            foreach (var expand in expands)
            {
                stringBuilder.Append($"{GetStringFromExpand(expand)}&");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1); //Removes the last & sign at the end.

            return stringBuilder.ToString();
        }

        private static string GetStringFromExpand(Expand expand)
        {
            switch (expand)
            {
                case Expand.Event:
                    return "expand=[]=event";
            }
            throw new ExpandNotFoundException();
        }
    }
}
