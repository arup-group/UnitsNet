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

using OasysUnits.NumberExtensions.NumberToElectricPotentialAc;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToElectricPotentialAcExtensionsTests
    {
        [Fact]
        public void NumberToKilovoltsAcTest() =>
            Assert.Equal(ElectricPotentialAc.FromKilovoltsAc(2), 2.KilovoltsAc());

        [Fact]
        public void NumberToMegavoltsAcTest() =>
            Assert.Equal(ElectricPotentialAc.FromMegavoltsAc(2), 2.MegavoltsAc());

        [Fact]
        public void NumberToMicrovoltsAcTest() =>
            Assert.Equal(ElectricPotentialAc.FromMicrovoltsAc(2), 2.MicrovoltsAc());

        [Fact]
        public void NumberToMillivoltsAcTest() =>
            Assert.Equal(ElectricPotentialAc.FromMillivoltsAc(2), 2.MillivoltsAc());

        [Fact]
        public void NumberToVoltsAcTest() =>
            Assert.Equal(ElectricPotentialAc.FromVoltsAc(2), 2.VoltsAc());

    }
}
