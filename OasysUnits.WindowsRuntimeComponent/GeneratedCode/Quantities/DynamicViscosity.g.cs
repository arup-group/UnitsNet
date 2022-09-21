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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using OasysUnits.Units;
using OasysUnits.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace OasysUnits
{
    /// <summary>
    ///     The dynamic (shear) viscosity of a fluid expresses its resistance to shearing flows, where adjacent layers move parallel to each other with different speeds
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Viscosity#Dynamic_.28shear.29_viscosity
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class DynamicViscosity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DynamicViscosityUnit? _unit;

        static DynamicViscosity()
        {
            BaseDimensions = new BaseDimensions(-1, 1, -1, 0, 0, 0, 0);
            BaseUnit = DynamicViscosityUnit.NewtonSecondPerMeterSquared;
            MaxValue = new DynamicViscosity(double.MaxValue, BaseUnit);
            MinValue = new DynamicViscosity(double.MinValue, BaseUnit);
            QuantityType = QuantityType.DynamicViscosity;
            Units = Enum.GetValues(typeof(DynamicViscosityUnit)).Cast<DynamicViscosityUnit>().Except(new DynamicViscosityUnit[]{ DynamicViscosityUnit.Undefined }).ToArray();
            Zero = new DynamicViscosity(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.DynamicViscosity, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit NewtonSecondPerMeterSquared.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public DynamicViscosity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private DynamicViscosity(double value, DynamicViscosityUnit unit)
        {
            if (unit == DynamicViscosityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of DynamicViscosity, which is NewtonSecondPerMeterSquared. All conversions go via this value.
        /// </summary>
        public static DynamicViscosityUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of DynamicViscosity
        /// </summary>
        public static DynamicViscosity MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of DynamicViscosity
        /// </summary>
        public static DynamicViscosity MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the DynamicViscosity quantity.
        /// </summary>
        public static DynamicViscosityUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit NewtonSecondPerMeterSquared.
        /// </summary>
        public static DynamicViscosity Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public DynamicViscosityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => DynamicViscosity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => DynamicViscosity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Centipoise"/>
        /// </summary>
        public double Centipoise => As(DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.MicropascalSecond"/>
        /// </summary>
        public double MicropascalSeconds => As(DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.MillipascalSecond"/>
        /// </summary>
        public double MillipascalSeconds => As(DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.NewtonSecondPerMeterSquared"/>
        /// </summary>
        public double NewtonSecondsPerMeterSquared => As(DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PascalSecond"/>
        /// </summary>
        public double PascalSeconds => As(DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Poise"/>
        /// </summary>
        public double Poise => As(DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareFoot"/>
        /// </summary>
        public double PoundsForceSecondPerSquareFoot => As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareInch"/>
        /// </summary>
        public double PoundsForceSecondPerSquareInch => As(DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundPerFootSecond"/>
        /// </summary>
        public double PoundsPerFootSecond => As(DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Reyn"/>
        /// </summary>
        public double Reyns => As(DynamicViscosityUnit.Reyn);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.Centipoise, new CultureInfo("en-US"), false, true, new string[]{"cP"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.MicropascalSecond, new CultureInfo("en-US"), false, true, new string[]{"µPa·s", "µPaS"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.MillipascalSecond, new CultureInfo("en-US"), false, true, new string[]{"mPa·s", "mPaS"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.NewtonSecondPerMeterSquared, new CultureInfo("en-US"), false, true, new string[]{"Ns/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.PascalSecond, new CultureInfo("en-US"), false, true, new string[]{"Pa·s", "PaS"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.Poise, new CultureInfo("en-US"), false, true, new string[]{"P"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, new CultureInfo("en-US"), false, true, new string[]{"lbf·s/ft²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.PoundForceSecondPerSquareInch, new CultureInfo("en-US"), false, true, new string[]{"lbf·s/in²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.PoundPerFootSecond, new CultureInfo("en-US"), false, true, new string[]{"lb/ft·s"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DynamicViscosityUnit.Reyn, new CultureInfo("en-US"), false, true, new string[]{"reyn"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(DynamicViscosityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(DynamicViscosityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Centipoise"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromCentipoise(double centipoise)
        {
            double value = (double) centipoise;
            return new DynamicViscosity(value, DynamicViscosityUnit.Centipoise);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.MicropascalSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromMicropascalSeconds(double micropascalseconds)
        {
            double value = (double) micropascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.MicropascalSecond);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.MillipascalSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromMillipascalSeconds(double millipascalseconds)
        {
            double value = (double) millipascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.MillipascalSecond);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.NewtonSecondPerMeterSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromNewtonSecondsPerMeterSquared(double newtonsecondspermetersquared)
        {
            double value = (double) newtonsecondspermetersquared;
            return new DynamicViscosity(value, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PascalSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromPascalSeconds(double pascalseconds)
        {
            double value = (double) pascalseconds;
            return new DynamicViscosity(value, DynamicViscosityUnit.PascalSecond);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Poise"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromPoise(double poise)
        {
            double value = (double) poise;
            return new DynamicViscosity(value, DynamicViscosityUnit.Poise);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromPoundsForceSecondPerSquareFoot(double poundsforcesecondpersquarefoot)
        {
            double value = (double) poundsforcesecondpersquarefoot;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromPoundsForceSecondPerSquareInch(double poundsforcesecondpersquareinch)
        {
            double value = (double) poundsforcesecondpersquareinch;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareInch);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundPerFootSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromPoundsPerFootSecond(double poundsperfootsecond)
        {
            double value = (double) poundsperfootsecond;
            return new DynamicViscosity(value, DynamicViscosityUnit.PoundPerFootSecond);
        }

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Reyn"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static DynamicViscosity FromReyns(double reyns)
        {
            double value = (double) reyns;
            return new DynamicViscosity(value, DynamicViscosityUnit.Reyn);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DynamicViscosityUnit" /> to <see cref="DynamicViscosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>DynamicViscosity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static DynamicViscosity From(double value, DynamicViscosityUnit fromUnit)
        {
            return new DynamicViscosity((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="OasysUnitsException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="OasysUnitsException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static DynamicViscosity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="OasysUnitsException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="OasysUnitsException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static DynamicViscosity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<DynamicViscosity, DynamicViscosityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out DynamicViscosity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out DynamicViscosity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<DynamicViscosity, DynamicViscosityUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="OasysUnitsException">Error parsing string.</exception>
        public static DynamicViscosityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="OasysUnitsException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static DynamicViscosityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<DynamicViscosityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out DynamicViscosityUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out DynamicViscosityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<DynamicViscosityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is DynamicViscosity objDynamicViscosity)) throw new ArgumentException("Expected type DynamicViscosity.", nameof(obj));

            return CompareTo(objDynamicViscosity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(DynamicViscosity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is DynamicViscosity objDynamicViscosity))
                return false;

            return Equals(objDynamicViscosity);
        }

        public bool Equals(DynamicViscosity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another DynamicViscosity within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(DynamicViscosity other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return OasysUnits.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current DynamicViscosity.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((DynamicViscosityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(DynamicViscosityUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this DynamicViscosity to another DynamicViscosity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A DynamicViscosity with the specified unit.</returns>
        public DynamicViscosity ToUnit(DynamicViscosityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new DynamicViscosity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case DynamicViscosityUnit.Centipoise: return (_value / 10) * 1e-2d;
                case DynamicViscosityUnit.MicropascalSecond: return (_value) * 1e-6d;
                case DynamicViscosityUnit.MillipascalSecond: return (_value) * 1e-3d;
                case DynamicViscosityUnit.NewtonSecondPerMeterSquared: return _value;
                case DynamicViscosityUnit.PascalSecond: return _value;
                case DynamicViscosityUnit.Poise: return _value / 10;
                case DynamicViscosityUnit.PoundForceSecondPerSquareFoot: return _value * 4.7880258980335843e1;
                case DynamicViscosityUnit.PoundForceSecondPerSquareInch: return _value * 6.8947572931683613e3;
                case DynamicViscosityUnit.PoundPerFootSecond: return _value * 1.4881639;
                case DynamicViscosityUnit.Reyn: return _value * 6.8947572931683613e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(DynamicViscosityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case DynamicViscosityUnit.Centipoise: return (baseUnitValue * 10) / 1e-2d;
                case DynamicViscosityUnit.MicropascalSecond: return (baseUnitValue) / 1e-6d;
                case DynamicViscosityUnit.MillipascalSecond: return (baseUnitValue) / 1e-3d;
                case DynamicViscosityUnit.NewtonSecondPerMeterSquared: return baseUnitValue;
                case DynamicViscosityUnit.PascalSecond: return baseUnitValue;
                case DynamicViscosityUnit.Poise: return baseUnitValue * 10;
                case DynamicViscosityUnit.PoundForceSecondPerSquareFoot: return baseUnitValue / 4.7880258980335843e1;
                case DynamicViscosityUnit.PoundForceSecondPerSquareInch: return baseUnitValue / 6.8947572931683613e3;
                case DynamicViscosityUnit.PoundPerFootSecond: return baseUnitValue / 1.4881639;
                case DynamicViscosityUnit.Reyn: return baseUnitValue / 6.8947572931683613e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
