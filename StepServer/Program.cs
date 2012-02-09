using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Net;
using System.Net.Sockets;

namespace StepServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // тут надо замутить один раз соединение забить его в ConnectToDB и везде его где надо вызывать ололо
            SqlConnection connection = new SqlConnection("Data Source = (local); initial catalog = Sisyandri; Integrated Security = SSPI;");
            byte[] bytes = new byte[1024];
            //Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.Resolve("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            //Создаем сокет TCP\IP
            Socket sListener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            //Назначаем сокет локальной конечной точку
            // и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                //Начинаем слущать соединения 

                while (true) // Принимаем пользователя тута
                {
                    //////////////////////////////////////////
                    //вам надо тут на основе принятых данных сформировать UserRequest
                    //и вызвать метод dispatch в котором вмето делегатов и все по уму быклокодим ифы
                    // ах да я забыл тут надо вызывать новый поток ProcessingOfClient все должно выполняться в потоке и не забываем про синхронизацию









                    //////////////////////////////////////////
                    Console.WriteLine("Waiting for connections... ", ipEndPoint);
                    //программа приостанавливается,ожидая входящее соединение
                    Socket handler = sListener.Accept();
                    string data = null;
                    //дождались клиента,пытающегося с нами соединиться  
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    //выводим данные на консоль
                    Console.WriteLine("Сlient Message : {0}", data);
                    string theReply = "Thank You for your message " + data.Length.ToString() + "  characters...I'm the Body!!!";
                    byte[] msg = Encoding.ASCII.GetBytes(theReply);
                    // шлем тута ответ либо нормальный либо пшел ******
                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

