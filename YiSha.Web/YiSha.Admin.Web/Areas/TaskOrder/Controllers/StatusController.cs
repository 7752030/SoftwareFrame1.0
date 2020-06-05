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
    /// 日 期：2020-03-10 14:08
    /// 描 述：任务状态控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class StatusController :  BaseController
    {
        private StatusBLL statusBLL = new StatusBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:status:view")]
        public ActionResult StatusIndex()
        {
            return View();
        }

        public ActionResult StatusForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:status:search")]
        public async Task<ActionResult> GetListJson(StatusListParam param)
        {
            TData<List<StatusEntity>> obj = await statusBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:status:search")]
        public async Task<ActionResult> GetPageListJson(StatusListParam param, Pagination pagination)
        {
            TData<List<StatusEntity>> obj = await statusBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<StatusEntity> obj = await statusBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:status:add,taskorder:status:edit")]
        public async Task<ActionResult> SaveFormJson(StatusEntity entity)
        {
            TData<string> obj = await statusBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:status:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await statusBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
