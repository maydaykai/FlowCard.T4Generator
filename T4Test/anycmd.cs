﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//     生成时间 2017-03-30 14:57:49 by mayday
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
namespace T4ConsoleApplication.Entities
{    

    public class Account
    {
        
        /// <summary>
        /// 主键
        /// </summary>        
        public Guid Id { get; set; }
        
        /// <summary>
        /// 数字标识
        /// </summary>        
        public int NumberId { get; set; }
        
        /// <summary>
        /// 登录名
        /// </summary>        
        public string LoginName { get; set; }
        
        /// <summary>
        /// 密码
        /// </summary>        
        public string Password { get; set; }
        
        /// <summary>
        /// 安全等级
        /// </summary>        
        public int? SecurityLevel { get; set; }
        
        /// <summary>
        /// 最后密码修改时间
        /// </summary>        
        public DateTime? LastPasswordChangeOn { get; set; }
        
        /// <summary>
        /// 语言
        /// </summary>        
        public string Lang { get; set; }
        
        /// <summary>
        /// 主题
        /// </summary>        
        public string Theme { get; set; }
        
        /// <summary>
        /// 允许登录开始时间
        /// </summary>        
        public DateTime? AllowStartTime { get; set; }
        
        /// <summary>
        /// 允许登录结束时间
        /// </summary>        
        public DateTime? AllowEndTime { get; set; }
        
        /// <summary>
        /// 锁定登录开始时间
        /// </summary>        
        public DateTime? LockStartTime { get; set; }
        
        /// <summary>
        /// 锁定登录结束时间
        /// </summary>        
        public DateTime? LockEndTime { get; set; }
        
        /// <summary>
        /// 第一次登录时间
        /// </summary>        
        public DateTime? FirstLoginOn { get; set; }
        
        /// <summary>
        /// 上次登录时间
        /// </summary>        
        public DateTime? PreviousLoginOn { get; set; }
        
        /// <summary>
        /// 登录次数
        /// </summary>        
        public int? LoginCount { get; set; }
        
        /// <summary>
        /// 开放标识
        /// </summary>        
        public string OpenId { get; set; }
        
        /// <summary>
        /// Ip地址
        /// </summary>        
        public string IpAddress { get; set; }
        
        /// <summary>
        /// Mac地址
        /// </summary>        
        public string MacAddress { get; set; }
        
        /// <summary>
        /// 安全问题
        /// </summary>        
        public string Question { get; set; }
        
        /// <summary>
        /// 安全问题答案
        /// </summary>        
        public string AnswerQuestion { get; set; }
        
        /// <summary>
        /// 墙纸
        /// </summary>        
        public string Wallpaper { get; set; }
        
        /// <summary>
        /// 背景色
        /// </summary>        
        public string BackColor { get; set; }
        
        /// <summary>
        /// 有效状态
        /// </summary>        
        public int IsEnabled { get; set; }
        
        /// <summary>
        /// 审核状态
        /// </summary>        
        public string AuditState { get; set; }
        
        /// <summary>
        /// 组织结构码
        /// </summary>        
        public string CatalogCode { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>        
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string Nickname { get; set; }
        
        /// <summary>
        /// 编码
        /// </summary>        
        public string Code { get; set; }
        
        /// <summary>
        /// 查询码0。如：姓名、昵称、代号
        /// </summary>        
        public string QuickQuery { get; set; }
        
        /// <summary>
        /// 查询码1。如：姓名、昵称、代号
        /// </summary>        
        public string QuickQuery1 { get; set; }
        
        /// <summary>
        /// 查询码2。如：姓名、昵称、代号
        /// </summary>        
        public string QuickQuery2 { get; set; }
        
        /// <summary>
        /// 银行签名
        /// </summary>        
        public string CommunicationPassword { get; set; }
        
        /// <summary>
        /// 数字签名
        /// </summary>        
        public string SignedPassword { get; set; }
        
        /// <summary>
        /// 防抵赖签名
        /// </summary>        
        public string PublicKey { get; set; }
        
        /// <summary>
        /// 电子邮件
        /// </summary>        
        public string Email { get; set; }
        
        /// <summary>
        /// 手机号码
        /// </summary>        
        public string Mobile { get; set; }
        
        /// <summary>
        /// 固定电话
        /// </summary>        
        public string Telephone { get; set; }
        
        /// <summary>
        /// QQ
        /// </summary>        
        public string Qq { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string BlogUrl { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string AcContentType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string AcContent { get; set; }
        
        /// <summary>
        /// 删除标记
        /// </summary>        
        public int DeletionStateCode { get; set; }
        
        /// <summary>
        /// 说明
        /// </summary>        
        public string Description { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>        
        public DateTime? CreateOn { get; set; }
        
        /// <summary>
        /// 创建人主键
        /// </summary>        
        public Guid? CreateUserId { get; set; }
        
        /// <summary>
        /// 创建人
        /// </summary>        
        public string CreateBy { get; set; }
        
        /// <summary>
        /// 最后修改时间
        /// </summary>        
        public DateTime? ModifiedOn { get; set; }
        
        /// <summary>
        /// 最后修改人主键
        /// </summary>        
        public Guid? ModifiedUserId { get; set; }
        
        /// <summary>
        /// 最后修改人
        /// </summary>        
        public string ModifiedBy { get; set; }
        
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>        
        public Guid RowGuid { get; set; }
        
        /// <summary>
        /// 数据记录版本标识
        /// </summary>        
        public byte[] ETag { get; set; }
         
      
    }
}

