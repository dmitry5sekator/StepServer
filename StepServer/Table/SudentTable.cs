using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using StepServer.our;

namespace StepServer.Table
{
    class SudentTable : TableGateWay
    {
        public SudentTable(SqlConnection conn,string tableName) : base(conn,tableName)
        { }
        public SqlDataReader getStudents(string login) //нужно получить студетов одногруппников
        {
            // по login вытянуть одногруппников
            string answer = "";
            // Выполнить запрос , получить результат
            return null;
        }
    }
}
