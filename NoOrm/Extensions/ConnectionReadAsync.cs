﻿using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace NoOrm.Extensions
{
    public static partial class ConnectionExtensions
    {
        public static IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(this DbConnection connection, string command) 
            => connection.GetNoOrmInstance().ReadAsync(command);

        public static IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(this DbConnection connection, string command, params object[] parameters) 
            => connection.GetNoOrmInstance().ReadAsync(command, parameters);

        public static IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(this DbConnection connection, string command, params (string name, object value)[] parameters)
            => connection.GetNoOrmInstance().ReadAsync(command, parameters);

        public static IAsyncEnumerable<T> ReadAsync<T>(this DbConnection connection, string command)
            => connection.GetNoOrmInstance().ReadAsync<T>(command);

        public static IAsyncEnumerable<T> ReadAsync<T>(this DbConnection connection, string command, params object[] parameters)
            => connection.GetNoOrmInstance().ReadAsync<T>(command, parameters);

        public static IAsyncEnumerable<T> ReadAsync<T>(this DbConnection connection, string command, params (string name, object value)[] parameters)
            => connection.GetNoOrmInstance().ReadAsync<T>(command, parameters);

        public static IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(this DbConnection connection, string command)
            => connection.GetNoOrmInstance().ReadAsync<T1, T2>(command);
        public static IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(this DbConnection connection, string command, params object[] parameters)
            => connection.GetNoOrmInstance().ReadAsync<T1, T2>(command, parameters);

        public static IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(this DbConnection connection, string command, params (string name, object value)[] parameters)
            => connection.GetNoOrmInstance().ReadAsync<T1, T2>(command, parameters);
    }
}