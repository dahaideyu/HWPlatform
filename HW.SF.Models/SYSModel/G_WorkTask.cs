using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class G_WorkTask :IBaseModel<string>
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
	  ///订单id 按库分配的为空
	  ///</summary>
	          public String F_OrderId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_MaterialId{get;set;}
	  ///<summary>
	  ///任务号码
	  ///</summary>
	          public String F_TaskCode{get;set;}
	  ///<summary>
	  ///物料Id
	  ///</summary>
	          public String F_PartId{get;set;}
	  ///<summary>
	  ///工作区域Id
	  ///</summary>
	          public String F_WorkAreaId{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_ResonType{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_Qty{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_UserId{get;set;}
	  ///<summary>
	  ///主表主键
	  ///</summary>
	          public String F_TravelId{get;set;}
	  ///<summary>
	  /////状态  0、生成、1、缺料,2、缺人,3、缺工位
	  ///</summary>
	          public String F_Lackstate{get;set;}
	  ///<summary>
	  /////状态  0、生成、1、待领取,2、已领取,3、开始生产,4、暂停生产,5、已完成，6、已被产线领走
	  ///</summary>
	          public String F_state{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public DateTime? F_RequireTime{get;set;}
	  ///<summary>
	  ///箱号
	  ///</summary>
	          public String F_BoxNo{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public String F_Description{get;set;}
	  ///<summary>
	  ///工序投入时间
	  ///</summary>
	          public DateTime? F_ProductionStartedTime{get;set;}
	  ///<summary>
	  ///工序产出时间
	  ///</summary>
	          public DateTime? F_ProductionEndTime{get;set;}
	  ///<summary>
	  ///工序产出时间
	  ///</summary>
	          public DateTime? F_PickUpTime{get;set;}
	  ///<summary>
	  ///
	  ///</summary>
	          public Decimal? F_NoGood{get;set;}
	  ///<summary>
	  ///良品
	  ///</summary>
	          public Decimal? F_Good{get;set;}
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
            if (this.F_OrderId != null && 50 < this.F_OrderId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_OrderId should not be greater then 50!");
            }
            if (this.F_MaterialId != null && 50 < this.F_MaterialId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_MaterialId should not be greater then 50!");
            }
            if (this.F_TaskCode != null && 50 < this.F_TaskCode.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_TaskCode should not be greater then 50!");
            }
            if (this.F_PartId != null && 50 < this.F_PartId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_PartId should not be greater then 50!");
            }
            if (this.F_WorkAreaId != null && 50 < this.F_WorkAreaId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_WorkAreaId should not be greater then 50!");
            }
            if (this.F_ResonType != null && 50 < this.F_ResonType.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_ResonType should not be greater then 50!");
            }
            if (this.F_UserId != null && 50 < this.F_UserId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_UserId should not be greater then 50!");
            }
            if (this.F_TravelId != null && 50 < this.F_TravelId.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_TravelId should not be greater then 50!");
            }
            if (this.F_Lackstate != null && 50 < this.F_Lackstate.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Lackstate should not be greater then 50!");
            }
            if (this.F_state != null && 50 < this.F_state.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_state should not be greater then 50!");
            }
            if (this.F_BoxNo != null && 50 < this.F_BoxNo.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_BoxNo should not be greater then 50!");
            }
            if (this.F_Description != null && 4000 < this.F_Description.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_Description should not be greater then 4000!");
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
