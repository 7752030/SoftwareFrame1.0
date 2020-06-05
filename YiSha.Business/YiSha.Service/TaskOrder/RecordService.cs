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
    /// 日 期：2020-03-10 18:15
    /// 描 述：任务日志服务类
    /// </summary>
    public class RecordService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<RecordEntity>> GetList(RecordListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<RecordEntity>> GetPageList(RecordListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<RecordEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<RecordEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(RecordEntity entity)
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
            await this.BaseRepository().Delete<RecordEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<RecordEntity, bool>> ListFilter(RecordListParam param)
        {
            var expression = LinqExtensions.True<RecordEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
