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

using OasysUnits.NumberExtensions.NumberToCoefficientOfThermalExpansion;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToCoefficientOfThermalExpansionExtensionsTests
    {
        [Fact]
        public void NumberToPerDegreeCelsiusTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPerDegreeCelsius(2), 2.PerDegreeCelsius());

        [Fact]
        public void NumberToPerDegreeFahrenheitTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPerDegreeFahrenheit(2), 2.PerDegreeFahrenheit());

        [Fact]
        public void NumberToPerKelvinTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPerKelvin(2), 2.PerKelvin());

        [Fact]
        public void NumberToPpmPerDegreeCelsiusTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPpmPerDegreeCelsius(2), 2.PpmPerDegreeCelsius());

        [Fact]
        public void NumberToPpmPerDegreeFahrenheitTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPpmPerDegreeFahrenheit(2), 2.PpmPerDegreeFahrenheit());

        [Fact]
        public void NumberToPpmPerKelvinTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromPpmPerKelvin(2), 2.PpmPerKelvin());

    }
}
