using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace StepServer.Table
{
    class TableGateWay
    {
        private SqlConnection conn;
        private string tableName;

        public TableGateWay(SqlConnection conn, string tableName)
        {
            // TODO: Complete member initialization
            this.conn = conn;
            this.tableName = tableName;
        }
        public int Insert(Dictionary<String, String> dict)
        {
            String getField = "(";
            String getValue = " VALUES (";
            foreach (KeyValuePair<String, String> pair in dict)
            {
                getField += "`" + pair.Key + "`,";
                getValue += "'" + pair.Value + "',";
            }
            getField = getField.Substring(0, getField.Length - 1);
            getField += ")";

            getValue = getValue.Substring(0, getValue.Length - 1);
            getValue += ")";

            String sql = "INSERT INTO " + tableName + " " + getField + getValue + " ";
            SqlCommand com = new SqlCommand(sql, connection);
            return com.ExecuteNonQuery();
        }
        public int Update(Dictionary<String, String> dict, String field, Object value)
        {
            String SQL = "UPDATE " + tableName + " SET";
            foreach (KeyValuePair<String, String> pair in dict)
            {
                SQL += "`" + pair.Key + "`=";
                SQL += "'" + pair.Value + "',";
            }
            SQL = SQL.Substring(0, SQL.Length - 1);
            SQL = "WHERE `" + field + "` = '" + value + "'";

            SqlCommand com = new SqlCommand(SQL, connection);
            return com.ExecuteNonQuery();
        }
    }
}
