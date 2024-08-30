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

namespace OasysUnits.NumberExtensions.NumberToInformation
{
    /// <summary>
    /// A number to Information Extensions
    /// </summary>
    public static class NumberToInformationExtensions
    {
        /// <inheritdoc cref="Information.FromBits(double)" />
        public static Information Bits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromBits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromBytes(double)" />
        public static Information Bytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromBytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExabits(double)" />
        public static Information Exabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromExabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExabytes(double)" />
        public static Information Exabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromExabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExbibits(double)" />
        public static Information Exbibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromExbibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExbibytes(double)" />
        public static Information Exbibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromExbibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGibibits(double)" />
        public static Information Gibibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromGibibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGibibytes(double)" />
        public static Information Gibibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromGibibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGigabits(double)" />
        public static Information Gigabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromGigabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGigabytes(double)" />
        public static Information Gigabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromGigabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKibibits(double)" />
        public static Information Kibibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromKibibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKibibytes(double)" />
        public static Information Kibibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromKibibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKilobits(double)" />
        public static Information Kilobits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromKilobits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKilobytes(double)" />
        public static Information Kilobytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromKilobytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMebibits(double)" />
        public static Information Mebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromMebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMebibytes(double)" />
        public static Information Mebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromMebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMegabits(double)" />
        public static Information Megabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromMegabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMegabytes(double)" />
        public static Information Megabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromMegabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPebibits(double)" />
        public static Information Pebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromPebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPebibytes(double)" />
        public static Information Pebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromPebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPetabits(double)" />
        public static Information Petabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromPetabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPetabytes(double)" />
        public static Information Petabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromPetabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTebibits(double)" />
        public static Information Tebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromTebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTebibytes(double)" />
        public static Information Tebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromTebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTerabits(double)" />
        public static Information Terabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromTerabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTerabytes(double)" />
        public static Information Terabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Information.FromTerabytes(Convert.ToDouble(value));

    }
}
