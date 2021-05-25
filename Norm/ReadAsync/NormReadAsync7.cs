﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Norm
{
    public partial class Norm
    {
        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadAsync<T1, T2, T3, T4, T5, T6, T7>(string command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadAsync(command).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadAsync(command).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)));
            }
            throw new NormMultipleMappingsException();
        }

        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadFormatAsync<T1, T2, T3, T4, T5, T6, T7>(FormattableString command)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadFormatAsync(command).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadFormatAsync(command).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)));
            }
            throw new NormMultipleMappingsException();
        }

        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadAsync<T1, T2, T3, T4, T5, T6, T7>(string command,
            params object[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadAsync<T1, T2, T3, T4, T5, T6, T7>(string command,
            params (string name, object value)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadAsync<T1, T2, T3, T4, T5, T6, T7>(string command,
            params (string name, object value, DbType type)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)), parameters);
            }
            throw new NormMultipleMappingsException();
        }

        public IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> ReadAsync<T1, T2, T3, T4, T5, T6, T7>(string command,
            params (string name, object value, object type)[] parameters)
        {
            var t1 = TypeCache<T1>.GetMetadata();
            var t2 = TypeCache<T2>.GetMetadata();
            var t3 = TypeCache<T3>.GetMetadata();
            var t4 = TypeCache<T4>.GetMetadata();
            var t5 = TypeCache<T5>.GetMetadata();
            var t6 = TypeCache<T6>.GetMetadata();
            var t7 = TypeCache<T7>.GetMetadata();
            if (t1.valueTuple && t2.valueTuple && t3.valueTuple && t4.valueTuple && t5.valueTuple && t6.valueTuple && t7.valueTuple)
            {
                return ReadAsync(command, parameters).MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (!t1.simple && !t2.simple && !t3.simple && !t4.simple && !t5.simple && !t6.simple && !t7.simple)
            {
                return ReadAsync(command, parameters).Map<T1, T2, T3, T4, T5, T6, T7>(t1.type, t2.type, t3.type, t4.type, t5.type, t6.type, t7.type);
            }
            else if (t1.simple && t2.simple && t3.simple && t4.simple && t5.simple && t6.simple && t7.simple)
            {
                return ReadInternalUnknownParamsTypeAsync(command, async r => (
                    await r.GetFieldValueAsync<T1>(0, convertsDbNull),
                    await r.GetFieldValueAsync<T2>(1, convertsDbNull),
                    await r.GetFieldValueAsync<T3>(2, convertsDbNull),
                    await r.GetFieldValueAsync<T4>(3, convertsDbNull),
                    await r.GetFieldValueAsync<T5>(4, convertsDbNull),
                    await r.GetFieldValueAsync<T6>(5, convertsDbNull),
                    await r.GetFieldValueAsync<T7>(6, convertsDbNull)), parameters);
            }
            throw new NormMultipleMappingsException();
        }
    }
}