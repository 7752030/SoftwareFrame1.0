using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-10 18:15
    /// 描 述：任务日志实体类
    /// </summary>
    [Table("task_record")]
    public class RecordEntity : BaseEntity
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        /// <returns></returns>
        public string BillNo { get; set; }
        /// <summary>
        /// 任务单关联字段
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TaskOrderId { get; set; }
        /// <summary>
        /// 任务单编号
        /// </summary>
        /// <returns></returns>
        public string TaskOrderNo { get; set; }
        /// <summary>
        /// 执行的操作
        /// </summary>
        /// <returns></returns>
        public string OpAction { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? OperatorId { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? OpTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Mark { get; set; }
    }
}
