using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.Common;

namespace SQLGen
{
    public class SQLGenInterecptor : DbCommandInterceptor
    {
        public override void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            var sqlText = command.CommandText;
            foreach(DbParameter sqlParam in command.Parameters)
            {
                sqlText = sqlText.Replace(sqlParam.ParameterName, sqlParam.Value.ToString());
            }

            Log.Info(sqlText);
            base.NonQueryExecuting(command, interceptionContext);
        }

        public override void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            var sqlText = command.CommandText;
            foreach (DbParameter sqlParam in command.Parameters)
            {
                sqlText = sqlText.Replace(sqlParam.ParameterName, sqlParam.Value.ToString());
            }

            Log.Info(sqlText);
            base.ReaderExecuting(command, interceptionContext);
        }

        public override void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            var sqlText = command.CommandText;
            foreach (DbParameter sqlParam in command.Parameters)
            {
                sqlText = sqlText.Replace(sqlParam.ParameterName, sqlParam.Value.ToString());
            }

            Log.Info(sqlText);
            base.ScalarExecuting(command, interceptionContext);
        }
    }
}
