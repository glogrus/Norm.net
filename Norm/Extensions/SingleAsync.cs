﻿using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Norm
{
    public static partial class NormExtensions
    {
        ///<summary>
        ///     Maps command results asynchronously to name and value tuple array.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning name and value tuple array.</returns>
        public static async ValueTask<(string name, object value)[]> SingleAsync(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to name and value tuple array.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning name and value tuple array.</returns>
        public static async ValueTask<(string name, object value)[]> SingleAsync(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to name and value tuple array.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning name and value tuple array.</returns>
        public static async ValueTask<(string name, object value)[]> SingleAsync(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to name and value tuple array.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning name and value tuple array.</returns>
        public static async ValueTask<(string name, object value)[]> SingleAsync(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to name and value tuple array.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning name and value tuple array.</returns>
        public static async ValueTask<(string name, object value)[]> SingleAsync(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync(command, parameters);

        ///<summary>
        ///     Maps command results asynchronously to single value of type T.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning single values of type T.</returns>
        public static async ValueTask<T> SingleAsync<T>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to single value of type T.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning single values of type T.</returns>
        public static async ValueTask<T> SingleAsync<T>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to single value of type T.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning single values of type T.</returns>
        public static async ValueTask<T> SingleAsync<T>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to single value of type T.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning single values of type T.</returns>
        public static async ValueTask<T> SingleAsync<T>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to single value of type T.
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning single values of type T.</returns>
        public static async ValueTask<T> SingleAsync<T>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to two value tuple (T1, T2).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning two value tuple (T1, T2).</returns>
        public static async ValueTask<(T1, T2)> SingleAsync<T1, T2>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to two value tuple (T1, T2).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning two value tuple (T1, T2).</returns>
        public static async ValueTask<(T1, T2)> SingleAsync<T1, T2>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to two value tuple (T1, T2).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning two value tuple (T1, T2).</returns>
        public static async ValueTask<(T1, T2)> SingleAsync<T1, T2>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to two value tuple (T1, T2).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning two value tuple (T1, T2).</returns>
        public static async ValueTask<(T1, T2)> SingleAsync<T1, T2>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to two value tuple (T1, T2).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning two value tuple (T1, T2).</returns>
        public static async ValueTask<(T1, T2)> SingleAsync<T1, T2>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to three value tuple (T1, T2, T3).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning three value tuple (T1, T2, T3).</returns>
        public static async ValueTask<(T1, T2, T3)> SingleAsync<T1, T2, T3>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to three value tuple (T1, T2, T3).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning three value tuple (T1, T2, T3).</returns>
        public static async ValueTask<(T1, T2, T3)> SingleAsync<T1, T2, T3>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to three value tuple (T1, T2, T3).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning three value tuple (T1, T2, T3).</returns>
        public static async ValueTask<(T1, T2, T3)> SingleAsync<T1, T2, T3>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to three value tuple (T1, T2, T3).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning three value tuple (T1, T2, T3).</returns>
        public static async ValueTask<(T1, T2, T3)> SingleAsync<T1, T2, T3>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to three value tuple (T1, T2, T3).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning three value tuple (T1, T2, T3).</returns>
        public static async ValueTask<(T1, T2, T3)> SingleAsync<T1, T2, T3>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to four value tuple (T1, T2, T3, T4).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning four value tuple (T1, T2, T3, T4).</returns>
        public static async ValueTask<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to four value tuple (T1, T2, T3, T4).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning four value tuple (T1, T2, T3, T4).</returns>
        public static async ValueTask<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to four value tuple (T1, T2, T3, T4).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning four value tuple (T1, T2, T3, T4).</returns>
        public static async ValueTask<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to four value tuple (T1, T2, T3, T4).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning four value tuple (T1, T2, T3, T4).</returns>
        public static async ValueTask<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to four value tuple (T1, T2, T3, T4).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning four value tuple (T1, T2, T3, T4).</returns>
        public static async ValueTask<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to five value tuple (T1, T2, T3, T4, T5).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning five value tuple (T1, T2, T3, T4, T5).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to five value tuple (T1, T2, T3, T4, T5).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning five value tuple (T1, T2, T3, T4, T5).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to five value tuple (T1, T2, T3, T4, T5).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning five value tuple (T1, T2, T3, T4, T5).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to five value tuple (T1, T2, T3, T4, T5).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning five value tuple (T1, T2, T3, T4, T5).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to five value tuple (T1, T2, T3, T4, T5).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning five value tuple (T1, T2, T3, T4, T5).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to six value tuple (T1, T2, T3, T4, T5, T6).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning six value tuple (T1, T2, T3, T4, T5, T6).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> SingleAsync<T1, T2, T3, T4, T5, T6>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to six value tuple (T1, T2, T3, T4, T5, T6).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning six value tuple (T1, T2, T3, T4, T5, T6).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> SingleAsync<T1, T2, T3, T4, T5, T6>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to six value tuple (T1, T2, T3, T4, T5, T6).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning six value tuple (T1, T2, T3, T4, T5, T6).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> SingleAsync<T1, T2, T3, T4, T5, T6>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to six value tuple (T1, T2, T3, T4, T5, T6).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning six value tuple (T1, T2, T3, T4, T5, T6).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> SingleAsync<T1, T2, T3, T4, T5, T6>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to six value tuple (T1, T2, T3, T4, T5, T6).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning six value tuple (T1, T2, T3, T4, T5, T6).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> SingleAsync<T1, T2, T3, T4, T5, T6>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to seven value tuple (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning seven value tuple (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> SingleAsync<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to seven value tuple (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning seven value tuple (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> SingleAsync<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to seven value tuple (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning seven value tuple (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> SingleAsync<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to seven value tuple (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning seven value tuple (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> SingleAsync<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to seven value tuple (T1, T2, T3, T4, T5, T6, T7).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning seven value tuple (T1, T2, T3, T4, T5, T6, T7).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> SingleAsync<T1, T2, T3, T4, T5, T6, T7>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning eight value tuple (T1, T2, T3, T4, T5, T6, T7, T8).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning nine value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning ten value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning eleven value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously to twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this DbConnection connection, string command) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(command);
        ///<summary>
        ///     Maps command results asynchronously with positional parameter values to twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this DbConnection connection, string command, params object[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values to twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuple array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this DbConnection connection, string command, params (string name, object value)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and DbType type for each parameter to twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name, value and type tuple array - (string name, object value, DbType type).</param>
        ///<returns>A value task representing the asynchronous operation returning twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this DbConnection connection, string command, params (string name, object value, DbType type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(command, parameters);
        ///<summary>
        ///     Maps command results asynchronously with named parameter values and custom type for each parameter to twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).
        ///</summary>
        ///<param name="connection">DbConnection instance.</param>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuple array - (string name, object value, object type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning twelve value tuple (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12).</returns>
        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this DbConnection connection, string command, params (string name, object value, object type)[] parameters) =>
            await connection.GetNoOrmInstance().SingleAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(command, parameters);
    }
}