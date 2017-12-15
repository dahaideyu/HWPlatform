using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_User :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///用户主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///账户
	  ///</summary>
	          public String F_Account{get;set;}
	  ///<summary>
	  ///姓名
	  ///</summary>
	          public String F_RealName{get;set;}
	  ///<summary>
	  ///呢称
	  ///</summary>
	          public String F_NickName{get;set;}
	  ///<summary>
	  ///头像
	  ///</summary>
	          public String F_HeadIcon{get;set;}
	  ///<summary>
	  ///性别
	  ///</summary>
	          public Boolean? F_Gender{get;set;}
	  ///<summary>
	  ///生日
	  ///</summary>
	          public DateTime? F_Birthday{get;set;}
	  ///<summary>
	  ///手机
	  ///</summary>
	          public String F_MobilePhone{get;set;}
	  ///<summary>
	  ///邮箱
	  ///</summary>
	          public String F_Email{get;set;}
	  ///<summary>
	  ///微信
	  ///</summary>
	          public String F_WeChat{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Line{get;set;}
	  ///<summary>
	  ///主管主键
	  ///</summary>
	          public String F_ManagerId{get;set;}
	  ///<summary>
	  ///安全级别
	  ///</summary>
	          public Int32? F_SecurityLevel{get;set;}
	  ///<summary>
	  ///个性签名
	  ///</summary>
	          public String F_Signature{get;set;}
	  ///<summary>
	  ///组织主键
	  ///</summary>
	          public String F_OrganizeId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_WorkerId{get;set;}
	  ///<summary>
	  ///部门主键
	  ///</summary>
	          public String F_DepartmentId{get;set;}
	  ///<summary>
	  ///角色主键
	  ///</summary>
	          public String F_RoleId{get;set;}
	  ///<summary>
	  ///岗位主键
	  ///</summary>
	          public String F_DutyId{get;set;}
	  ///<summary>
	  ///是否管理员
	  ///</summary>
	          public Boolean? F_IsAdministrator{get;set;}
	  ///<summary>
	  ///排序码
	  ///</summary>
	          public Int32? F_SortCode{get;set;}
	  ///<summary>
	  ///删除标志
	  ///</summary>
	          public Boolean? F_DeleteMark{get;set;}
	  ///<summary>
	  ///有效标志
	  ///</summary>
	          public Boolean? F_EnabledMark{get;set;}
	  ///<summary>
	  ///描述
	  ///</summary>
	          public String F_Description{get;set;}
	  ///<summary>
	  ///创建时间
	  ///</summary>
	          public DateTime? F_CreatorTime{get;set;}
	  ///<summary>
	  ///创建用户
	  ///</summary>
	          public String F_CreatorUserId{get;set;}
	  ///<summary>
	  ///最后修改时间
	  ///</summary>
	          public DateTime? F_LastModifyTime{get;set;}
	  ///<summary>
	  ///最后修改用户
	  ///</summary>
	          public String F_LastModifyUserId{get;set;}
	  ///<summary>
	  ///删除时间
	  ///</summary>
	          public DateTime? F_DeleteTime{get;set;}
	  ///<summary>
	  ///删除用户
	  ///</summary>
	          public String F_DeleteUserId{get;set;}
        #endregion

        #region Validator
        public List<string> ErrorList = new List<string>();
        private bool Validator()
        {    
            bool validatorResult = true;
            if (string.IsNullOrEmpty(this.F_Id))
            {
                validatorResult = false;
                this.ErrorList.Add("The F_Id should not be empty!");
            }
            if (this.F_Id != null && 50 < this.F_Id.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Id should not be greater then 50!");
            }
            if (this.F_Account != null && 50 < this.F_Account.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Account should not be greater then 50!");
            }
            if (this.F_RealName != null && 50 < this.F_RealName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_RealName should not be greater then 50!");
            }
            if (this.F_NickName != null && 50 < this.F_NickName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_NickName should not be greater then 50!");
            }
            if (this.F_HeadIcon != null && 50 < this.F_HeadIcon.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_HeadIcon should not be greater then 50!");
            }
            if (this.F_MobilePhone != null && 20 < this.F_MobilePhone.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MobilePhone should not be greater then 20!");
            }
            if (this.F_Email != null && 50 < this.F_Email.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Email should not be greater then 50!");
            }
            if (this.F_WeChat != null && 50 < this.F_WeChat.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_WeChat should not be greater then 50!");
            }
            if (this.F_Line != null && 50 < this.F_Line.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Line should not be greater then 50!");
            }
            if (this.F_ManagerId != null && 50 < this.F_ManagerId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ManagerId should not be greater then 50!");
            }
            if (this.F_Signature != null && 500 < this.F_Signature.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Signature should not be greater then 500!");
            }
            if (this.F_OrganizeId != null && 50 < this.F_OrganizeId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_OrganizeId should not be greater then 50!");
            }
            if (this.F_WorkerId != null && 50 < this.F_WorkerId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_WorkerId should not be greater then 50!");
            }
            if (this.F_DepartmentId != null && 500 < this.F_DepartmentId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DepartmentId should not be greater then 500!");
            }
            if (this.F_RoleId != null && 500 < this.F_RoleId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_RoleId should not be greater then 500!");
            }
            if (this.F_DutyId != null && 500 < this.F_DutyId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DutyId should not be greater then 500!");
            }
            if (this.F_Description != null && 500 < this.F_Description.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Description should not be greater then 500!");
            }
            if (this.F_CreatorUserId != null && 50 < this.F_CreatorUserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_CreatorUserId should not be greater then 50!");
            }
            if (this.F_LastModifyUserId != null && 50 < this.F_LastModifyUserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_LastModifyUserId should not be greater then 50!");
            }
            if (this.F_DeleteUserId != null && 500 < this.F_DeleteUserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DeleteUserId should not be greater then 500!");
            }
            return validatorResult;
        }    
        #endregion
    }
}
