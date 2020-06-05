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
    /// 日 期：2020-03-10 11:41
    /// 描 述：任务单服务类
    /// </summary>
    public class TaskOrderService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TaskOrderEntity>> GetList(TaskOrderListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TaskOrderEntity>> GetPageList(TaskOrderListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TaskOrderEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TaskOrderEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TaskOrderEntity entity)
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
            await this.BaseRepository().Delete<TaskOrderEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TaskOrderEntity, bool>> ListFilter(TaskOrderListParam param)
        {
            var expression = LinqExtensions.True<TaskOrderEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
