using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_Material :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///编码
	  ///</summary>
	          public String F_EnCode{get;set;}
	  ///<summary>
	  ///名称
	  ///</summary>
	          public String F_FullName{get;set;}
	  ///<summary>
	  ///版本
	  ///</summary>
	          public String F_Version{get;set;}
	  ///<summary>
	  ///类型
	  ///</summary>
	          public String F_Type{get;set;}
	  ///<summary>
	  ///线别
	  ///</summary>
	          public String F_Line{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Boolean? F_NeedCertification{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Unit{get;set;}
	  ///<summary>
	  ///描述
	  ///</summary>
	          public String F_Description{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_DefualtRouteId{get;set;}
	  ///<summary>
	  ///每个任务的数量
	  ///</summary>
	          public Int32? F_TaskQty{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_Runtime{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_Cost{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_OPH{get;set;}
	  ///<summary>
	  ///是否叫料
	  ///</summary>
	          public Boolean? F_IsCall{get;set;}
	  ///<summary>
	  ///安全库存
	  ///</summary>
	          public Decimal? F_SafetyStock{get;set;}
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
            if (this.F_EnCode != null && 50 < this.F_EnCode.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_EnCode should not be greater then 50!");
            }
            if (this.F_FullName != null && 300 < this.F_FullName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FullName should not be greater then 300!");
            }
            if (this.F_Version != null && 50 < this.F_Version.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Version should not be greater then 50!");
            }
            if (this.F_Type != null && 50 < this.F_Type.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Type should not be greater then 50!");
            }
            if (this.F_Line != null && 50 < this.F_Line.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Line should not be greater then 50!");
            }
            if (this.F_Unit != null && 50 < this.F_Unit.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Unit should not be greater then 50!");
            }
            if (this.F_Description != null && 500 < this.F_Description.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Description should not be greater then 500!");
            }
            if (this.F_DefualtRouteId != null && 50 < this.F_DefualtRouteId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DefualtRouteId should not be greater then 50!");
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
