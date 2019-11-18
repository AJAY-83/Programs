// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ServerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class ServerFactory
    {
            /// <summary>
            /// GetFactory as function.
            /// </summary>
            /// <param name="company">company as parameter.</param>
            /// <returns>return string.</returns>
            public abstract IFactory GetFactory(string company);
        }
    }