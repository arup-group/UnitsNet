//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/OasysUnits/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnits.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace OasysUnits.NumberExtensions.NumberToApparentEnergy
{
    /// <summary>
    /// A number to ApparentEnergy Extensions
    /// </summary>
    public static class NumberToApparentEnergyExtensions
    {
        /// <inheritdoc cref="ApparentEnergy.FromKilovoltampereHours(double)" />
        public static ApparentEnergy KilovoltampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ApparentEnergy.FromKilovoltampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltampereHours(double)" />
        public static ApparentEnergy MegavoltampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ApparentEnergy.FromMegavoltampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentEnergy.FromVoltampereHours(double)" />
        public static ApparentEnergy VoltampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ApparentEnergy.FromVoltampereHours(Convert.ToDouble(value));

    }
}
