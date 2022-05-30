﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Norm
{
    public partial class Norm
    {
        ///<summary>
        /// Maps command results to async enumerator of single values of type T.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<returns>IAsyncEnumerable async enumerator of single values of type T.</returns>
        public IAsyncEnumerable<T> ReadAsync<T>(string command,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        {
            this.memberName = memberName;
            this.sourceFilePath = sourceFilePath;
            this.sourceLineNumber = sourceLineNumber;
            var t1 = TypeCache<T>.GetMetadata();
            if (t1.valueTuple)
            {
                return ReadToArrayInternalAsync(command).MapValueTuple<T>(t1.type);
            }

            if (this.readerCallback == null)
            {
                if (!t1.simple)
                {
                    return ReadToArrayInternalAsync(command).Map<T>(t1.type);
                }
                return ReadInternalAsync(command, async r => await GetFieldValueAsync<T>(r, 0, t1.type));
            }

            if (!t1.simple)
            {
                return ReadToArrayWithCallbackInternalAsync(command).Map<T>(t1.type);
            }

            return ReadInternalAsync(command, async r => await GetFieldValueWithReaderCallbackAsync<T>(r, 0, t1.type));
        }

        ///<summary>
        /// Parse interpolated (formattable) command as database parameters and map command results to async enumerator of single values of type T.
        ///</summary>
        ///<param name="command">SQL command text as interpolated (formattable) string.</param>
        ///<returns>IAsyncEnumerable async enumerator of single values of type T.</returns>
        public IAsyncEnumerable<T> ReadFormatAsync<T>(FormattableString command,
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        {
            this.memberName = memberName;
            this.sourceFilePath = sourceFilePath;
            this.sourceLineNumber = sourceLineNumber;
            var t1 = TypeCache<T>.GetMetadata();

            if (t1.valueTuple)
            {
                return ReadToArrayInternalAsync(command).MapValueTuple<T>(t1.type);
            }

            if (this.readerCallback == null)
            {
                if (!t1.simple)
                {
                    return ReadToArrayInternalAsync(command).Map<T>(t1.type);
                }
                return ReadInternalAsync(command, async r => await GetFieldValueAsync<T>(r, 0, t1.type));
            }

            if (!t1.simple)
            {
                return ReadToArrayWithCallbackInternalAsync(command).Map<T>(t1.type);
            }

            return ReadInternalAsync(command, async r => await GetFieldValueWithReaderCallbackAsync<T>(r, 0, t1.type));
        }
    }
}