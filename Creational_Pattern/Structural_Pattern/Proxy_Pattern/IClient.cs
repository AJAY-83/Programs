using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Proxy_Pattern
{
   public interface IClient
    {
        /// <summary>
        /// GetData as function.
        /// </summary>
        /// <returns>return string</returns>
        string GetData();
    }
}
