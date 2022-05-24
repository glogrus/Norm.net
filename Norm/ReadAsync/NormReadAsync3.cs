﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Norm
{
    public partial class Norm
    {
        ///<summary>
        ///     Maps command results to async enumerator of three value tuples (T1, T2, T3).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<returns>IAsyncEnumerable async enumerator of three value tuples (T1, T2, T3).</returns>
        public IAsyncEnumerable<(T1, T2, T3)> ReadAsync<T1, T2, T3>(string command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple)
            {
                return ReadToArrayInternalAsync(command).MapValueTuple<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple)
            {
                return ReadToArrayInternalAsync(command).Map<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            return ReadInternalAsync(command, async r => (
                await GetFieldValueAsync<T1>(r, 0, t1.type),
                await GetFieldValueAsync<T2>(r, 1, t2.type),
                await GetFieldValueAsync<T3>(r, 2, t3.type)));
        }

        ///<summary>
        ///     Maps command results to async enumerator of three value tuples (T1, T2, T3).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="readerCallback">A callback function, that is executed on each read iteration to provide an alternate mapping.</param>
        ///<returns>IAsyncEnumerable async enumerator of three value tuples (T1, T2, T3).</returns>
        public IAsyncEnumerable<(T1, T2, T3)> ReadAsync<T1, T2, T3>(string command,
            Func<(string Name, int Ordinal, DbDataReader Reader), object> readerCallback)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple)
            {
                return ReadToArrayInternalAsync(command, readerCallback).MapValueTuple<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple)
            {
                return ReadToArrayWithSetInternalAsync(command, readerCallback).Map<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            return ReadInternalAsync(command, async r => (
                await GetFieldValueAsync<T1>(r, 0, t1.type, readerCallback),
                await GetFieldValueAsync<T2>(r, 1, t2.type, readerCallback),
                await GetFieldValueAsync<T3>(r, 2, t3.type, readerCallback)));
        }

        ///<summary>
        /// Parse interpolated (formattable) command as database parameters and map command results to async enumerator of three value tuples (T1, T2, T3).
        ///</summary>
        ///<param name="command">SQL command text as interpolated (formattable) string.</param>
        ///<returns>IAsyncEnumerable async enumerator of three value tuples (T1, T2, T3).</returns>
        public IAsyncEnumerable<(T1, T2, T3)> ReadFormatAsync<T1, T2, T3>(FormattableString command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple)
            {
                return ReadToArrayInternalAsync(command).MapValueTuple<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple)
            {
                return ReadToArrayInternalAsync(command).Map<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            return ReadInternalAsync(command, async r => (
                await GetFieldValueAsync<T1>(r, 0, t1.type),
                await GetFieldValueAsync<T2>(r, 1, t2.type),
                await GetFieldValueAsync<T3>(r, 2, t3.type)));
        }

        ///<summary>
        /// Parse interpolated (formattable) command as database parameters and map command results to async enumerator of three value tuples (T1, T2, T3).
        ///</summary>
        ///<param name="command">SQL command text as interpolated (formattable) string.</param>
        ///<param name="readerCallback">A callback function, that is executed on each read iteration to provide an alternate mapping.</param>
        ///<returns>IAsyncEnumerable async enumerator of three value tuples (T1, T2, T3).</returns>
        public IAsyncEnumerable<(T1, T2, T3)> ReadFormatAsync<T1, T2, T3>(FormattableString command,
            Func<(string Name, int Ordinal, DbDataReader Reader), object> readerCallback)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple)
            {
                return ReadToArrayInternalAsync(command, readerCallback).MapValueTuple<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple)
            {
                return ReadToArrayWithSetInternalAsync(command, readerCallback).Map<T1, T2, T3>(t1.type, t2.type, t3.type);
            }
            return ReadInternalAsync(command, async r => (
                await GetFieldValueAsync<T1>(r, 0, t1.type, readerCallback),
                await GetFieldValueAsync<T2>(r, 1, t2.type, readerCallback),
                await GetFieldValueAsync<T3>(r, 2, t3.type, readerCallback)));
        }
    }
}