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
    /// 日 期：2020-06-02 14:21
    /// 描 述：基础资料-任务类型业务类
    /// </summary>
    public class Ta_TaskTypeBLL
    {
        private Ta_TaskTypeService ta_TaskTypeService = new Ta_TaskTypeService();

        #region 获取数据
        public async Task<TData<List<Ta_TaskTypeEntity>>> GetList(Ta_TaskTypeListParam param)
        {
            TData<List<Ta_TaskTypeEntity>> obj = new TData<List<Ta_TaskTypeEntity>>();
            obj.Result = await ta_TaskTypeService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<Ta_TaskTypeEntity>>> GetPageList(Ta_TaskTypeListParam param, Pagination pagination)
        {
            TData<List<Ta_TaskTypeEntity>> obj = new TData<List<Ta_TaskTypeEntity>>();
            obj.Result = await ta_TaskTypeService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<Ta_TaskTypeEntity>> GetEntity(long id)
        {
            TData<Ta_TaskTypeEntity> obj = new TData<Ta_TaskTypeEntity>();
            obj.Result = await ta_TaskTypeService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(Ta_TaskTypeEntity entity)
        {
            TData<string> obj = new TData<string>();
            await ta_TaskTypeService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await ta_TaskTypeService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
