using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StepServer.our;
using System.Collections;

namespace StepServer.Controller
{
    class ApplicationController
    {
        private static ArrayList routes = new ArrayList();
	    public void addRoute(String pattern,String className,String method)
	{
		routes.Add(new Route(pattern, className, method));
	}
	public ApplicationController(){}

	public static void dispatch(UserRequest http_request, Response http_response) 																							
	{
		try
		{
            //foreach(Route r in routes)
            //{
            //    if(r.match(http_request))
            //    {
					
            //    }
            //}
            // ну блин делаем пачку if'ов и готовим регулярку 
            // if(регулярка1 ) шото делаем
            // если нифига не вышло пишем ответ тупойзапрос и все 
		}
		catch(Exception e)
		{
			
		}
	}
    }
}
