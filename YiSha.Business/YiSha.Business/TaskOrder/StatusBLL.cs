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
    /// 日 期：2020-03-10 14:08
    /// 描 述：任务状态业务类
    /// </summary>
    public class StatusBLL
    {
        private StatusService statusService = new StatusService();

        #region 获取数据
        public async Task<TData<List<StatusEntity>>> GetList(StatusListParam param)
        {
            TData<List<StatusEntity>> obj = new TData<List<StatusEntity>>();
            obj.Result = await statusService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<StatusEntity>>> GetPageList(StatusListParam param, Pagination pagination)
        {
            TData<List<StatusEntity>> obj = new TData<List<StatusEntity>>();
            obj.Result = await statusService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<StatusEntity>> GetEntity(long id)
        {
            TData<StatusEntity> obj = new TData<StatusEntity>();
            obj.Result = await statusService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(StatusEntity entity)
        {
            TData<string> obj = new TData<string>();
            await statusService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await statusService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
