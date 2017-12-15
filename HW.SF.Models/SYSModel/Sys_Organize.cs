using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_Organize :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///组织主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///父级
	  ///</summary>
	          public String F_ParentId{get;set;}
	  ///<summary>
	  ///层次
	  ///</summary>
	          public Int32? F_Layers{get;set;}
	  ///<summary>
	  ///编码
	  ///</summary>
	          public String F_EnCode{get;set;}
	  ///<summary>
	  ///名称
	  ///</summary>
	          public String F_FullName{get;set;}
	  ///<summary>
	  ///简称
	  ///</summary>
	          public String F_ShortName{get;set;}
	  ///<summary>
	  ///分类
	  ///</summary>
	          public String F_CategoryId{get;set;}
	  ///<summary>
	  ///负责人
	  ///</summary>
	          public String F_ManagerId{get;set;}
	  ///<summary>
	  ///电话
	  ///</summary>
	          public String F_TelePhone{get;set;}
	  ///<summary>
	  ///手机
	  ///</summary>
	          public String F_MobilePhone{get;set;}
	  ///<summary>
	  ///微信
	  ///</summary>
	          public String F_WeChat{get;set;}
	  ///<summary>
	  ///传真
	  ///</summary>
	          public String F_Fax{get;set;}
	  ///<summary>
	  ///邮箱
	  ///</summary>
	          public String F_Email{get;set;}
	  ///<summary>
	  ///归属区域
	  ///</summary>
	          public String F_AreaId{get;set;}
	  ///<summary>
	  ///联系地址
	  ///</summary>
	          public String F_Address{get;set;}
	  ///<summary>
	  ///允许编辑
	  ///</summary>
	          public Boolean? F_AllowEdit{get;set;}
	  ///<summary>
	  ///允许删除
	  ///</summary>
	          public Boolean? F_AllowDelete{get;set;}
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
            if (this.F_ParentId != null && 50 < this.F_ParentId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ParentId should not be greater then 50!");
            }
            if (this.F_EnCode != null && 50 < this.F_EnCode.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_EnCode should not be greater then 50!");
            }
            if (this.F_FullName != null && 50 < this.F_FullName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FullName should not be greater then 50!");
            }
            if (this.F_ShortName != null && 50 < this.F_ShortName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ShortName should not be greater then 50!");
            }
            if (this.F_CategoryId != null && 50 < this.F_CategoryId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_CategoryId should not be greater then 50!");
            }
            if (this.F_ManagerId != null && 50 < this.F_ManagerId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ManagerId should not be greater then 50!");
            }
            if (this.F_TelePhone != null && 20 < this.F_TelePhone.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_TelePhone should not be greater then 20!");
            }
            if (this.F_MobilePhone != null && 20 < this.F_MobilePhone.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MobilePhone should not be greater then 20!");
            }
            if (this.F_WeChat != null && 50 < this.F_WeChat.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_WeChat should not be greater then 50!");
            }
            if (this.F_Fax != null && 20 < this.F_Fax.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Fax should not be greater then 20!");
            }
            if (this.F_Email != null && 50 < this.F_Email.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Email should not be greater then 50!");
            }
            if (this.F_AreaId != null && 50 < this.F_AreaId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_AreaId should not be greater then 50!");
            }
            if (this.F_Address != null && 500 < this.F_Address.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Address should not be greater then 500!");
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
