﻿using Norm.Extensions;

namespace Norm
{
    public partial class Norm
    {
        public INorm Execute(string command)
        {
            using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            Connection.EnsureIsOpen();
            cmd.ExecuteNonQuery();
            OnCommandExecuted(cmd);
            return this;
        }

        public INorm Execute(string command, params object[] parameters)
        {
            using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            Connection.EnsureIsOpen();
            cmd.AddParameters(parameters).ExecuteNonQuery();
            OnCommandExecuted(cmd);
            return this;
        }

        public INorm Execute(string command, params (string name, object value)[] parameters)
        {
            using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            Connection.EnsureIsOpen();
            cmd.AddParameters(parameters).ExecuteNonQuery();
            OnCommandExecuted(cmd);
            return this;
        }
    }
}