//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace OasysUnits.NumberExtensions.NumberToElectricConductance
{
    /// <summary>
    /// A number to ElectricConductance Extensions
    /// </summary>
    public static class NumberToElectricConductanceExtensions
    {
        /// <inheritdoc cref="ElectricConductance.FromKilosiemens(double)" />
        public static ElectricConductance Kilosiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductance.FromKilosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromMicrosiemens(double)" />
        public static ElectricConductance Microsiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductance.FromMicrosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromMillisiemens(double)" />
        public static ElectricConductance Millisiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductance.FromMillisiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromNanosiemens(double)" />
        public static ElectricConductance Nanosiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductance.FromNanosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromSiemens(double)" />
        public static ElectricConductance Siemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductance.FromSiemens(Convert.ToDouble(value));

    }
}
