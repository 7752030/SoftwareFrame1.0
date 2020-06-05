using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-10 11:41
    /// 描 述：任务单实体类
    /// </summary>
    [Table("ta_task_order")]
    public class TaskOrderEntity : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BillNo { get; set; }
    }
}
