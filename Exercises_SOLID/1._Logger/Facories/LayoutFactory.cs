using _1._Logger.Interfaces;
using _1._Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Logger.Facories
{
    static class LayoutFactory
    {
        public static ILayout InitializeLayout(string type)
        {
            string _type = type.ToLower();

            switch (_type)
            {
                case "simplelayout":
                    return new SimpleLayout();

                case "xmllayout":
                    return new XmlLayout();

                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}
