using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-10 14:08
    /// 描 述：任务状态实体类
    /// </summary>
    [Table("task_status")]
    public class StatusEntity : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        /// <returns></returns>
        public string BillNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Mark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? Operator { get; set; }
    }
}
