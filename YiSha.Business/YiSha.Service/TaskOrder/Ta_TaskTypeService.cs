using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.TaskOrder;
using YiSha.Model.Param.TaskOrder;

namespace YiSha.Service.TaskOrder
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-06-02 14:21
    /// 描 述：基础资料-任务类型服务类
    /// </summary>
    public class Ta_TaskTypeService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<Ta_TaskTypeEntity>> GetList(Ta_TaskTypeListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<Ta_TaskTypeEntity>> GetPageList(Ta_TaskTypeListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<Ta_TaskTypeEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<Ta_TaskTypeEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(Ta_TaskTypeEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<Ta_TaskTypeEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<Ta_TaskTypeEntity, bool>> ListFilter(Ta_TaskTypeListParam param)
        {
            var expression = LinqExtensions.True<Ta_TaskTypeEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
