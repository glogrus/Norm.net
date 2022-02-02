﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Norm
{
    public partial class Norm
    {
        ///<summary>
        ///     Maps command results to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            string command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadAsync(command).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadAsync(command).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)));
            }
            throw new NormMultipleMappingsException();
        }

        ///<summary>
        /// Parse interpolated (formattable) command as database parameters and map command results to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text as interpolated (formattable) string.</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadFormatAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            FormattableString command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadFormatAsync(command).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadFormatAsync(command).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)));
            }
            throw new NormMultipleMappingsException();
        }

        ///<summary>
        ///     Maps command results with positional parameter values to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            string command, params object[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        ///<summary>
        ///     Maps command results with named parameter values to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            string command, params (string name, object value)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        ///<summary>
        ///     Maps command results with named parameter values and DbType type for each parameter to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            string command, params (string name, object value, DbType type)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        ///<summary>
        ///     Maps command results with named parameter values and custom type for each parameter to async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>IAsyncEnumerable async enumerator of eight value tuples (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> ReadAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
            string command, params (string name, object value, object type)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            var t8 = TypeCache<T8>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple && t8.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple && !t8.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7, T8>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type, t8.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple && t8.simple)
            {
                return ReadInternalUnknownParamsTypeAsync(command, async r => (
                   await GetFieldValueAsync<T1>(r, 0, t1.isString, t1.type),
                   await GetFieldValueAsync<T2>(r, 1, t2.isString, t2.type),
                   await GetFieldValueAsync<T3>(r, 2, t3.isString, t3.type),
                   await GetFieldValueAsync<T4>(r, 3, t4.isString, t4.type),
                   await GetFieldValueAsync<T5>(r, 4, t5.isString, t5.type),
                   await GetFieldValueAsync<T6>(r, 5, t6.isString, t6.type),
                   await GetFieldValueAsync<T7>(r, 6, t7.isString, t7.type),
                   await GetFieldValueAsync<T8>(r, 7, t8.isString, t8.type)), parameters);
            }
            throw new NormMultipleMappingsException();
        }
    }
}