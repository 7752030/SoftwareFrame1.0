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
    /// 日 期：2020-03-10 11:16
    /// 描 述：任务类型服务类
    /// </summary>
    public class TaskTypeService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TaskTypeEntity>> GetList(TaskTypeListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TaskTypeEntity>> GetPageList(TaskTypeListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TaskTypeEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TaskTypeEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TaskTypeEntity entity)
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
            await this.BaseRepository().Delete<TaskTypeEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TaskTypeEntity, bool>> ListFilter(TaskTypeListParam param)
        {
            var expression = LinqExtensions.True<TaskTypeEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
