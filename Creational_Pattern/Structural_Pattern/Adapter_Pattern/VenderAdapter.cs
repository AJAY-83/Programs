using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Adapter_Pattern
{
    public class VenderAdapter: IAdapter
    {
        /// <summary>
        /// Use List as generic collection of GetProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        public List<string> GetProductDetails()
        {
            //// Create Instance of an AdapterClass classs
            Adapter adapter = new Adapter();
            return adapter.ListOfProductDetails();
        }
    }
}
