using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreTemplate.Web.CustomSource
{
    public class PropertiesConfigurationSource : IConfigurationSource
    {
        private readonly string _path;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public PropertiesConfigurationSource(string path)
        {
            this._path = path;
        }

        /// <summary>
        /// 用于生成Provider
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new PropertiesConfigurationProvider(_path);
        }
    }
}
