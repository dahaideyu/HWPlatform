using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_Role :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///角色主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///组织主键
	  ///</summary>
	          public String F_OrganizeId{get;set;}
	  ///<summary>
	  ///分类:1-角色2-岗位
	  ///</summary>
	          public Int32? F_Category{get;set;}
	  ///<summary>
	  ///编号
	  ///</summary>
	          public String F_EnCode{get;set;}
	  ///<summary>
	  ///名称
	  ///</summary>
	          public String F_FullName{get;set;}
	  ///<summary>
	  ///类型
	  ///</summary>
	          public String F_Type{get;set;}
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
            if (this.F_OrganizeId != null && 50 < this.F_OrganizeId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_OrganizeId should not be greater then 50!");
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
            if (this.F_Type != null && 50 < this.F_Type.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Type should not be greater then 50!");
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
