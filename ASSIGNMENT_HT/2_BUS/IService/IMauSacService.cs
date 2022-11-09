﻿using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IMauSacService
    {
        string Add(MauSacViews obj);
        string Update(MauSacViews obj);
        string Delete(Guid obj);
  

        List<MauSacViews> GetAll();
    }
}
