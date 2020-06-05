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
    /// 日 期：2020-03-10 11:16
    /// 描 述：任务类型控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class TaskTypeController :  BaseController
    {
        private TaskTypeBLL taskTypeBLL = new TaskTypeBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:tasktype:view")]
        public ActionResult TaskTypeIndex()
        {
            return View();
        }

        public ActionResult TaskTypeForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:tasktype:search")]
        public async Task<ActionResult> GetListJson(TaskTypeListParam param)
        {
            TData<List<TaskTypeEntity>> obj = await taskTypeBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:tasktype:search")]
        public async Task<ActionResult> GetPageListJson(TaskTypeListParam param, Pagination pagination)
        {
            TData<List<TaskTypeEntity>> obj = await taskTypeBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TaskTypeEntity> obj = await taskTypeBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:tasktype:add,taskorder:tasktype:edit")]
        public async Task<ActionResult> SaveFormJson(TaskTypeEntity entity)
        {
            //对任务单进行自动编号
            if (entity.BillNo == "")
            {
                entity.BillNo = "";
            }
            TData<string> obj = await taskTypeBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:tasktype:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await taskTypeBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
