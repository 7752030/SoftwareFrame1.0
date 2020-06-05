using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.TaskOrder;
using YiSha.Business.TaskOrder;
using YiSha.Model.Param.TaskOrder;

namespace YiSha.Admin.Web.Areas.TaskOrder.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-10 18:15
    /// 描 述：任务日志控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class RecordController :  BaseController
    {
        private RecordBLL recordBLL = new RecordBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:record:view")]
        public ActionResult RecordIndex()
        {
            return View();
        }

        public ActionResult RecordForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:record:search")]
        public async Task<ActionResult> GetListJson(RecordListParam param)
        {
            TData<List<RecordEntity>> obj = await recordBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:record:search")]
        public async Task<ActionResult> GetPageListJson(RecordListParam param, Pagination pagination)
        {
            TData<List<RecordEntity>> obj = await recordBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<RecordEntity> obj = await recordBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:record:add,taskorder:record:edit")]
        public async Task<ActionResult> SaveFormJson(RecordEntity entity)
        {
            TData<string> obj = await recordBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:record:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await recordBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
