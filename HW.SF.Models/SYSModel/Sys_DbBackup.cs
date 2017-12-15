using System;
using System.Collections.Generic;
using System.Text;
using HW.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW.SF.Models.SYSModel
{

    public class Sys_DbBackup :IBaseModel<string>
    {


        #region Attributes
	  ///<summary>
	  ///备份主键
	  ///</summary>
	  	    [Key]
        [Column("F_Id")]
	          public String F_Id{get;set;}
	  ///<summary>
	  ///备份类型
	  ///</summary>
	          public String F_BackupType{get;set;}
	  ///<summary>
	  ///数据库名称
	  ///</summary>
	          public String F_DbName{get;set;}
	  ///<summary>
	  ///文件名称
	  ///</summary>
	          public String F_FileName{get;set;}
	  ///<summary>
	  ///文件大小
	  ///</summary>
	          public String F_FileSize{get;set;}
	  ///<summary>
	  ///文件路径
	  ///</summary>
	          public String F_FilePath{get;set;}
	  ///<summary>
	  ///备份时间
	  ///</summary>
	          public DateTime? F_BackupTime{get;set;}
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
            if (this.F_BackupType != null && 50 < this.F_BackupType.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_BackupType should not be greater then 50!");
            }
            if (this.F_DbName != null && 50 < this.F_DbName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_DbName should not be greater then 50!");
            }
            if (this.F_FileName != null && 50 < this.F_FileName.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FileName should not be greater then 50!");
            }
            if (this.F_FileSize != null && 50 < this.F_FileSize.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FileSize should not be greater then 50!");
            }
            if (this.F_FilePath != null && 500 < this.F_FilePath.Length)
            {
                validatorResult = false;
                this.ErrorList.Add("The length of F_FilePath should not be greater then 500!");
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
