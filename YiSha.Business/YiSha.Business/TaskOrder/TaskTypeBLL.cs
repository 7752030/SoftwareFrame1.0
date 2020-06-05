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
    /// 日 期：2020-03-10 11:16
    /// 描 述：任务类型业务类
    /// </summary>
    public class TaskTypeBLL
    {
        private TaskTypeService taskTypeService = new TaskTypeService();

        #region 获取数据
        public async Task<TData<List<TaskTypeEntity>>> GetList(TaskTypeListParam param)
        {
            TData<List<TaskTypeEntity>> obj = new TData<List<TaskTypeEntity>>();
            obj.Result = await taskTypeService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TaskTypeEntity>>> GetPageList(TaskTypeListParam param, Pagination pagination)
        {
            TData<List<TaskTypeEntity>> obj = new TData<List<TaskTypeEntity>>();
            obj.Result = await taskTypeService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TaskTypeEntity>> GetEntity(long id)
        {
            TData<TaskTypeEntity> obj = new TData<TaskTypeEntity>();
            obj.Result = await taskTypeService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TaskTypeEntity entity)
        {
            TData<string> obj = new TData<string>();
            await taskTypeService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await taskTypeService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
