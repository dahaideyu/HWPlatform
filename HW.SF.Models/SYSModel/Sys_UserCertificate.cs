using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_UserCertificate :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///关联认证主键
	  ///</summary>
	          public String F_CertificateId{get;set;}
	  ///<summary>
	  ///关联用户主键
	  ///</summary>
	          public String F_UserId{get;set;}
	  ///<summary>
	  ///状态
	  ///</summary>
	          public String F_Status{get;set;}
	  ///<summary>
	  ///认证日期
	  ///</summary>
	          public DateTime? F_StartTime{get;set;}
	  ///<summary>
	  ///认证过期日期
	  ///</summary>
	          public DateTime? F_DeadTime{get;set;}
	  ///<summary>
	  ///临时延期过期日期
	  ///</summary>
	          public DateTime? F_TempDeadTime{get;set;}
	  ///<summary>
	  ///注释
	  ///</summary>
	          public String F_Description{get;set;}
	  ///<summary>
	  ///删除标志
	  ///</summary>
	          public Boolean? F_DeleteMark{get;set;}
	  ///<summary>
	  ///有效标志
	  ///</summary>
	          public Boolean? F_EnabledMark{get;set;}
	  ///<summary>
	  ///创建日期
	  ///</summary>
	          public DateTime? F_CreatorTime{get;set;}
	  ///<summary>
	  ///创建用户主键
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
            if (this.F_CertificateId != null && 50 < this.F_CertificateId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_CertificateId should not be greater then 50!");
            }
            if (this.F_UserId != null && 50 < this.F_UserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_UserId should not be greater then 50!");
            }
            if (this.F_Status != null && 50 < this.F_Status.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Status should not be greater then 50!");
            }
            if (this.F_Description != null && 50 < this.F_Description.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Description should not be greater then 50!");
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
            if (this.F_DeleteUserId != null && 50 < this.F_DeleteUserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DeleteUserId should not be greater then 50!");
            }
            return validatorResult;
        }    
        #endregion
    }
}
