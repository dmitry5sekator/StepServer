using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace StepServer.parser
{
    class json
    {
        //  и это нихера не парсер а класс и методы которые будут вызываться в контроллерах и формировать на каких-то входных данных типа
        //Dictionary будут json формировать ололо
    //    public static void parse(Dictionary <String,String> mass1,String source) throws UnsupportedEncodingException
    //    {
    //        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
    //        byte[] bytes = source.getBytes("UTF-8");
    //        InputStream is = new ByteArrayInputStream(bytes);
    //        try
    //        {
    //            DocumentBuilder builder = factory.newDocumentBuilder();
    //            Document doc = builder.parse(is);
    //            Element root = doc.getDocumentElement();
    //            NodeList children = root.getChildNodes();
    //            for(int i = 0; i < children.getLength(); i++)
    //            {
    //                Node child = children.item(i);
				
    //                if(child instanceof Element)
    //                {
    //                    Element childElement = (Element)child;
    //                    Text textNode = (Text) childElement.getFirstChild(); // значение
    //                    String textNode1 = childElement.getNodeName(); // имя
    //                    if(textNode != null)
    //                    {
    //                        String text = textNode.getData().trim();
    //                        mass1.put(textNode1, text);
    //                    }
					
    //                }
    //            }
    //        }
    //        catch(Exception e)
    //        {
    //            e.printStackTrace();
    //        }
    //    }


    //}
}
