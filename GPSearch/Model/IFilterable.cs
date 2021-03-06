﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSoft.Games.GPMagic.GPSearch.Model
{
    public interface IFilterable
    {
        string FilterString { get; }
        DataRow[] Filter(DataTable table);
    }
}
