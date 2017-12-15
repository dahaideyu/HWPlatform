using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_Bom :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///主表主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///父级
	  ///</summary>
	          public String F_ParentId{get;set;}
	  ///<summary>
	  ///物料Id
	  ///</summary>
	          public String F_MaterialId{get;set;}
	  ///<summary>
	  ///组成一个主物料需要子物料的数量
	  ///</summary>
	          public Decimal? F_QTY{get;set;}
	  ///<summary>
	  ///物料Id
	  ///</summary>
	          public String F_Unit{get;set;}
	  ///<summary>
	  ///树型
	  ///</summary>
	          public Boolean? F_IsTree{get;set;}
	  ///<summary>
	  ///层次
	  ///</summary>
	          public Int32? F_Layers{get;set;}
	  ///<summary>
	  ///是否叫料
	  ///</summary>
	          public Boolean? F_IsCallMaterial{get;set;}
	  ///<summary>
	  ///向MHS叫料时候，多领的buffer
	  ///</summary>
	          public Decimal? F_Buffer{get;set;}
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
            if (this.F_ParentId != null && 50 < this.F_ParentId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ParentId should not be greater then 50!");
            }
            if (this.F_MaterialId != null && 50 < this.F_MaterialId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MaterialId should not be greater then 50!");
            }
            if (this.F_Unit != null && 20 < this.F_Unit.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Unit should not be greater then 20!");
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
