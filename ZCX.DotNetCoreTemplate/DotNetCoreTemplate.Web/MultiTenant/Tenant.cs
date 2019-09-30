using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreTemplate.Web.MultiTenant
{
    /// <summary>
    /// 租户类
    /// </summary>
    public class Tenant
    {
        /// <summary>
        /// 应用程序编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 应用程序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 应用程序所在IP
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string DatabaseConnectionString { get; set; }
    }
}
