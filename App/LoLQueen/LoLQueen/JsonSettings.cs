using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;

namespace LoLQueen
{
    public class JsonSettings
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryUrl"></param>
        /// <returns></returns>
        public static T GetStats<T>(string queryUrl)
        {

            try
            {
                var jsonSerializerSettings = new JsonSerializerSettings();

                //ignores json data if structure required is not present
                jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                Debug.WriteLine("url contains : " + queryUrl);

                var jsonResult = new WebClient().DownloadString(queryUrl);
                T newObject = JsonConvert.DeserializeObject<T>(jsonResult, jsonSerializerSettings);
                Debug.WriteLine("new object is: " + newObject);
                Debug.WriteLine(newObject.GetType());
                return newObject;
            }
            catch
            {
                Debug.WriteLine("Error");
                Debug.WriteLine("new object is: " + default(T));

                return default(T);
            }
        }

    }
}