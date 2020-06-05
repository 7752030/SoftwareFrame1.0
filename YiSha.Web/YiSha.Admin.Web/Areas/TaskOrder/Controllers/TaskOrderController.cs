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
    /// 日 期：2020-03-10 11:41
    /// 描 述：任务单控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class TaskOrderController :  BaseController
    {
        private TaskOrderBLL taskOrderBLL = new TaskOrderBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:taskorder:view")]
        public ActionResult TaskOrderIndex()
        {
            return View();
        }

        public ActionResult TaskOrderForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:taskorder:search")]
        public async Task<ActionResult> GetListJson(TaskOrderListParam param)
        {
            TData<List<TaskOrderEntity>> obj = await taskOrderBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:taskorder:search")]
        public async Task<ActionResult> GetPageListJson(TaskOrderListParam param, Pagination pagination)
        {
            TData<List<TaskOrderEntity>> obj = await taskOrderBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TaskOrderEntity> obj = await taskOrderBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:taskorder:add,taskorder:taskorder:edit")]
        public async Task<ActionResult> SaveFormJson(TaskOrderEntity entity)
        {
            TData<string> obj = await taskOrderBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:taskorder:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await taskOrderBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
