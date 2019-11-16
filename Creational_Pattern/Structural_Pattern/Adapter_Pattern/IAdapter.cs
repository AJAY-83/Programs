using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Adapter_Pattern
{
   public interface IAdapter
    {
        /// <summary>
        /// GetProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        List<string> GetProductDetails();
    }
}
