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
    /// 日 期：2020-06-02 16:43
    /// 描 述：任务单控制器类
    /// </summary>
    [Area("TaskOrder")]
    public class TATaskOrderController :  BaseController
    {
        private TATaskOrderBLL tATaskOrderBLL = new TATaskOrderBLL();

        #region 视图功能
        [AuthorizeFilter("taskorder:tataskorder:view")]
        public ActionResult TATaskOrderIndex()
        {
            return View();
        }

        public ActionResult TATaskOrderForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("taskorder:tataskorder:search")]
        public async Task<ActionResult> GetListJson(TATaskOrderListParam param)
        {
            TData<List<TATaskOrderEntity>> obj = await tATaskOrderBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("taskorder:tataskorder:search")]
        public async Task<ActionResult> GetPageListJson(TATaskOrderListParam param, Pagination pagination)
        {
            TData<List<TATaskOrderEntity>> obj = await tATaskOrderBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TATaskOrderEntity> obj = await tATaskOrderBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("taskorder:tataskorder:add,taskorder:tataskorder:edit")]
        public async Task<ActionResult> SaveFormJson(TATaskOrderEntity entity)
        {
            TData<string> obj = await tATaskOrderBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("taskorder:tataskorder:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await tATaskOrderBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
