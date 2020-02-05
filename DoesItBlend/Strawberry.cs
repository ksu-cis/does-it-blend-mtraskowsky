using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing a Strawberry
    /// </summary>
    public class Strawberry : Fruit, IBlendable // fruit class already inherits iblendable so you don't have to add iblendable to this class, but you can 
    {
        /// <summary>
        /// Blends the strawberry
        /// </summary>
        /// <returns>The result of blending a strawberry</returns>
        public string Blend()
        {
            return "Gooey Red Sweetness";
        }
    }
}
