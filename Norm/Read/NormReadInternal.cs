﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Norm
{
    public partial class Norm
    {
        private IEnumerable<T> ReadInternal<T>(string command, Func<DbDataReader, T> readerAction)
        {
            using var cmd = CreateCommand(command);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<T> ReadInternal<T>(FormattableString command, Func<DbDataReader, T> readerAction)
        {
            using var cmd = CreateCommand(command);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternal(string command)
        {
            using var cmd = CreateCommand(command);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternal(FormattableString command)
        {
            using var cmd = CreateCommand(command);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        private IEnumerable<T> ReadInternal<T>(string command, Func<DbDataReader, T> readerAction, params object[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternal(string command, params object[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        private IEnumerable<T> ReadInternal<T>(string command, Func<DbDataReader, T> readerAction, params (string name, object value)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternal(string command, params (string name, object value)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        private IEnumerable<T> ReadInternal<T>(string command, Func<DbDataReader, T> readerAction, params (string name, object value, DbType type)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternal(string command, params (string name, object value, DbType type)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        private IEnumerable<T> ReadInternalUnknowParamsType<T>(string command, Func<DbDataReader, T> readerAction, params (string name, object value, object type)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return readerAction(reader);
            }
        }

        private IEnumerable<(string name, object value)[]> ReadToArrayInternalUnknowParamsType(string command, params (string name, object value, object type)[] parameters)
        {
            using var cmd = CreateCommand(command, parameters);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToArray(reader);
            }
        }

        internal (string name, object value)[] ReadToArray(DbDataReader reader)
        {
            var count = reader.FieldCount;
            object v;
            object r;
            string n;
            (string name, object value)[] result = new (string name, object value)[count];
            for (var index = 0; index < count; index++)
            {
                n = reader.GetName(index);
                v = reader.GetValue(index);
                if (v == DBNull.Value) r = null; else r = v;
                result[index] = (n, r);
            }
            return result;
        }

        internal T GetFieldValue<T>(DbDataReader reader, int ordinal, bool isString, Type type)
        {
            if (reader.IsDBNull(ordinal))
            {
                return default;
            }

            if (type.IsEnum || (type.GenericTypeArguments.Length > 0 && type.GenericTypeArguments[0].IsEnum))
            {
                var fieldType = reader.GetFieldType(ordinal);
                if (fieldType == TypeExt.StringType)
                {
                    if (type.GenericTypeArguments.Length > 0 && type.GenericTypeArguments[0].IsEnum)
                    {
                        return (T)Enum.Parse(type.GenericTypeArguments[0], reader.GetString(ordinal));
                    }
                    return (T)Enum.Parse(type, reader.GetString(ordinal));
                }
                if (fieldType == TypeExt.IntType)
                {
                    if (type.GenericTypeArguments.Length > 0 && type.GenericTypeArguments[0].IsEnum)
                    {
                        return (T)Enum.ToObject(type.GenericTypeArguments[0], reader.GetInt32(ordinal));
                    }
                    return (T)Enum.ToObject(type, reader.GetInt32(ordinal));
                }
            }

            return reader.GetFieldValue<T>(ordinal);
        }
    }
}