using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreTemplate.Web.CustomSource
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class PropertiesConfigurationExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IConfigurationBuilder AddPropertiesFile(
            this IConfigurationBuilder builder,
            string path)
        {
            builder.Add(new PropertiesConfigurationSource(path));
            return builder;
        }
    }
}
