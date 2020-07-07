using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using Dapper;
using Dapper.FastCrud;
using Project.Domain.Models;

namespace Project.Domain.Helpers
{
    public abstract class BaseDataServices<T> where T : BaseDataEntities, new()
    {
        readonly string ConnectionString =
            @"Data Source=DESKTOP-9FP7BFG;Initial Catalog=Northwind;Integrated Security=True";


        protected IDbConnection Connection => new SqlConnection(ConnectionString);


        protected T GetDataById(int id)
        {
            return Connection.Get(new T {Id = id});
        }

        protected List<T> GetData()
        {
            return (List<T>) Connection.Find<T>();
        }

        protected T InsertData(T entity)
        {
            Connection.Insert(entity);
            return entity;
        }

        protected T UpdateData(T entity)
        {
            Connection.Update(entity);
            return entity;
        }

        protected T DeleteData(T entity)
        {
            Connection.Delete(entity);
            return entity;
        }

        //
        // protected T GetData(string query,object param=null)
        // {
        //     return Connection.QuerySingleOrDefault<T>(query, param);
        // }

        protected List<T> GetDataList(string query, object param = null)
        {
            return Connection.Query<T>(query, param).ToList();
        }

        protected int ExecuteCommandText(string query, object param = null)
        {
            return Connection.Execute(query, param, commandType: CommandType.Text);
        }

        protected int ExecuteCommandScalar(string query, object param = null)
        {
            return Connection.ExecuteScalar<int>(query, param, commandType: CommandType.Text);
        }

        protected List<T> ExecuteCommandProcedure(string query, object param = null)
        {
            return Connection.Query<T>(query, param, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}