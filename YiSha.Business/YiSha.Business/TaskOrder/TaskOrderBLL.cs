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
    /// 日 期：2020-03-10 11:41
    /// 描 述：任务单业务类
    /// </summary>
    public class TaskOrderBLL
    {
        private TaskOrderService taskOrderService = new TaskOrderService();

        #region 获取数据
        public async Task<TData<List<TaskOrderEntity>>> GetList(TaskOrderListParam param)
        {
            TData<List<TaskOrderEntity>> obj = new TData<List<TaskOrderEntity>>();
            obj.Result = await taskOrderService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TaskOrderEntity>>> GetPageList(TaskOrderListParam param, Pagination pagination)
        {
            TData<List<TaskOrderEntity>> obj = new TData<List<TaskOrderEntity>>();
            obj.Result = await taskOrderService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TaskOrderEntity>> GetEntity(long id)
        {
            TData<TaskOrderEntity> obj = new TData<TaskOrderEntity>();
            obj.Result = await taskOrderService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TaskOrderEntity entity)
        {
            TData<string> obj = new TData<string>();
            await taskOrderService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await taskOrderService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
