using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-06-02 16:43
    /// 描 述：任务单实体类
    /// </summary>
    [Table("T_TA_TaskOrder")]
    public class TATaskOrderEntity : BaseEntity
    {
        /// <summary>
        /// 任务单编码
        /// </summary>
        /// <returns></returns>
        public string TaskNo { get; set; }
        /// <summary>
        /// 订购意向书号
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? OrderNo { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        /// <returns></returns>
        public string DocumentStatus { get; set; }
        /// <summary>
        /// 客户
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CustomerId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CreatorId { get; set; }
        /// <summary>
        /// 创建组织
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? OrgId { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SalOrgId { get; set; }
        /// <summary>
        /// 客户id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CustId { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        /// <returns></returns>
        public string CustAddr { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        /// <returns></returns>
        public string CustTel { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 源单主键-内码
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ScrId { get; set; }
        /// <summary>
        /// 源单明细主键-内码
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ScrEntryId { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        /// <returns></returns>
        public decimal? ExcRate { get; set; }
        /// <summary>
        /// 结算价
        /// </summary>
        /// <returns></returns>
        public decimal? SettlePrice { get; set; }
        /// <summary>
        /// 结算加-本位币
        /// </summary>
        /// <returns></returns>
        public decimal? SettlePriceB { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? MaterialId { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        /// <returns></returns>
        public string MaterialName { get; set; }
        /// <summary>
        /// 计划跟踪号
        /// </summary>
        /// <returns></returns>
        public string MtoNo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public decimal? Qty { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? UnitId { get; set; }
        /// <summary>
        /// 基本单位数量
        /// </summary>
        /// <returns></returns>
        public decimal? BaseQty { get; set; }
        /// <summary>
        /// 基本单位
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? BaseUnitId { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        /// <returns></returns>
        public decimal? SalPrice { get; set; }
        /// <summary>
        /// 销售价-本位币
        /// </summary>
        /// <returns></returns>
        public decimal? SalPriceB { get; set; }
        /// <summary>
        /// 程序号
        /// </summary>
        /// <returns></returns>
        public string ProgramNo { get; set; }
        /// <summary>
        /// 任务状态
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TaskStatus { get; set; }
    }
}
