using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-10 11:16
    /// 描 述：任务类型实体类
    /// </summary>
    [Table("ta_task_type")]
    public class TaskTypeEntity : BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        /// <returns></returns>
        public string BillNo { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        /// <returns></returns>
        public string DocumentStatus { get; set; }
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
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Mark { get; set; }
    }
}
