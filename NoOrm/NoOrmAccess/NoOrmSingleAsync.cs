﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoOrm
{
    public partial class NoOrmAccess
    {
        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command)
        {
            using (var cmd = Connection.CreateCommand())
            {
                SetCommand(cmd, command);
                await EnsureConnectionIsOpenAsync();
                using (var reader = cmd.ExecuteReader())
                {
                    return await reader.ReadAsync()
                        ? reader.GetTuplesFromReader().ToList()
                        : new List<(string name, object value)>();
                }
            }
        }

        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params object[] parameters)
        {
            using (var cmd = Connection.CreateCommand())
            {
                SetCommand(cmd, command);
                await EnsureConnectionIsOpenAsync();
                cmd.AddParameters(parameters);
                using (var reader = cmd.ExecuteReader())
                {
                    return await reader.ReadAsync() 
                        ? reader.GetTuplesFromReader().ToList()
                        : new List<(string name, object value)>();
                }
            }
        }

        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params (string name, object value)[] parameters)
        {
            using (var cmd = Connection.CreateCommand())
            {
                SetCommand(cmd, command);
                await EnsureConnectionIsOpenAsync();
                cmd.AddParameters(parameters);
                using (var reader = cmd.ExecuteReader())
                {
                    return await reader.ReadAsync()
                        ? reader.GetTuplesFromReader().ToList()
                        : new List<(string name, object value)>();
                }
            }
        }
    }
}
