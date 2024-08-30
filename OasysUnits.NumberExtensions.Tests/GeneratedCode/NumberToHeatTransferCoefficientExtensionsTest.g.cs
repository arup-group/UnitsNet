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

using OasysUnits.NumberExtensions.NumberToHeatTransferCoefficient;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToHeatTransferCoefficientExtensionsTests
    {
        [Fact]
        public void NumberToBtusPerHourSquareFootDegreeFahrenheitTest() =>
            Assert.Equal(HeatTransferCoefficient.FromBtusPerHourSquareFootDegreeFahrenheit(2), 2.BtusPerHourSquareFootDegreeFahrenheit());

        [Fact]
        public void NumberToCaloriesPerHourSquareMeterDegreeCelsiusTest() =>
            Assert.Equal(HeatTransferCoefficient.FromCaloriesPerHourSquareMeterDegreeCelsius(2), 2.CaloriesPerHourSquareMeterDegreeCelsius());

        [Fact]
        public void NumberToKilocaloriesPerHourSquareMeterDegreeCelsiusTest() =>
            Assert.Equal(HeatTransferCoefficient.FromKilocaloriesPerHourSquareMeterDegreeCelsius(2), 2.KilocaloriesPerHourSquareMeterDegreeCelsius());

        [Fact]
        public void NumberToWattsPerSquareMeterCelsiusTest() =>
            Assert.Equal(HeatTransferCoefficient.FromWattsPerSquareMeterCelsius(2), 2.WattsPerSquareMeterCelsius());

        [Fact]
        public void NumberToWattsPerSquareMeterKelvinTest() =>
            Assert.Equal(HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(2), 2.WattsPerSquareMeterKelvin());

    }
}
