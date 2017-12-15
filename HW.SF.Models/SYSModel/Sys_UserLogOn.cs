using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_UserLogOn :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///用户登录主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///用户主键
	  ///</summary>
	          public String F_UserId{get;set;}
	  ///<summary>
	  ///用户密码
	  ///</summary>
	          public String F_UserPassword{get;set;}
	  ///<summary>
	  ///用户秘钥
	  ///</summary>
	          public String F_UserSecretkey{get;set;}
	  ///<summary>
	  ///允许登录时间开始
	  ///</summary>
	          public DateTime? F_AllowStartTime{get;set;}
	  ///<summary>
	  ///允许登录时间结束
	  ///</summary>
	          public DateTime? F_AllowEndTime{get;set;}
	  ///<summary>
	  ///暂停用户开始日期
	  ///</summary>
	          public DateTime? F_LockStartDate{get;set;}
	  ///<summary>
	  ///暂停用户结束日期
	  ///</summary>
	          public DateTime? F_LockEndDate{get;set;}
	  ///<summary>
	  ///第一次访问时间
	  ///</summary>
	          public DateTime? F_FirstVisitTime{get;set;}
	  ///<summary>
	  ///上一次访问时间
	  ///</summary>
	          public DateTime? F_PreviousVisitTime{get;set;}
	  ///<summary>
	  ///最后访问时间
	  ///</summary>
	          public DateTime? F_LastVisitTime{get;set;}
	  ///<summary>
	  ///最后修改密码日期
	  ///</summary>
	          public DateTime? F_ChangePasswordDate{get;set;}
	  ///<summary>
	  ///允许同时有多用户登录
	  ///</summary>
	          public Boolean? F_MultiUserLogin{get;set;}
	  ///<summary>
	  ///登录次数
	  ///</summary>
	          public Int32? F_LogOnCount{get;set;}
	  ///<summary>
	  ///在线状态
	  ///</summary>
	          public Boolean? F_UserOnLine{get;set;}
	  ///<summary>
	  ///密码提示问题
	  ///</summary>
	          public String F_Question{get;set;}
	  ///<summary>
	  ///密码提示答案
	  ///</summary>
	          public String F_AnswerQuestion{get;set;}
	  ///<summary>
	  ///是否访问限制
	  ///</summary>
	          public Boolean? F_CheckIPAddress{get;set;}
	  ///<summary>
	  ///系统语言
	  ///</summary>
	          public String F_Language{get;set;}
	  ///<summary>
	  ///系统样式
	  ///</summary>
	          public String F_Theme{get;set;}
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
            if (this.F_UserId != null && 50 < this.F_UserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_UserId should not be greater then 50!");
            }
            if (this.F_UserPassword != null && 50 < this.F_UserPassword.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_UserPassword should not be greater then 50!");
            }
            if (this.F_UserSecretkey != null && 50 < this.F_UserSecretkey.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_UserSecretkey should not be greater then 50!");
            }
            if (this.F_Question != null && 50 < this.F_Question.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Question should not be greater then 50!");
            }
            if (this.F_AnswerQuestion != null && 500 < this.F_AnswerQuestion.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_AnswerQuestion should not be greater then 500!");
            }
            if (this.F_Language != null && 50 < this.F_Language.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Language should not be greater then 50!");
            }
            if (this.F_Theme != null && 50 < this.F_Theme.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Theme should not be greater then 50!");
            }
            return validatorResult;
        }    
        #endregion
    }
}
