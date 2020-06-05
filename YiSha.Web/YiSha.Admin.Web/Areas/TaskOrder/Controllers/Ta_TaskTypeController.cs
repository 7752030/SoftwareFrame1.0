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
    /// 日 期：2020-06-02 14:21
    /// 描 述：基础资料-任务类型控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class Ta_TaskTypeController :  BaseController
    {
        private Ta_TaskTypeBLL ta_TaskTypeBLL = new Ta_TaskTypeBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:ta_tasktype:view")]
        public ActionResult Ta_TaskTypeIndex()
        {
            return View();
        }

        public ActionResult Ta_TaskTypeForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:ta_tasktype:search")]
        public async Task<ActionResult> GetListJson(Ta_TaskTypeListParam param)
        {
            TData<List<Ta_TaskTypeEntity>> obj = await ta_TaskTypeBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:ta_tasktype:search")]
        public async Task<ActionResult> GetPageListJson(Ta_TaskTypeListParam param, Pagination pagination)
        {
            TData<List<Ta_TaskTypeEntity>> obj = await ta_TaskTypeBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<Ta_TaskTypeEntity> obj = await ta_TaskTypeBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:ta_tasktype:add,taskorder:ta_tasktype:edit")]
        public async Task<ActionResult> SaveFormJson(Ta_TaskTypeEntity entity)
        {
            TData<string> obj = await ta_TaskTypeBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:ta_tasktype:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await ta_TaskTypeBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
