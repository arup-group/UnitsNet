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

namespace OasysUnits.NumberExtensions.NumberToEnergy
{
    /// <summary>
    /// A number to Energy Extensions
    /// </summary>
    public static class NumberToEnergyExtensions
    {
        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)" />
        public static Energy BritishThermalUnits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromBritishThermalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromCalories(double)" />
        public static Energy Calories<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromCalories(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromDecathermsEc(double)" />
        public static Energy DecathermsEc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromDecathermsEc(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromDecathermsImperial(double)" />
        public static Energy DecathermsImperial<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromDecathermsImperial(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromDecathermsUs(double)" />
        public static Energy DecathermsUs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromDecathermsUs(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromElectronVolts(double)" />
        public static Energy ElectronVolts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromElectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromErgs(double)" />
        public static Energy Ergs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromErgs(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromFootPounds(double)" />
        public static Energy FootPounds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromFootPounds(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigabritishThermalUnits(double)" />
        public static Energy GigabritishThermalUnits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromGigabritishThermalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigaelectronVolts(double)" />
        public static Energy GigaelectronVolts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromGigaelectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigajoules(double)" />
        public static Energy Gigajoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromGigajoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigawattDays(double)" />
        public static Energy GigawattDays<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromGigawattDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigawattHours(double)" />
        public static Energy GigawattHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromGigawattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromHorsepowerHours(double)" />
        public static Energy HorsepowerHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromHorsepowerHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromJoules(double)" />
        public static Energy Joules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromJoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilobritishThermalUnits(double)" />
        public static Energy KilobritishThermalUnits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKilobritishThermalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilocalories(double)" />
        public static Energy Kilocalories<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKilocalories(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKiloelectronVolts(double)" />
        public static Energy KiloelectronVolts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKiloelectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilojoules(double)" />
        public static Energy Kilojoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKilojoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilowattDays(double)" />
        public static Energy KilowattDays<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKilowattDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilowattHours(double)" />
        public static Energy KilowattHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromKilowattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegabritishThermalUnits(double)" />
        public static Energy MegabritishThermalUnits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegabritishThermalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegacalories(double)" />
        public static Energy Megacalories<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegacalories(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegaelectronVolts(double)" />
        public static Energy MegaelectronVolts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegaelectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegajoules(double)" />
        public static Energy Megajoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegajoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegawattDays(double)" />
        public static Energy MegawattDays<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegawattDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegawattHours(double)" />
        public static Energy MegawattHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMegawattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMicrojoules(double)" />
        public static Energy Microjoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMicrojoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMillijoules(double)" />
        public static Energy Millijoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromMillijoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromNanojoules(double)" />
        public static Energy Nanojoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromNanojoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromPetajoules(double)" />
        public static Energy Petajoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromPetajoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromTeraelectronVolts(double)" />
        public static Energy TeraelectronVolts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromTeraelectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromTerajoules(double)" />
        public static Energy Terajoules<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromTerajoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromTerawattDays(double)" />
        public static Energy TerawattDays<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromTerawattDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromTerawattHours(double)" />
        public static Energy TerawattHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromTerawattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromThermsEc(double)" />
        public static Energy ThermsEc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromThermsEc(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromThermsImperial(double)" />
        public static Energy ThermsImperial<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromThermsImperial(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromThermsUs(double)" />
        public static Energy ThermsUs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromThermsUs(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromWattDays(double)" />
        public static Energy WattDays<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromWattDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromWattHours(double)" />
        public static Energy WattHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Energy.FromWattHours(Convert.ToDouble(value));

    }
}
