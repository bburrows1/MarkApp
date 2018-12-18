using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace LoginTest.Models
{
    class iSAMS
    {
        public Object getData(bool Student)
        {
            string url = "";
            if (Student)
                url = "https://warwickschool.isams.cloud:443/api/batch/1.0/json.ashx?apiKey=DB01D1E1-4558-43D8-B37B-1301735435A8";
            else
                url = "https://warwickschool.isams.cloud:443/api/batch/1.0/xml.ashx?apiKey=A1E29423-6374-40B2-9844-CA9D9FDE6E40";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}