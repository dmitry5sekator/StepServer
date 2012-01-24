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
    }
}
