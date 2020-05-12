﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Atlass.Framework.Common;
using Atlass.Framework.Models;
using Atlass.Framework.ViewModels.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Atlass.Framework.AppService.Cms
{


    public partial class cms_channelAppService {
        private readonly IFreeSql Sqldb;
        public cms_channelAppService(IServiceProvider service)
        {
            Sqldb = service.GetRequiredService<IFreeSql>();
        }


        /// <summary>
        ///获取数据列表
        /// </summary>
        /// <param name="param"></param>

        public BootstrapGridDto GetData(BootstrapGridDto param)
        {
            long total = 0;
            var query = Sqldb.Select<cms_channel>()
                    .OrderBy(s => s.insert_time)
                .Page(param.page, param.limit)
                .Count(out total)
                .ToList();

            param.total = total;
            param.rows = query;
            return param;
        }

        /// <summary>
        ///新增数据
        /// </summary>
        /// <param name="dto"></param>

        public void Insert(cms_channel dto)
        {
            Sqldb.Insert(dto).ExecuteAffrows();
        }

        /// <summary>
        ///更新数据
        /// </summary>
        /// <param name="dto"></param>

        public void Update(cms_channel dto)
        {
            Sqldb.Update<cms_channel>().SetSource(dto).ExecuteAffrows();
        }

        /// <summary>
        ///获取单条数据
        /// </summary>
        /// <param name="id"></param>

        public cms_channel GetDataById(int id)
        {
            return Sqldb.Select<cms_channel>().Where(s => s.id == id).First();
        }

        /// <summary>
        ///批量删除
        /// </summary>
        /// <param name="ids"></param>

        public void DelByIds(int id)
        {
            Sqldb.Delete<cms_channel>().Where(s => s.id==id).ExecuteAffrows();
        }
    }

}

