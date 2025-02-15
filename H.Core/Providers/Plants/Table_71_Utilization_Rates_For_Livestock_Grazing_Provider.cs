﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H.Core.Enumerations;
using H.Infrastructure;

namespace H.Core.Providers.Plants
{
    /// <summary>
    /// Table 71: Utilization rate lookup table for livestock grazing.
    /// 
    /// A revised utilization rate table for grazed systems, where the utilization rate depends on the type of grazed perennial
    /// forage (rather than the grazing regime or stocking density), and this in turn can be used to back-calculate aboveground pasture biomass.
    /// </summary>
    public class Table_71_Utilization_Rates_For_Livestock_Grazing_Provider
    {
        public double GetUtilizationRate(CropType cropType)
        {
            switch (cropType)
            {
                case CropType.RangelandNative:
                    return 45;
                case CropType.SeededGrassland:
                    return 50;

                case CropType.TameGrass:
                case CropType.TameLegume:
                case CropType.TameMixed:
                    return 60;

                default:
                {
                    Trace.TraceError($"No data found for '{cropType.GetDescription()}'");

                    return 0;
                }
            }
        }
    }
}
