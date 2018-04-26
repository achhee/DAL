// ***********************************************************************
// Assembly         : WD.DataAccess
// Author           : Asim_n
// Created          : 03-14-2017
//
// Last Modified By : Asim_n
// Last Modified On : 04-28-2017
// ***********************************************************************
// <copyright file="Database.cs" company="Western Digital">
//     Copyright © Western Digital 2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;



// namespace: WD.DataAccess.Enums
//
// summary:	.


namespace WD.DataAccess.Enums
{
    
    /// <summary>   A databases. </summary>
    ///
    /// <remarks>   Asim Naeem, 7/20/2017. </remarks>
    

    public class Databases
    {
       
       /// <summary>    Default constructor. </summary>
       ///
       /// <remarks>    Asim Naeem, 7/20/2017. </remarks>
       

       public Databases() { }
       /// <summary>    The BR flag. </summary>
       public const int BR = 1;
       /// <summary>    The TX flag. </summary>
       public const int TX = 2;
    }
}
