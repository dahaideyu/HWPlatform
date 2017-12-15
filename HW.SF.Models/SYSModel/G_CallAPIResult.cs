using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class G_CallAPIResult :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///主表主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Source{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Type{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Boolean? F_SuccessFlag{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_MaterialId{get;set;}
	  ///<summary>
	  ///料号
	  ///</summary>
	          public String F_MaterialNo{get;set;}
	  ///<summary>
	  ///backflush库位
	  ///</summary>
	          public String F_Location{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_Qty{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Address{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_PartNo{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Request{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Result{get;set;}
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
            if (this.F_Source != null && 50 < this.F_Source.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Source should not be greater then 50!");
            }
            if (this.F_Type != null && 50 < this.F_Type.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Type should not be greater then 50!");
            }
            if (this.F_MaterialId != null && 50 < this.F_MaterialId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MaterialId should not be greater then 50!");
            }
            if (this.F_MaterialNo != null && 50 < this.F_MaterialNo.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MaterialNo should not be greater then 50!");
            }
            if (this.F_Location != null && 50 < this.F_Location.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Location should not be greater then 50!");
            }
            if (this.F_Address != null && 500 < this.F_Address.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Address should not be greater then 500!");
            }
            if (this.F_PartNo != null && 50 < this.F_PartNo.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_PartNo should not be greater then 50!");
            }
            if (this.F_Request != null && 1073741823 < this.F_Request.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Request should not be greater then 1073741823!");
            }
            if (this.F_Result != null && 1073741823 < this.F_Result.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Result should not be greater then 1073741823!");
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
