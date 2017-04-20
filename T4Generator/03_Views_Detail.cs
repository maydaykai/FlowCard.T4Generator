
@*--------------------------------------------------------------------
    ------------------------------------------------------------------
    创建时间：2017-04-20 10:04:31 by mayday
    ------------------------------------------------------------------
    ------------------------------------------------------------------*@
@{
    Layout = "~/Views/Shared/_Layout.cshtml";
}

@model Domain.Card_Order
<style type="text/css">
    .gray-bg {
        background-color: white;
    }
</style>
@using (Ajax.BeginForm("Save", null, new AjaxOptions()
{
    HttpMethod = "Post",
    OnBegin = "SubAjax.Loading",
    OnComplete = "SubAjax.Complate",
    OnFailure = "SubAjax.Failure",
    OnSuccess = "SubAjax.Success"
},
new { @class = "form-horizontal dig-from", @role = "form" }))
{
			@Html.HiddenFor(p => p.OrderNumber)
			@Html.HiddenFor(p => p.RegularDinnerId)
			@Html.HiddenFor(p => p.Amount)
			@Html.HiddenFor(p => p.Flowed)
			@Html.HiddenFor(p => p.Quantity)
			@Html.HiddenFor(p => p.TotalAmount)
			@Html.HiddenFor(p => p.UserId)
			@Html.HiddenFor(p => p.Remark)
			@Html.HiddenFor(p => p.ContactName)
			@Html.HiddenFor(p => p.ContactMobile)
			@Html.HiddenFor(p => p.ContactAddress)
			@Html.HiddenFor(p => p.Logistics)
			@Html.HiddenFor(p => p.Invoice)
			@Html.HiddenFor(p => p.Status)
			@Html.HiddenFor(p => p.AuditStatus)
			@Html.HiddenFor(p => p.AuditUserId)
			@Html.HiddenFor(p => p.AuditMsg)
			@Html.HiddenFor(p => p.CreateTime)
			@Html.HiddenFor(p => p.LastUpdate)
	
    <div class="wrapper wrapper-content animated fadeInUp">
        <div class="row">
            <div class="ibox-detail-title">
                <i class="fa fa-pencil-square-o"></i>添加/修改订单
            </div>
            <div class="ibox-content">
                <div class="hr-line-dashed"></div>
                <div class="row">				
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">订单号：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.OrderNumber, new { @class = "form-control", @placeholder = "请输入订单号", @datatype = "*", @nullmsg = "请输入订单号！", @errormsg = "请输入订单号！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">关联套餐表ID：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.RegularDinnerId, new { @class = "form-control", @placeholder = "请输入关联套餐表ID", @datatype = "*", @nullmsg = "请输入关联套餐表ID！", @errormsg = "请输入关联套餐表ID！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">单价(元)：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Amount, new { @class = "form-control", @placeholder = "请输入单价(元)", @datatype = "*", @nullmsg = "请输入单价(元)！", @errormsg = "请输入单价(元)！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">流量：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Flowed, new { @class = "form-control", @placeholder = "请输入流量", @datatype = "*", @nullmsg = "请输入流量！", @errormsg = "请输入流量！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">订购数量：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Quantity, new { @class = "form-control", @placeholder = "请输入订购数量", @datatype = "*", @nullmsg = "请输入订购数量！", @errormsg = "请输入订购数量！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">总价：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.TotalAmount, new { @class = "form-control", @placeholder = "请输入总价", @datatype = "*", @nullmsg = "请输入总价！", @errormsg = "请输入总价！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">下单用户：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.UserId, new { @class = "form-control", @placeholder = "请输入下单用户", @datatype = "*", @nullmsg = "请输入下单用户！", @errormsg = "请输入下单用户！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">订单备注：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Remark, new { @class = "form-control", @placeholder = "请输入订单备注", @datatype = "*", @nullmsg = "请输入订单备注！", @errormsg = "请输入订单备注！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">收货人：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.ContactName, new { @class = "form-control", @placeholder = "请输入收货人", @datatype = "*", @nullmsg = "请输入收货人！", @errormsg = "请输入收货人！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">收货人手机号码：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.ContactMobile, new { @class = "form-control", @placeholder = "请输入收货人手机号码", @datatype = "*", @nullmsg = "请输入收货人手机号码！", @errormsg = "请输入收货人手机号码！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">收货人地址：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.ContactAddress, new { @class = "form-control", @placeholder = "请输入收货人地址", @datatype = "*", @nullmsg = "请输入收货人地址！", @errormsg = "请输入收货人地址！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">快递单号：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Logistics, new { @class = "form-control", @placeholder = "请输入快递单号", @datatype = "*", @nullmsg = "请输入快递单号！", @errormsg = "请输入快递单号！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">发票抬头：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Invoice, new { @class = "form-control", @placeholder = "请输入发票抬头", @datatype = "*", @nullmsg = "请输入发票抬头！", @errormsg = "请输入发票抬头！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">订单状态：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.Status, new { @class = "form-control", @placeholder = "请输入订单状态", @datatype = "*", @nullmsg = "请输入订单状态！", @errormsg = "请输入订单状态！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">审核状态：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.AuditStatus, new { @class = "form-control", @placeholder = "请输入审核状态", @datatype = "*", @nullmsg = "请输入审核状态！", @errormsg = "请输入审核状态！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">审核人：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.AuditUserId, new { @class = "form-control", @placeholder = "请输入审核人", @datatype = "*", @nullmsg = "请输入审核人！", @errormsg = "请输入审核人！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">审核备注：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.AuditMsg, new { @class = "form-control", @placeholder = "请输入审核备注", @datatype = "*", @nullmsg = "请输入审核备注！", @errormsg = "请输入审核备注！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">创建时间：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.CreateTime, new { @class = "form-control", @placeholder = "请输入创建时间", @datatype = "*", @nullmsg = "请输入创建时间！", @errormsg = "请输入创建时间！" })
							</div>
						</div>
					</div>
										<div class="col-xs-6">
						<div class="form-group">
							<label class="col-xs-4 control-label">最后修改时间：</label>
							<div class="col-xs-8">
								@Html.TextBoxFor(p => p.LastUpdate, new { @class = "form-control", @placeholder = "请输入最后修改时间", @datatype = "*", @nullmsg = "请输入最后修改时间！", @errormsg = "请输入最后修改时间！" })
							</div>
						</div>
					</div>
					                </div>
                <div class="hr-line-dashed"></div>
                <div class="hr-line-dashed"></div>
                <div class="text-center">
                    <button class="btn btn-primary btn-save" type="submit"><i class="fa fa-check"></i> <span>确定保存</span></button>
                    <button class="btn btn-warning" id="btn-dig-close" type="button"><i class="fa fa-reply-all"></i> 取消返回</button>
                </div>
            </div>
        </div>
    </div>
}
@section scripts{
    <script type="text/javascript">

    </script>
}