using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class G_Worker :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_ShiftId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_WorkAreaId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Int32? F_SortCode{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Boolean? F_DeleteMark{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Boolean? F_EnabledMark{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public DateTime? F_CreatorTime{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_CreatorUserId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public DateTime? F_LastModifyTime{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_LastModifyUserId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public DateTime? F_DeleteTime{get;set;}
	  ///<summary>
	  ///
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
            if (this.F_ShiftId != null && 50 < this.F_ShiftId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ShiftId should not be greater then 50!");
            }
            if (this.F_WorkAreaId != null && 50 < this.F_WorkAreaId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_WorkAreaId should not be greater then 50!");
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
