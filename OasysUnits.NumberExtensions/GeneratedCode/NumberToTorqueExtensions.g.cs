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

namespace OasysUnits.NumberExtensions.NumberToTorque
{
    /// <summary>
    /// A number to Torque Extensions
    /// </summary>
    public static class NumberToTorqueExtensions
    {
        /// <inheritdoc cref="Torque.FromGramForceCentimeters(double)" />
        public static Torque GramForceCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromGramForceCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromGramForceMeters(double)" />
        public static Torque GramForceMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromGramForceMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromGramForceMillimeters(double)" />
        public static Torque GramForceMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromGramForceMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilogramForceCentimeters(double)" />
        public static Torque KilogramForceCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilogramForceCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilogramForceMeters(double)" />
        public static Torque KilogramForceMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilogramForceMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilogramForceMillimeters(double)" />
        public static Torque KilogramForceMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilogramForceMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilonewtonCentimeters(double)" />
        public static Torque KilonewtonCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilonewtonCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilonewtonMeters(double)" />
        public static Torque KilonewtonMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilonewtonMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilonewtonMillimeters(double)" />
        public static Torque KilonewtonMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilonewtonMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilopoundForceFeet(double)" />
        public static Torque KilopoundForceFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilopoundForceFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromKilopoundForceInches(double)" />
        public static Torque KilopoundForceInches<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromKilopoundForceInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromMeganewtonCentimeters(double)" />
        public static Torque MeganewtonCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromMeganewtonCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromMeganewtonMeters(double)" />
        public static Torque MeganewtonMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromMeganewtonMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromMeganewtonMillimeters(double)" />
        public static Torque MeganewtonMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromMeganewtonMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromMegapoundForceFeet(double)" />
        public static Torque MegapoundForceFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromMegapoundForceFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromMegapoundForceInches(double)" />
        public static Torque MegapoundForceInches<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromMegapoundForceInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromNewtonCentimeters(double)" />
        public static Torque NewtonCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromNewtonCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromNewtonMeters(double)" />
        public static Torque NewtonMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromNewtonMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromNewtonMillimeters(double)" />
        public static Torque NewtonMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromNewtonMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromPoundalFeet(double)" />
        public static Torque PoundalFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromPoundalFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromPoundForceFeet(double)" />
        public static Torque PoundForceFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromPoundForceFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromPoundForceInches(double)" />
        public static Torque PoundForceInches<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromPoundForceInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromTonneForceCentimeters(double)" />
        public static Torque TonneForceCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromTonneForceCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromTonneForceMeters(double)" />
        public static Torque TonneForceMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromTonneForceMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Torque.FromTonneForceMillimeters(double)" />
        public static Torque TonneForceMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Torque.FromTonneForceMillimeters(Convert.ToDouble(value));

    }
}
