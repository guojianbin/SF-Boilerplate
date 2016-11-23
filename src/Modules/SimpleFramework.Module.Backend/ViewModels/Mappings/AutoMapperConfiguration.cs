﻿/*******************************************************************************
* 命名空间: SimpleFramework.Module.Backend.ViewModels.Mappings
*
* 功 能： N/A
* 类 名： AutoMapperConfiguration
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2016/11/23 15:05:11 疯狂蚂蚁 初版
*
* Copyright (c) 2016 SimpleFramework 版权所有
* Description: SimpleFramework快速开发平台
* Website：http://www.mayisite.com
*********************************************************************************/
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFramework.Module.Backend.ViewModels.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DataItemViewModelMappingProfile>();
            });
        }
    }
}
