using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using ETL.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ETL.Web
{
    public class Class1
    {
        private const string ENDPOINT =
            //"http://maps.googleapis.com/maps/api/geocode/json?wsdl";// bad request
            //"http://www.thomas-bayer.com/axis2/services/BLZService?wsdl"; // text/xml
            "https://maps.googleapis.com/maps/api/timezone/json?wsdl"; // application/json - INVALID_REQUEST 
            //"http://date.jsontest.com?wsdl"; // application/json
            //"http://services.groupkt.com/country/get/all?wsdl"; // text/html

        public void Webservicecall()
        {
            WebRequest webRequest = WebRequest.Create(ENDPOINT);
            WebResponse webResponse = webRequest.GetResponse();
            ServiceDescription description = null;

            List<PageConfig> pageConfigs = new List<PageConfig>();

            if (webResponse.ContentType.Contains("application/json") || webResponse.ContentType.Contains("text/json"))
            {
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    var streamContents = streamReader.ReadToEnd();
                    //streamContents = "{\"time\":\"09:28:40 PM\", \"date\":\"09-21-2017\", \"SubObj\":{\"milliseconds_since_epoch\":1506029320396, \"Name\":\"Paul Moura\"}}";

                    JObject o = (JObject)JsonConvert.DeserializeObject(streamContents);
                    var props = o.Properties();

                    var xmlDoc = JsonConvert.DeserializeXmlNode(streamContents, "root");
                    XmlReader xmlReader = new XmlNodeReader(xmlDoc);
                    description = ServiceDescription.Read(xmlReader);
                }
            }
            else if (webResponse.ContentType.Contains("text/html") || webResponse.ContentType.Contains("text/plain"))
            {
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    var streamContents = streamReader.ReadToEnd();
                    JObject o = (JObject)JsonConvert.DeserializeObject(streamContents);
                    var props = o.Properties();
                    var xmlDoc = JsonConvert.DeserializeXmlNode(streamContents);
                    XmlReader xmlReader = new XmlNodeReader(xmlDoc);
                    description = ServiceDescription.Read(xmlReader);
                }
            }
            else
            {
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    var streamContents = streamReader.ReadToEnd();
                }
                using (Stream stream = webResponse.GetResponseStream())
                {
                    description = ServiceDescription.Read(stream);
                }
            }
            
            ServiceDescriptionImporter importer = new ServiceDescriptionImporter {ProtocolName = "Soap12"};

            //' Use SOAP 1.2. 
            importer.AddServiceDescription(description, null, null);
            importer.Style = ServiceDescriptionImportStyle.Client;

            //'--Generate properties to represent primitive values. 
            importer.CodeGenerationOptions = System.Xml.Serialization.CodeGenerationOptions.GenerateProperties;
            //'Initialize a Code-DOM tree into which we will import the service. 

            CodeNamespace nmspace = new CodeNamespace();
            CodeCompileUnit unit1 = new CodeCompileUnit();
            unit1.Namespaces.Add(nmspace);
            ServiceDescriptionImportWarnings warning = importer.Import(nmspace, unit1);
            CodeDomProvider provider1 = CodeDomProvider.CreateProvider("C#");

            //'--Compile the assembly proxy with the // appropriate references 
            string[] assemblyReferences = { "System.dll", "System.Web.Services.dll", "System.Web.dll", "System.Xml.dll", "System.Data.dll" };

            CompilerParameters parms = new CompilerParameters(assemblyReferences) {GenerateInMemory = true};
            CompilerResults results = provider1.CompileAssemblyFromDom(parms, unit1);
            if (results.Errors.Count > 0)
            {
            }

            List<string> typesStr = new List<string>();
            Type foundType = null;
            Type[] types = results.CompiledAssembly.GetTypes();
            foreach (Type type1 in types)
            {
                typesStr.Add(type1.FullName);
                typesStr.AddRange(type1.GetFields().Select(x => x.Name));
                typesStr.AddRange(type1.GetMethods().Select(x => x.Name));
                if (type1.BaseType == typeof(SoapHttpClientProtocol))
                {
                    foundType = type1;
                }
            }

            Object wsvcClass = results.CompiledAssembly.CreateInstance(foundType.ToString());
            foreach (var info in wsvcClass.GetType().GetMethods())
            {
                foreach (var parameter in info.GetParameters())
                {
                    Debug.WriteLine(parameter.ParameterType);
                }

                Debug.WriteLine(info.ReturnType);

                foreach (FieldInfo field in info.ReturnType.GetFields())
                {
                    Debug.WriteLine(field.FieldType);
                }
            }
        }

        private void BuildPage(JObject o, int count, List<PageConfig> pageConfigs)
        {
            var name = $"Object ({count})";
            var propNames = o.Properties().Select(x => x.Name).ToArray();

            //PageConfig page = new PageConfig(name, propNames);
            //foreach (var property in o.Properties())
            //{
                
            //}

        }
    }
}
