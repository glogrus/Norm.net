﻿using System.Data;
using System.Threading.Tasks;

namespace Norm.Interfaces
{
    public interface INormExecuteAsync
    {
        ///<summary>
        ///     Execute SQL command asynchronously.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<returns>A value task representing the asynchronous operation returning the same Norm instance.</returns>
        ValueTask<INorm> ExecuteAsync(string command);
        ///<summary>
        ///      Execute SQL command asynchronously with positional parameter values.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters objects array.</param>
        ///<returns>A value task representing the asynchronous operation returning the same Norm instance.</returns>
        ValueTask<INorm> ExecuteAsync(string command, params object[] parameters);
        ///<summary>
        ///     Execute SQL command asynchronously with named parameter values.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuples array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning the same Norm instance.</returns>
        ValueTask<INorm> ExecuteAsync(string command, params (string name, object value)[] parameters);
        ///<summary>
        ///     Execute SQL command asynchronously with named parameter values DbType type for each parameter.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">Parameters name and value tuples array - (string name, object value).</param>
        ///<returns>A value task representing the asynchronous operation returning the same Norm instance.</returns>
        ValueTask<INorm> ExecuteAsync(string command, params (string name, object value, DbType type)[] parameters);
        ///<summary>
        ///     Execute SQL command asynchronously with named parameter values and custom type for each parameter.
        ///</summary>
        ///<param name="command">SQL command text.</param>
        ///<param name="parameters">
        ///     Parameters name, value and type tuples array - (string name, object value, DbType type).
        ///     Parameter type can be any type from custom db provider -  NpgsqlDbType or MySqlDbType for example.
        ///</param>
        ///<returns>A value task representing the asynchronous operation returning the same Norm instance.</returns>
        ValueTask<INorm> ExecuteAsync(string command, params (string name, object value, object type)[] parameters);
    }
}