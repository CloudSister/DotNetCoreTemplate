using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreTemplate.Web.MultiTenant
{
    /// <summary>
    /// 租户接口
    /// </summary>
    public interface ITenantProvider
    {
        /// <summary>
        /// 获取租户
        /// </summary>
        /// <returns></returns>
        Tenant GetTenant();

        /// <summary>
        /// 获取用户编号
        /// </summary>
        /// <returns></returns>
        string GetUserId();

        /// <summary>
        /// 获取应用程序编号
        /// </summary>
        /// <returns></returns>
        string GetAppId();

        /// <summary>
        /// 获取主机域名应用前缀
        /// </summary>
        /// <returns></returns>
        string GetHost();

        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        string GetQueryString();

    }
}
