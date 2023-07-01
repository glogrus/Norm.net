﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Norm.Mapper;

namespace Norm
{
    public partial class Norm
    {
        ///<summary>
        ///Maps command results to enumerator of new instance values.
        ///</summary>
        ///<param name="bluePrintInstance">Instance used as blueprint to create new instances of same instance types</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Database parameters object (anonymous object or SqlParameter array).</param>
        ///<returns>IEnumerable enumerator of single values of type T.</returns>
        public virtual IEnumerable<T> Read<T>(T bluePrintInstance, string command,
            object parameters = null,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            where T : class
        {
            if (parameters != null)
            {
                this.WithParameters(parameters);
            }
            this.memberName = memberName;
            this.sourceFilePath = sourceFilePath;
            this.sourceLineNumber = sourceLineNumber;
            return ReadToArrayInternal(command).MapInstance<T>(bluePrintInstance.GetType());
        }

        ///<summary>
        ///Maps command results to enumerator of new instance values.
        ///</summary>
        ///<param name="bluePrintInstance">Instance used as blueprint to create new instances of same instance types</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Database parameters object (anonymous object or SqlParameter array).</param>
        ///<returns>IEnumerable enumerator of single values of type T.</returns>
        public virtual IEnumerable<T> ReadFormat<T>(T bluePrintInstance, FormattableString command,
            object parameters = null,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            where T : class
        {
            if (parameters != null)
            {
                this.WithParameters(parameters);
            }
            this.memberName = memberName;
            this.sourceFilePath = sourceFilePath;
            this.sourceLineNumber = sourceLineNumber;
            return ReadToArrayInternal(command).MapInstance<T>(bluePrintInstance.GetType());
        }
    }
}