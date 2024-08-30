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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using OasysUnits.Tests.TestsBase;
using OasysUnits.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace OasysUnits.Tests
{
    /// <summary>
    /// Test of Curvature.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CurvatureTestsBase : QuantityTestsBase
    {
        protected abstract double PerCentimetersInOnePerMeter { get; }
        protected abstract double PerFeetInOnePerMeter { get; }
        protected abstract double PerInchesInOnePerMeter { get; }
        protected abstract double PerMetersInOnePerMeter { get; }
        protected abstract double PerMillimetersInOnePerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double PerCentimetersTolerance { get { return 1e-5; } }
        protected virtual double PerFeetTolerance { get { return 1e-5; } }
        protected virtual double PerInchesTolerance { get { return 1e-5; } }
        protected virtual double PerMetersTolerance { get { return 1e-5; } }
        protected virtual double PerMillimetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(CurvatureUnit unit)
        {
            return unit switch
            {
                CurvatureUnit.PerCentimeter => (PerCentimetersInOnePerMeter, PerCentimetersTolerance),
                CurvatureUnit.PerFoot => (PerFeetInOnePerMeter, PerFeetTolerance),
                CurvatureUnit.PerInch => (PerInchesInOnePerMeter, PerInchesTolerance),
                CurvatureUnit.PerMeter => (PerMetersInOnePerMeter, PerMetersTolerance),
                CurvatureUnit.PerMillimeter => (PerMillimetersInOnePerMeter, PerMillimetersTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { CurvatureUnit.PerCentimeter },
            new object[] { CurvatureUnit.PerFoot },
            new object[] { CurvatureUnit.PerInch },
            new object[] { CurvatureUnit.PerMeter },
            new object[] { CurvatureUnit.PerMillimeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Curvature();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(CurvatureUnit.PerMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new Curvature(double.PositiveInfinity, CurvatureUnit.PerMeter));
            var exception2 = Record.Exception(() => new Curvature(double.NegativeInfinity, CurvatureUnit.PerMeter));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new Curvature(double.NaN, CurvatureUnit.PerMeter));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Curvature(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Curvature(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Curvature) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Curvature_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Curvature(1, CurvatureUnit.PerMeter);

            QuantityInfo<CurvatureUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Curvature.Zero, quantityInfo.Zero);
            Assert.Equal("Curvature", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<CurvatureUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void PerMeterToCurvatureUnits()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            AssertEx.EqualTolerance(PerCentimetersInOnePerMeter, permeter.PerCentimeters, PerCentimetersTolerance);
            AssertEx.EqualTolerance(PerFeetInOnePerMeter, permeter.PerFeet, PerFeetTolerance);
            AssertEx.EqualTolerance(PerInchesInOnePerMeter, permeter.PerInches, PerInchesTolerance);
            AssertEx.EqualTolerance(PerMetersInOnePerMeter, permeter.PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(PerMillimetersInOnePerMeter, permeter.PerMillimeters, PerMillimetersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Curvature.From(1, CurvatureUnit.PerCentimeter);
            AssertEx.EqualTolerance(1, quantity00.PerCentimeters, PerCentimetersTolerance);
            Assert.Equal(CurvatureUnit.PerCentimeter, quantity00.Unit);

            var quantity01 = Curvature.From(1, CurvatureUnit.PerFoot);
            AssertEx.EqualTolerance(1, quantity01.PerFeet, PerFeetTolerance);
            Assert.Equal(CurvatureUnit.PerFoot, quantity01.Unit);

            var quantity02 = Curvature.From(1, CurvatureUnit.PerInch);
            AssertEx.EqualTolerance(1, quantity02.PerInches, PerInchesTolerance);
            Assert.Equal(CurvatureUnit.PerInch, quantity02.Unit);

            var quantity03 = Curvature.From(1, CurvatureUnit.PerMeter);
            AssertEx.EqualTolerance(1, quantity03.PerMeters, PerMetersTolerance);
            Assert.Equal(CurvatureUnit.PerMeter, quantity03.Unit);

            var quantity04 = Curvature.From(1, CurvatureUnit.PerMillimeter);
            AssertEx.EqualTolerance(1, quantity04.PerMillimeters, PerMillimetersTolerance);
            Assert.Equal(CurvatureUnit.PerMillimeter, quantity04.Unit);

        }

        [Fact]
        public void FromPerMeters_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => Curvature.FromPerMeters(double.PositiveInfinity));
            var exception2 = Record.Exception(() => Curvature.FromPerMeters(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromPerMeters_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => Curvature.FromPerMeters(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var permeter = Curvature.FromPerMeters(1);
            AssertEx.EqualTolerance(PerCentimetersInOnePerMeter, permeter.As(CurvatureUnit.PerCentimeter), PerCentimetersTolerance);
            AssertEx.EqualTolerance(PerFeetInOnePerMeter, permeter.As(CurvatureUnit.PerFoot), PerFeetTolerance);
            AssertEx.EqualTolerance(PerInchesInOnePerMeter, permeter.As(CurvatureUnit.PerInch), PerInchesTolerance);
            AssertEx.EqualTolerance(PerMetersInOnePerMeter, permeter.As(CurvatureUnit.PerMeter), PerMetersTolerance);
            AssertEx.EqualTolerance(PerMillimetersInOnePerMeter, permeter.As(CurvatureUnit.PerMillimeter), PerMillimetersTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Curvature(value: 1, unit: Curvature.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = Curvature.Parse("1 cm⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PerCentimeters, PerCentimetersTolerance);
                Assert.Equal(CurvatureUnit.PerCentimeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Curvature.Parse("1 ft⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PerFeet, PerFeetTolerance);
                Assert.Equal(CurvatureUnit.PerFoot, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Curvature.Parse("1 in⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PerInches, PerInchesTolerance);
                Assert.Equal(CurvatureUnit.PerInch, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Curvature.Parse("1 m⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PerMeters, PerMetersTolerance);
                Assert.Equal(CurvatureUnit.PerMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Curvature.Parse("1 mm⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PerMillimeters, PerMillimetersTolerance);
                Assert.Equal(CurvatureUnit.PerMillimeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Curvature.TryParse("1 cm⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PerCentimeters, PerCentimetersTolerance);
                Assert.Equal(CurvatureUnit.PerCentimeter, parsed.Unit);
            }

            {
                Assert.True(Curvature.TryParse("1 ft⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PerFeet, PerFeetTolerance);
                Assert.Equal(CurvatureUnit.PerFoot, parsed.Unit);
            }

            {
                Assert.True(Curvature.TryParse("1 in⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PerInches, PerInchesTolerance);
                Assert.Equal(CurvatureUnit.PerInch, parsed.Unit);
            }

            {
                Assert.True(Curvature.TryParse("1 m⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PerMeters, PerMetersTolerance);
                Assert.Equal(CurvatureUnit.PerMeter, parsed.Unit);
            }

            {
                Assert.True(Curvature.TryParse("1 mm⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PerMillimeters, PerMillimetersTolerance);
                Assert.Equal(CurvatureUnit.PerMillimeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Curvature.ParseUnit("cm⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CurvatureUnit.PerCentimeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Curvature.ParseUnit("ft⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CurvatureUnit.PerFoot, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Curvature.ParseUnit("in⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CurvatureUnit.PerInch, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Curvature.ParseUnit("m⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CurvatureUnit.PerMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Curvature.ParseUnit("mm⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CurvatureUnit.PerMillimeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Curvature.TryParseUnit("cm⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CurvatureUnit.PerCentimeter, parsedUnit);
            }

            {
                Assert.True(Curvature.TryParseUnit("ft⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CurvatureUnit.PerFoot, parsedUnit);
            }

            {
                Assert.True(Curvature.TryParseUnit("in⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CurvatureUnit.PerInch, parsedUnit);
            }

            {
                Assert.True(Curvature.TryParseUnit("m⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CurvatureUnit.PerMeter, parsedUnit);
            }

            {
                Assert.True(Curvature.TryParseUnit("mm⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CurvatureUnit.PerMillimeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(CurvatureUnit unit)
        {
            var inBaseUnits = Curvature.From(1.0, Curvature.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(CurvatureUnit unit)
        {
            var quantity = Curvature.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(CurvatureUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Curvature.Units.First(u => u != Curvature.BaseUnit);

            var quantity = Curvature.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(CurvatureUnit unit)
        {
            var quantity = default(Curvature);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            AssertEx.EqualTolerance(1, Curvature.FromPerCentimeters(permeter.PerCentimeters).PerMeters, PerCentimetersTolerance);
            AssertEx.EqualTolerance(1, Curvature.FromPerFeet(permeter.PerFeet).PerMeters, PerFeetTolerance);
            AssertEx.EqualTolerance(1, Curvature.FromPerInches(permeter.PerInches).PerMeters, PerInchesTolerance);
            AssertEx.EqualTolerance(1, Curvature.FromPerMeters(permeter.PerMeters).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(1, Curvature.FromPerMillimeters(permeter.PerMillimeters).PerMeters, PerMillimetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Curvature v = Curvature.FromPerMeters(1);
            AssertEx.EqualTolerance(-1, -v.PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(2, (Curvature.FromPerMeters(3)-v).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(2, (Curvature.FromPerMeters(10)/5).PerMeters, PerMetersTolerance);
            AssertEx.EqualTolerance(2, Curvature.FromPerMeters(10)/Curvature.FromPerMeters(5), PerMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Curvature onePerMeter = Curvature.FromPerMeters(1);
            Curvature twoPerMeters = Curvature.FromPerMeters(2);

            Assert.True(onePerMeter < twoPerMeters);
            Assert.True(onePerMeter <= twoPerMeters);
            Assert.True(twoPerMeters > onePerMeter);
            Assert.True(twoPerMeters >= onePerMeter);

            Assert.False(onePerMeter > twoPerMeters);
            Assert.False(onePerMeter >= twoPerMeters);
            Assert.False(twoPerMeters < onePerMeter);
            Assert.False(twoPerMeters <= onePerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            Assert.Equal(0, permeter.CompareTo(permeter));
            Assert.True(permeter.CompareTo(Curvature.Zero) > 0);
            Assert.True(Curvature.Zero.CompareTo(permeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            Assert.Throws<ArgumentException>(() => permeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            Assert.Throws<ArgumentNullException>(() => permeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, CurvatureUnit.PerMeter, 1, CurvatureUnit.PerMeter, true)]  // Same value and unit.
        [InlineData(1, CurvatureUnit.PerMeter, 2, CurvatureUnit.PerMeter, false)] // Different value.
        [InlineData(2, CurvatureUnit.PerMeter, 1, CurvatureUnit.PerCentimeter, false)] // Different value and unit.
        [InlineData(1, CurvatureUnit.PerMeter, 1, CurvatureUnit.PerCentimeter, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, CurvatureUnit unitA, double valueB, CurvatureUnit unitB, bool expectEqual)
        {
            var a = new Curvature(valueA, unitA);
            var b = new Curvature(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = Curvature.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Curvature.FromPerMeters(1);
            Assert.True(v.Equals(Curvature.FromPerMeters(1), PerMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Curvature.Zero, PerMetersTolerance, ComparisonType.Relative));
            Assert.True(Curvature.FromPerMeters(100).Equals(Curvature.FromPerMeters(120), 0.3, ComparisonType.Relative));
            Assert.False(Curvature.FromPerMeters(100).Equals(Curvature.FromPerMeters(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Curvature.FromPerMeters(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Curvature.FromPerMeters(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            Assert.False(permeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Curvature permeter = Curvature.FromPerMeters(1);
            Assert.False(permeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CurvatureUnit)).Cast<CurvatureUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Curvature.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cm⁻¹", new Curvature(1, CurvatureUnit.PerCentimeter).ToString());
                Assert.Equal("1 ft⁻¹", new Curvature(1, CurvatureUnit.PerFoot).ToString());
                Assert.Equal("1 in⁻¹", new Curvature(1, CurvatureUnit.PerInch).ToString());
                Assert.Equal("1 m⁻¹", new Curvature(1, CurvatureUnit.PerMeter).ToString());
                Assert.Equal("1 mm⁻¹", new Curvature(1, CurvatureUnit.PerMillimeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cm⁻¹", new Curvature(1, CurvatureUnit.PerCentimeter).ToString(swedishCulture));
            Assert.Equal("1 ft⁻¹", new Curvature(1, CurvatureUnit.PerFoot).ToString(swedishCulture));
            Assert.Equal("1 in⁻¹", new Curvature(1, CurvatureUnit.PerInch).ToString(swedishCulture));
            Assert.Equal("1 m⁻¹", new Curvature(1, CurvatureUnit.PerMeter).ToString(swedishCulture));
            Assert.Equal("1 mm⁻¹", new Curvature(1, CurvatureUnit.PerMillimeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s1"));
                Assert.Equal("0.12 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s2"));
                Assert.Equal("0.123 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s3"));
                Assert.Equal("0.1235 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s1", culture));
            Assert.Equal("0.12 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s2", culture));
            Assert.Equal("0.123 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 m⁻¹", new Curvature(0.123456, CurvatureUnit.PerMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Curvature.FromPerMeters(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Curvature)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(CurvatureUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(Curvature.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(Curvature.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Curvature.FromPerMeters(1.0);
            Assert.Equal(new {Curvature.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Curvature.FromPerMeters(value);
            Assert.Equal(Curvature.FromPerMeters(-value), -quantity);
        }
    }
}
