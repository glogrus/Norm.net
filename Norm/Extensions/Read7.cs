﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Norm
{
    public static partial class NormExtensions
    {
        ///<summary>
        ///Maps command results to enumerator of seven value tuples (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Database parameters object (anonymous object or SqlParameter array).</param>
        ///<returns>IEnumerable enumerator of seven value tuples (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> Read<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command,
            object parameters = null,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        {
            return connection.Instance<Norm>().Read<T1, T2, T3, T4, T5, T6, T7>(command, parameters, memberName, sourceFilePath, sourceLineNumber);
        }

        ///<summary>
        ///Parse interpolated (formattable) command as database parameters and map command results to enumerator of seven value tuples (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Database parameters object (anonymous object or SqlParameter array).</param>
        ///<returns>IEnumerable enumerator of seven value tuples (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadFormat<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, 
            FormattableString command,
            object parameters = null,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        {
            return connection.Instance<Norm>().ReadFormat<T1, T2, T3, T4, T5, T6, T7>(command, parameters, memberName, sourceFilePath, sourceLineNumber);
        }
    }
}