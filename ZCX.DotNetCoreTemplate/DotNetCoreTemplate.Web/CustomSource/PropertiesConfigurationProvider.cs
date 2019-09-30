using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreTemplate.Web.CustomSource
{
    public class PropertiesConfigurationProvider:ConfigurationProvider
    {
        private readonly string _path;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public PropertiesConfigurationProvider(string path)
        {
            this._path = path;
        }
        
        /// <summary>
        /// 用于解析db.properties文件
        /// </summary>
        public override void Load()
        {
            var contents = File.ReadLines(_path);
            var dic = new Dictionary<string,string>();
            foreach (var line in contents)
            {
                var items = line.Split('=');
                dic.Add(items[0],items[1]);
            }
            this.Data = dic;
            base.Load();
        }
    }
}
