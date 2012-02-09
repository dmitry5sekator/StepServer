using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepServer.Classes;
using StepServer.our;
using StepServer.Server;
using StepServer.parser;
using System.Data.SqlClient;

namespace StepServer.Controller
{
    class UserController
    {
        private User user = new User();
        private Dictionary<String, String> map = new Dictionary<String, String>();
        public void getUser(UserRequest http_request, Response http_response) // +
        {

        }
        public void signIn(UserRequest http_request, Response http_response)
        { 
            // получаем типа POST signIn HTTP/1.1 ну как-то так и проверяем есть ли такой пользователь в базе или нет если нет шлем нахуй
        }
        public void getClassmates(UserRequest http_request, Response http_response)
        { 
           
            // а тут аншлаг берем UserTable в зубы и ебашим логику
            // выполняем public SqlDataReader getStudents(string login)
            // получили результат сформировали ответ и пиу пиу 
        }

    }
}
