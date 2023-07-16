﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Norm.Mapper
{
    public static partial class NormExtensions
    {
        internal static IEnumerable<T> MapValueTuple<T>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples, 
            Type type)
        {
            var ctorInfo = TypeCache<T>.GetValueTupleCtorInfo(type);
            foreach (var t in tuples)
            {
                yield return MapInstance<T>(t, ref ctorInfo);
            }
        }

        internal static IEnumerable<(T1, T2)> MapValueTuple<T1, T2>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples, 
            Type type1,
            Type type2)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                yield return (t1, t2);
            }
        }

        internal static IEnumerable<(T1, T2, T3)> MapValueTuple<T1, T2, T3>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                yield return (t1, t2, t3);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4)> MapValueTuple<T1, T2, T3, T4>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                yield return (t1, t2, t3, t4);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5)> MapValueTuple<T1, T2, T3, T4, T5>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                yield return (t1, t2, t3, t4, t5);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6)> MapValueTuple<T1, T2, T3, T4, T5, T6>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                yield return (t1, t2, t3, t4, t5, t6);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10,
            Type type11)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);
            var ctorInfo11 = TypeCache<T11>.GetValueTupleCtorInfo(type11);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                var t11 = MapInstance<T11>(t, ref ctorInfo11, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
        }

        internal static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10,
            Type type11,
            Type type12)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);
            var ctorInfo11 = TypeCache<T11>.GetValueTupleCtorInfo(type11);
            var ctorInfo12 = TypeCache<T12>.GetValueTupleCtorInfo(type12);

            foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                var t11 = MapInstance<T11>(t, ref ctorInfo11, ref start);
                var t12 = MapInstance<T12>(t, ref ctorInfo12, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
        }

        public static async IAsyncEnumerable<T> MapValueTuple<T>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples, Type type = null)
        {
            var ctorInfo = TypeCache<T>.GetValueTupleCtorInfo(type);
            await foreach (var t in tuples)
            {
                yield return MapInstance<T>(t, ref ctorInfo);
            }
        }

        public static async IAsyncEnumerable<(T1, T2)> MapValueTuple<T1, T2>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                yield return (t1, t2);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3)> MapValueTuple<T1, T2, T3>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                yield return (t1, t2, t3);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4)> MapValueTuple<T1, T2, T3, T4>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                yield return (t1, t2, t3, t4);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5)> MapValueTuple<T1, T2, T3, T4, T5>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                yield return (t1, t2, t3, t4, t5);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6)> MapValueTuple<T1, T2, T3, T4, T5, T6>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T5>.GetValueTupleCtorInfo(type6);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                yield return (t1, t2, t3, t4, t5, t6);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10,
            Type type11)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);
            var ctorInfo11 = TypeCache<T11>.GetValueTupleCtorInfo(type11);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                var t11 = MapInstance<T11>(t, ref ctorInfo11, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
        }

        public static async IAsyncEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> MapValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IAsyncEnumerable<ReadOnlyMemory<(string name, object value)>> tuples,
            Type type1,
            Type type2,
            Type type3,
            Type type4,
            Type type5,
            Type type6,
            Type type7,
            Type type8,
            Type type9,
            Type type10,
            Type type11,
            Type type12)
        {
            var ctorInfo1 = TypeCache<T1>.GetValueTupleCtorInfo(type1);
            var ctorInfo2 = TypeCache<T2>.GetValueTupleCtorInfo(type2);
            var ctorInfo3 = TypeCache<T3>.GetValueTupleCtorInfo(type3);
            var ctorInfo4 = TypeCache<T4>.GetValueTupleCtorInfo(type4);
            var ctorInfo5 = TypeCache<T5>.GetValueTupleCtorInfo(type5);
            var ctorInfo6 = TypeCache<T6>.GetValueTupleCtorInfo(type6);
            var ctorInfo7 = TypeCache<T7>.GetValueTupleCtorInfo(type7);
            var ctorInfo8 = TypeCache<T8>.GetValueTupleCtorInfo(type8);
            var ctorInfo9 = TypeCache<T9>.GetValueTupleCtorInfo(type9);
            var ctorInfo10 = TypeCache<T10>.GetValueTupleCtorInfo(type10);
            var ctorInfo11 = TypeCache<T11>.GetValueTupleCtorInfo(type11);
            var ctorInfo12 = TypeCache<T12>.GetValueTupleCtorInfo(type12);

            await foreach (var t in tuples)
            {
                int start = 0;
                var t1 = MapInstance<T1>(t, ref ctorInfo1, ref start);
                var t2 = MapInstance<T2>(t, ref ctorInfo2, ref start);
                var t3 = MapInstance<T3>(t, ref ctorInfo3, ref start);
                var t4 = MapInstance<T4>(t, ref ctorInfo4, ref start);
                var t5 = MapInstance<T5>(t, ref ctorInfo5, ref start);
                var t6 = MapInstance<T6>(t, ref ctorInfo6, ref start);
                var t7 = MapInstance<T7>(t, ref ctorInfo7, ref start);
                var t8 = MapInstance<T8>(t, ref ctorInfo8, ref start);
                var t9 = MapInstance<T9>(t, ref ctorInfo9, ref start);
                var t10 = MapInstance<T10>(t, ref ctorInfo10, ref start);
                var t11 = MapInstance<T11>(t, ref ctorInfo11, ref start);
                var t12 = MapInstance<T12>(t, ref ctorInfo12, ref start);
                yield return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
        }

        private static T MapInstance<T>(
            ReadOnlyMemory<(string name, object value)> tuple,
            ref (ConstructorInfo defaultCtor, int defaultCtorLen, ConstructorInfo lastCtor, int lastCtorLen) ctorInfo)
        {
            if (ctorInfo.lastCtor == null)
            {
                var p = new object[ctorInfo.defaultCtorLen];
                for (int i = 0; i < ctorInfo.defaultCtorLen; i++)
                {
                    p[i] = tuple.Span[i].value;
                }
                return (T)ctorInfo.defaultCtor.Invoke(p);
            }
            else
            {
                var p = new object[ctorInfo.defaultCtorLen];
                for (int i = 0; i < ctorInfo.defaultCtorLen - 1; i++)
                {
                    p[i] = tuple.Span[i].value;
                }
                var lp = new object[ctorInfo.lastCtorLen];
                for (int i = 0; i < ctorInfo.lastCtorLen; i++)
                {
                    lp[i] = tuple.Span[ctorInfo.defaultCtorLen + i - 1].value;
                }
                p[ctorInfo.defaultCtorLen - 1] = ctorInfo.lastCtor.Invoke(lp);
                return (T)ctorInfo.defaultCtor.Invoke(p);
            }
        }

        private static T MapInstance<T>(
            ReadOnlyMemory<(string name, object value)> tuple,
            ref (ConstructorInfo defaultCtor, int defaultCtorLen, ConstructorInfo lastCtor, int lastCtorLen) ctorInfo,
            ref int start)
        {
            if (ctorInfo.lastCtor == null)
            {
                var p = new object[ctorInfo.defaultCtorLen];
                for (int i = start; i < start + ctorInfo.defaultCtorLen; i++)
                {
                    p[i - start] = tuple.Span[i].value;
                }
                start = start + ctorInfo.defaultCtorLen;
                return (T)ctorInfo.defaultCtor.Invoke(p);
            }
            else
            {
                var p = new object[ctorInfo.defaultCtorLen];
                for (int i = start; i < start + ctorInfo.defaultCtorLen - 1; i++)
                {
                    p[i - start] = tuple.Span[i].value;
                }
                var lp = new object[ctorInfo.lastCtorLen];
                for (int i = start; i < start + ctorInfo.lastCtorLen; i++)
                {
                    lp[i - start] = tuple.Span[ctorInfo.defaultCtorLen + i - 1].value;
                }
                p[ctorInfo.defaultCtorLen - 1] = ctorInfo.lastCtor.Invoke(lp);
                start = start + ctorInfo.defaultCtorLen + ctorInfo.lastCtorLen - 1;
                return (T)ctorInfo.defaultCtor.Invoke(p);
            }
        }

    }
}