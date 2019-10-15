﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace Bing.DependencyInjection
{
    /// <summary>
    /// 依赖注入特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyAttribute : Attribute
    {
        /// <summary>
        /// 声明周期类型，代替
        /// <see cref="DependencyInjection.ISingletonDependency"/>,<see cref="DependencyInjection.IScopedDependency"/>,<see cref="DependencyInjection.ITransientDependency"/>三个接口的作用
        /// </summary>
        public ServiceLifetime Lifetime { get; }

        /// <summary>
        /// 是否为TryAdd方式注册，通常用于默认服务，当服务可被替换时，应设置为true
        /// </summary>
        public bool TryAdd { get; set; }

        /// <summary>
        /// 是否替换已存在的服务实现，通常用于主要服务，当服务存在时即优先使用时，应设置为true
        /// </summary>
        public bool ReplaceExisting { get; set; }

        /// <summary>
        /// 是否注册自身类型，默认没有接口的类型会注册自身，当此属性为true时，也会注册自身
        /// </summary>
        public bool AddSelf { get; set; }

        /// <summary>
        /// 初始化一个<see cref="Dependency.DependencyAttribute"/>类型的实例
        /// </summary>
        /// <param name="lifetime">生命周期类型</param>
        public DependencyAttribute(ServiceLifetime lifetime)
        {
            Lifetime = lifetime;
        }
    }
}
