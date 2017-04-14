
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//创建时间：2017-04-14 18:08:20 by mayday
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Web.Mvc;
using Service.IService;
using WebPage.Controllers;
using Common.JsonHelper;

namespace WebPage.Areas.CardManage.Controllers
{
	//订单管理
	public class OrderController : BaseController
    {
		IOrderManage OrderManage { get; set; }
        // GET: CardManage/Order
        /// <summary>
        /// 加载首页
        /// </summary>
        /// <returns></returns>
        [UserAuthorize(ModuleAlias = "Order", OperaAction = "View")]
        public ActionResult Index()
        {
            try
            {
                #region 处理查询参数
                ViewBag.Search = base.keywords;
                #endregion

                return View(BindList());
            }
            catch (Exception e)
            {
                WriteLog(Common.Enums.enumOperator.Select, "订单管理加载主页：", e);
                throw e.InnerException;
            }

        }
		/// <summary>
        /// 加载详情信息
        /// </summary>
        [UserAuthorizeAttribute(ModuleAlias = "Order", OperaAction = "Detail")]
        public ActionResult Detail(string id)
        {
            try
            {
                var _entity = new Domain.Card_Order();
                if (id != null && id != "")
                {
                    _entity = OrderManage.Get(p => p.OrderNumber == id);
                }

                return View(_entity);
            }
            catch (Exception e)
            {
                WriteLog(Common.Enums.enumOperator.Select, "加载订单详情发生错误：", e);
                throw e.InnerException;
            }
        }
		/// <summary>
        /// 保存订单基本信息
        /// </summary>
        [ValidateInput(false)]
        [UserAuthorizeAttribute(ModuleAlias = "Order", OperaAction = "Add,Edit")]
        public ActionResult Save(Domain.Card_Order entity)
        {
            bool isEdit = false;
            var json = new JsonHelper() { Msg = "保存成功", Status = "n" };
            try
            {
				if (entity == null)                
                {
                    json.Msg = "未找到要操作的订单记录";
                    return Json(json);
                }
                if (!string.IsNullOrEmpty(entity.OrderNumber)) //添加
                {
                    entity.OrderNumber = Guid.NewGuid().ToString("N");
                    entity.UserId = this.CurrentUser.Id.ToString();
                    entity.CreateTime = DateTime.Now;
                    entity.LastUpdate = DateTime.Now;
                }
                else //修改
                {
                    entity.UserId = this.CurrentUser.Id.ToString();
                    entity.LastUpdate = DateTime.Now;
                    isEdit = true;
                }
                //检测此用户名是否重复
                //if (!this.RegularDinnerManage.IsExist(p => p.Name.Equals(entity.Name) && p.RegularDinnerId != entity.RegularDinnerId))
                //{
                    //this.RegularDinnerManage.SaveOrUpdate(entity, isEdit);
                    //json.Status = "y";
                //}
                //else
                //{
                    //json.Msg = "订单名称已被使用，请修改后再提交!";
                //}
                if (isEdit)
                {
                    WriteLog(Common.Enums.enumOperator.Edit, "修改订单，结果：" + json.Msg, Common.Enums.enumLog4net.INFO);
                }
                else
                {
                    WriteLog(Common.Enums.enumOperator.Add, "添加订单，结果：" + json.Msg, Common.Enums.enumLog4net.INFO);
                }
            }
            catch (Exception e)
            {
                json.Msg = "保存订单信息发生内部错误！";
                WriteLog(Common.Enums.enumOperator.None, "保存订单错误：", e);
            }
            return Json(json);
        }
		/// <summary>
        /// 分页查询订单列表
        /// </summary>
        private Common.PageInfo BindList()
        {
            //基础数据
            var query = this.OrderManage.LoadAll(null);

            //部门(本部门用户及所有下级部门用户)
            //if (!string.IsNullOrEmpty(DepartId))
            //{
                //var childDepart = this.DepartmentManage.LoadAll(p => p.PARENTID == DepartId).Select(p => p.ID).ToList();
                //query = query.Where(p => p.DPTID == DepartId || childDepart.Any(e => e == p.DPTID));
            //}

            //查询关键字
            //if (!string.IsNullOrEmpty(keywords))
            //{
                //keywords = keywords.ToLower();
                //query = query.Where(p => p.NAME.Contains(keywords) || p.ACCOUNT.Contains(keywords) || p.PINYIN2.Contains(keywords) || p.PINYIN1.Contains(keywords));
            //}
            //排序
            query = query.OrderByDescending(p => p.LastUpdate);
            //分页
            var result = this.OrderManage.Query(query, page, pagesize);

            var list = result.List.Select(p => new
            {
                					p.OrderNumber,
									p.RegularDinnerId,
									p.Amount,
									p.Flowed,
									p.Quantity,
									p.TotalAmount,
									p.UserId,
									p.Remark,
									p.ContactName,
									p.ContactMobile,
									p.ContactAddress,
									p.Logistics,
									p.Invoice,
									p.Status,
									p.AuditStatus,
									p.AuditUserId,
									p.AuditMsg,
									p.CreateTime,
									p.LastUpdate,
							}).ToList();

            return new Common.PageInfo(result.Index, result.PageSize, result.Count, JsonConverter.JsonClass(list));
        }
    }
}