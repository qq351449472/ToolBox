using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Model
{
    /// <summary>
    /// API接口响应对象
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 状态,0-成功
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 返回路径
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 返回文字信息 
        /// </summary>
        public object data { get; set; }
    }
}
