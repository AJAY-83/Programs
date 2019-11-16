using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Observer_Pattern
{
   public interface InventoryInterface
    {
        /// <summary>
        /// Update as function
        /// </summary>
        /// <param name="stock">stockClass as object</param>
        void Update(Stock stock);
    }
}
