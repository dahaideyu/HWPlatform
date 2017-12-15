using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_Log :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///日志主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///日期
	  ///</summary>
	          public DateTime? F_Date{get;set;}
	  ///<summary>
	  ///用户名
	  ///</summary>
	          public String F_Account{get;set;}
	  ///<summary>
	  ///姓名
	  ///</summary>
	          public String F_NickName{get;set;}
	  ///<summary>
	  ///类型
	  ///</summary>
	          public String F_Type{get;set;}
	  ///<summary>
	  ///IP地址
	  ///</summary>
	          public String F_IPAddress{get;set;}
	  ///<summary>
	  ///IP所在城市
	  ///</summary>
	          public String F_IPAddressName{get;set;}
	  ///<summary>
	  ///系统模块Id
	  ///</summary>
	          public String F_ModuleId{get;set;}
	  ///<summary>
	  ///系统模块
	  ///</summary>
	          public String F_ModuleName{get;set;}
	  ///<summary>
	  ///结果
	  ///</summary>
	          public Boolean? F_Result{get;set;}
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
            if (this.F_NickName != null && 50 < this.F_NickName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_NickName should not be greater then 50!");
            }
            if (this.F_Type != null && 50 < this.F_Type.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Type should not be greater then 50!");
            }
            if (this.F_IPAddress != null && 50 < this.F_IPAddress.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_IPAddress should not be greater then 50!");
            }
            if (this.F_IPAddressName != null && 50 < this.F_IPAddressName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_IPAddressName should not be greater then 50!");
            }
            if (this.F_ModuleId != null && 50 < this.F_ModuleId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ModuleId should not be greater then 50!");
            }
            if (this.F_ModuleName != null && 50 < this.F_ModuleName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ModuleName should not be greater then 50!");
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
            return validatorResult;
        }    
        #endregion
    }
}
