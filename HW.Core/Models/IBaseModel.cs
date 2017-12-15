﻿namespace HW.Core.Models
{
    /// <summary>
    /// 所有数据表实体类都必须实现此接口
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IBaseModel<TKey>
    {
        TKey F_Id { get; set; }
    }
}