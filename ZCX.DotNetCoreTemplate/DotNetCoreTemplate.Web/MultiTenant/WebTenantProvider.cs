using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreTemplate.Web.MultiTenant
{
    public class WebTenantProvider : ITenantProvider
    {

        #region 属性及构造函数

        //租户集合
        public static IList<Tenant> _tenants;
        //租户
        private Tenant _tenant;
        //应用编号，设置一个默认值-1，如果请求的参数不在db列表中，使用此值返回相应的提示信息
        private string _appId = "-1";
        //用户编号
        private string _userId = "0";
        //拼接后请求的字符串
        private string _queryString = "";

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="conf"></param>
        public WebTenantProvider(IHttpContextAccessor accessor, IConfiguration conf)
        {
            if (_tenants == null)
            {
                //从配置文件加载全部
                LoadTenants();
            }

            if (accessor.HttpContext.Request.ContentLength != 0)
            {
                foreach (var key in accessor.HttpContext.Request.Form.Keys)
                {
                    //用户编号
                    if (key == "userId")
                    {
                        _userId = accessor.HttpContext.Request.Form[key].ToString();
                    }
                    //应用程序编号
                    if (key == "appId")
                    {
                        _appId = accessor.HttpContext.Request.Form[key].ToString();
                    }
                    //请求参数
                    if (key == "queryString")
                    {
                        _queryString = accessor.HttpContext.Request.Form[key].ToString();
                    }
                }
            }

            var tenant = _tenants.FirstOrDefault(t => t.Id.ToLower() == _appId.ToLower());
            if (tenant != null)
            {
                _tenant = tenant;
            }
            else
            {
                //如果某个应用appId不在db.json列表中的话，返回一个默认的-1出去
                _tenant = _tenants.FirstOrDefault(t => t.Id.ToLower() == "-1");
            }
        }

        #endregion

        #region 加载租户，从json配置文件获取数据

        /// <summary>
        /// 加载租户，从json配置文件获取数据
        /// </summary>
        private void LoadTenants()
        {
            #region 1、目前从json文件中读取信息

            string path = Directory.GetCurrentDirectory() + "\\db.json";
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;
                    //构建Json.net的读取流
                    JsonReader reader = new JsonTextReader(sr);
                    //对读取出的Json.net的reader流进行反序列化，并装载到模型中
                    _tenants = JsonSerializer.Create().Deserialize<List<Tenant>>(reader);
                }
                catch (Exception ex)
                {

                }
            }

            #endregion

            #region 2、后期从redis中读取



            #endregion

        }

        #endregion

        #region 接口方法覆写

        /// <summary>
        /// 获取租户信息
        /// </summary>
        /// <returns></returns>
        public Tenant GetTenant()
        {
            return _tenant;
        }

        /// <summary>
        /// 应用程序编号
        /// </summary>
        /// <returns></returns>
        public string GetAppId()
        {
            return _appId;
        }

        /// <summary>
        /// 获取用户编号
        /// </summary>
        /// <returns></returns>
        public string GetUserId()
        {
            return _userId;
        }

        /// <summary>
        /// 获取主机域名应用前缀
        /// </summary>
        /// <returns></returns>
        public string GetHost()
        {
            return _tenant.Host;
        }

        /// <summary>
        /// 获取请求参数
        /// </summary>
        /// <returns></returns>
        public string GetQueryString()
        {
            return _queryString;
        }

        #endregion

    }
}
