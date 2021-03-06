﻿
@*--------------------------------------------------------------------
    ------------------------------------------------------------------
    创建时间：2017-04-18 10:57:37 by mayday
    ------------------------------------------------------------------
    ------------------------------------------------------------------*@
@{
    Layout = "~/Views/Shared/_Layout.cshtml";
}

@model Common.PageInfo
<div class="wrapper wrapper-content animated fadeInUp">
    <div class="row">
        <div class="col-sm-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <h5>订单管理</h5>
                    <div class="ibox-tools">
                        <a class="btn btn-primary btn-xs p210" id="insert" action="add"><i class="fa fa-plus-circle fa-fw"></i> 添加新订单</a>
                        <a class="btn btn-warning btn-xs p210" id="modify" action="edit"><i class="fa fa-pencil fa-fw"></i> 编辑</a>
                        <a class="btn btn-danger btn-xs p210" id="delete" action="remove"><i class="fa fa-trash-o fa-fw"></i> 删除</a>
                        <a class="reload-link" style="color: #c4c4c4" href="javascript:dig.reload()" data-toggle="tooltip" data-placement="left" title="刷新">
                            <i class="fa fa-repeat fa-lg"></i>
                        </a>
                    </div>
                </div>
                <div class="ibox-content">
                    @using (Ajax.BeginForm("Index", null, new AjaxOptions() { }, new { @id = "form1", @class = "form-horizontal", @method = "get" }))
                    {
                        <div class="row">
                            <div class="col-sm-3">
                                <div class="input-group">
                                    @Html.TextBox("Search", null, new { @class = "input-sm form-control", @placeholder = "请输入查询关键词" })
                                    <span class="input-group-btn">
                                        <button type="submit" onclick="submit()" class="btn btn-sm btn-primary"> 搜索</button>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <table id="dataTable" class="table table-striped table-bordered table-hover dataTables-example" style="text-align:center;">
                                <thead>
                                    <tr>
                                        <th class="tn" style="width: 50px !important"><input name="checkall" class="icheck_box" type="checkbox" value=""></th>
																					<th>订单号</th>
																					<th>关联套餐表ID</th>
																					<th>单价(元)</th>
																					<th>流量</th>
																					<th>订购数量</th>
																					<th>总价</th>
																					<th>下单用户</th>
																					<th>订单备注</th>
																					<th>收货人</th>
																					<th>收货人手机号码</th>
																					<th>收货人地址</th>
																					<th>快递单号</th>
																					<th>发票抬头</th>
																					<th>订单状态</th>
																					<th>审核状态</th>
																					<th>审核人</th>
																					<th>审核备注</th>
																					<th>创建时间</th>
																					<th>最后修改时间</th>
										                                    </tr>
                                </thead>
                                <tbody>
                                    @{foreach (var item in Model.List)
                                        {
                                            <tr>
                                                <td class="tn"><input name="checkbox_name" class="icheck_box" type="checkbox" value="@item.RegularDinnerId" /></td>
                                                <td><a href="javascript:EditUser('@item.RegularDinnerId')" listaction="detail" data-toggle="tooltip" data-placement="right" title="修改">@item.Name</a></td>
																									<td>@item.OrderNumber</td>
																									<td>@item.RegularDinnerId</td>
																									<td>@item.Amount</td>
																									<td>@item.Flowed</td>
																									<td>@item.Quantity</td>
																									<td>@item.TotalAmount</td>
																									<td>@item.UserId</td>
																									<td>@item.Remark</td>
																									<td>@item.ContactName</td>
																									<td>@item.ContactMobile</td>
																									<td>@item.ContactAddress</td>
																									<td>@item.Logistics</td>
																									<td>@item.Invoice</td>
																									<td>@item.Status</td>
																									<td>@item.AuditStatus</td>
																									<td>@item.AuditUserId</td>
																									<td>@item.AuditMsg</td>
																									<td>@item.CreateTime</td>
																									<td>@item.LastUpdate</td>
												                                            </tr>
                                        }
                                    }
                                </tbody>
                            </table>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="dataTables_info">
                                    显示 @Model.BeginPage 到 @Model.EndPage 项，共 @Model.Count 项, 每页显示
                                    <select name="example_length" class="form-control input-sm input-xs-sm inline" onchange="submit()">
                                        <option value="10" @(Model.PageSize == 10 ? "selected" : "")>10</option>
                                        <option value="25" @(Model.PageSize == 25 ? "selected" : "")>25</option>
                                        <option value="50" @(Model.PageSize == 50 ? "selected" : "")>50</option>
                                        <option value="100" @(Model.PageSize == 100 ? "selected" : "")>100</option>
                                    </select> 条记录
                                </div>
                            </div>
                            <div class="col-sm-6">
                                @WebPages.CommonHtmlHelper.PaginationPager(Model.Index, Model.PageSize, Model.Count, 7, Model.Url)
                            </div>
                        </div>
                                        }
                </div>
            </div>
        </div>
    </div>
</div>
@section scripts{
    <script type="text/javascript">
        $(function () {
            //添加新订单
            $("#insert").click(function () {
                dig.addPage("添加新订单", "/Card/Order/detail", 600, 450, function () {
                    if (this.returnValue == 'yes') {
                        location.reload();
                    }
                });
            });
            //列表选择修改
            $('#modify').click(function () {
                var vals = '';
                var num = 0;
                $('input[name="checkbox_name"]:checked').each(function () {
                    vals = $(this).val();
                    num++;
                });
                if (!vals) {
                    dig.error("对不起，请选中您要操作的记录！");
                    return;
                }
                if (num > 1) {
                    dig.error("对不起，每次只能修改一条记录！");
                    return;
                }
                dig.addPage("编辑订单", "/Card/Order/detail/" + vals, 600, 450, function () {
                    if (this.returnValue == 'yes') {
                        location.reload();
                    }
                });
            });
           
        });
        //跳转修改
        function EditUser(n) {
            dig.addPage("编辑订单", '@Html.Action("Detail", "Order")' + n, 600, 450, function () {
                if (this.returnValue == 'yes') {
                    location.reload();
                }
            });
        }
    </script>
}
