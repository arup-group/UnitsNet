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

namespace OasysUnits.NumberExtensions.NumberToCoefficientOfThermalExpansion
{
    /// <summary>
    /// A number to CoefficientOfThermalExpansion Extensions
    /// </summary>
    public static class NumberToCoefficientOfThermalExpansionExtensions
    {
        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPerDegreeCelsius(double)" />
        public static CoefficientOfThermalExpansion PerDegreeCelsius<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPerDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPerDegreeFahrenheit(double)" />
        public static CoefficientOfThermalExpansion PerDegreeFahrenheit<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPerDegreeFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPerKelvin(double)" />
        public static CoefficientOfThermalExpansion PerKelvin<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPerKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPpmPerDegreeCelsius(double)" />
        public static CoefficientOfThermalExpansion PpmPerDegreeCelsius<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPpmPerDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPpmPerDegreeFahrenheit(double)" />
        public static CoefficientOfThermalExpansion PpmPerDegreeFahrenheit<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPpmPerDegreeFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="CoefficientOfThermalExpansion.FromPpmPerKelvin(double)" />
        public static CoefficientOfThermalExpansion PpmPerKelvin<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => CoefficientOfThermalExpansion.FromPpmPerKelvin(Convert.ToDouble(value));

    }
}
