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

using OasysUnits.NumberExtensions.NumberToIlluminance;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToIlluminanceExtensionsTests
    {
        [Fact]
        public void NumberToKiloluxTest() =>
            Assert.Equal(Illuminance.FromKilolux(2), 2.Kilolux());

        [Fact]
        public void NumberToLuxTest() =>
            Assert.Equal(Illuminance.FromLux(2), 2.Lux());

        [Fact]
        public void NumberToMegaluxTest() =>
            Assert.Equal(Illuminance.FromMegalux(2), 2.Megalux());

        [Fact]
        public void NumberToMilliluxTest() =>
            Assert.Equal(Illuminance.FromMillilux(2), 2.Millilux());

    }
}
