using System;
using System.Collections.Generic;
using System.Text;
using Logger.Layouts.Contracts;
using Logger.Layouts.Factory.Contracts;

namespace Logger.Layouts.Factory
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            var typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid Layout Type!");
            }
        }
    }
}
