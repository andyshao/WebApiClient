﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    /// <summary>
    /// 定义异常处理的行为
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IHandleTask<TResult> : ITask<TResult>
    {
        /// <summary>
        /// 当捕获到异常时返回指定结果
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="func">获取结果</param>
        /// <returns></returns>
        IHandleTask<TResult> WhenCatch<TException>(Func<TException, TResult> func) where TException : Exception;

        /// <summary>
        /// 当捕获到异常时返回指定结果
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="func">获取结果</param>
        /// <returns></returns>
        IHandleTask<TResult> WhenCatch<TException>(Func<TException, Task<TResult>> func) where TException : Exception;
    }
}
