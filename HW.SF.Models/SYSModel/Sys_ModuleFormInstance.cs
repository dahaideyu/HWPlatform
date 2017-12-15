using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_ModuleFormInstance :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///表单实例主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///表单主键
	  ///</summary>
	          public String F_FormId{get;set;}
	  ///<summary>
	  ///对象主键
	  ///</summary>
	          public String F_ObjectId{get;set;}
	  ///<summary>
	  ///表单实例Json
	  ///</summary>
	          public String F_InstanceJson{get;set;}
	  ///<summary>
	  ///排序码
	  ///</summary>
	          public Int32? F_SortCode{get;set;}
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
            if (string.IsNullOrEmpty(this.F_FormId))
            {
                validatorResult = false;
                this.ErrorList.Add("The F_FormId should not be empty!");
            }
            if (this.F_FormId != null && 50 < this.F_FormId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FormId should not be greater then 50!");
            }
            if (this.F_ObjectId != null && 50 < this.F_ObjectId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ObjectId should not be greater then 50!");
            }
            if (this.F_InstanceJson != null && 2147483647 < this.F_InstanceJson.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_InstanceJson should not be greater then 2147483647!");
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
