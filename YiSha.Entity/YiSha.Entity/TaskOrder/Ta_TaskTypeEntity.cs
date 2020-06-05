using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-06-02 14:21
    /// 描 述：基础资料-任务类型实体类
    /// </summary>
    [Table("T_JN_TaskStatus")]
    public class Ta_TaskTypeEntity : BaseEntity
    {
        /// <summary>
        /// 编码
        /// </summary>
        /// <returns></returns>
        public string Number { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        /// <returns></returns>
        public string DocumentStatus { get; set; }
        /// <summary>
        /// 禁用状态
        /// </summary>
        /// <returns></returns>
        public string ForbidStatus { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; }
        /// <summary>
        /// 创建组织
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CreateOrg { get; set; }
        /// <summary>
        /// 使用组织
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? UseOrg { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? Creator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 是否系统预置
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? FIsPreset { get; set; }
    }
}
