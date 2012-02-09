using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace StepServer.Server
{
    class ConnectToDB
    {
        // пускай побыдлакодим а не синглтоном сделаем короче тут надо создать метод который просто тупо будет принимать строку коннекта
        // логин пароль и присваивать SqlConnection и конечно для особоодаренных сделать get метод для получения коннекта статический
        private static SqlConnection conn = null;
        //private static String URL = null;
        //private static String nick = null;
        //private static String pass = null;
    //    private static void getAuth()
    //{
    //    try
    //    {
    //        RandomAccessFile r = new RandomAccessFile("key.auth","r");
    //        try
    //        {
    //            URL = r.readLine();
    //            nick = r.readLine();
    //            pass = r.readLine();
    //        }
    //        catch(IOException ex)
    //        {
    //            ex.printStackTrace();
    //        }
    //    } 
    //    catch (FileNotFoundException ex) 
    //    {
    //        // TODO Auto-generated catch block
    //        ex.printStackTrace();
    //        try
    //        {
    //            Logger.writeEvent(e.toString());
    //        }
    //        catch(Exception exep)
    //        {
    //            exep.printStackTrace();
    //        }
    //    }
    //}
	public static SqlConnection getConnection ()
	{
		return conn;
		
	}
    //public static void startUpConnection() throw IOException
    //{
    //    try 
    //    {
    //        getAuth();
    //        conn = DriverManager.getConnection(URL, nick, pass);
    //        Logger.writeEvent("Successfully established a connection to the database " + URL);
    //    } 
    //    catch (SQLException e) 
    //    {
    //        e.printStackTrace();
    //        try
    //            {
    //                Logger.writeEvent(e.toString());
    //            }
    //                catch(Exception exep)
    //                {
    //                    exep.printStackTrace();
    //                }
    //    }	
    //}
   }
}
