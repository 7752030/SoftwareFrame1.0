using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.TaskOrder;
using YiSha.Model.Param.TaskOrder;
using YiSha.Service.TaskOrder;

namespace YiSha.Business.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-06-02 16:43
    /// 描 述：任务单业务类
    /// </summary>
    public class TATaskOrderBLL
    {
        private TATaskOrderService tATaskOrderService = new TATaskOrderService();

        #region 获取数据
        public async Task<TData<List<TATaskOrderEntity>>> GetList(TATaskOrderListParam param)
        {
            TData<List<TATaskOrderEntity>> obj = new TData<List<TATaskOrderEntity>>();
            obj.Result = await tATaskOrderService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TATaskOrderEntity>>> GetPageList(TATaskOrderListParam param, Pagination pagination)
        {
            TData<List<TATaskOrderEntity>> obj = new TData<List<TATaskOrderEntity>>();
            obj.Result = await tATaskOrderService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TATaskOrderEntity>> GetEntity(long id)
        {
            TData<TATaskOrderEntity> obj = new TData<TATaskOrderEntity>();
            obj.Result = await tATaskOrderService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TATaskOrderEntity entity)
        {
            TData<string> obj = new TData<string>();
            await tATaskOrderService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await tATaskOrderService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
