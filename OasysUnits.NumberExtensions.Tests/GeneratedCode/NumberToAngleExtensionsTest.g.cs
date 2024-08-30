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

using OasysUnits.NumberExtensions.NumberToAngle;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToAngleExtensionsTests
    {
        [Fact]
        public void NumberToArcminutesTest() =>
            Assert.Equal(Angle.FromArcminutes(2), 2.Arcminutes());

        [Fact]
        public void NumberToArcsecondsTest() =>
            Assert.Equal(Angle.FromArcseconds(2), 2.Arcseconds());

        [Fact]
        public void NumberToCentiradiansTest() =>
            Assert.Equal(Angle.FromCentiradians(2), 2.Centiradians());

        [Fact]
        public void NumberToDeciradiansTest() =>
            Assert.Equal(Angle.FromDeciradians(2), 2.Deciradians());

        [Fact]
        public void NumberToDegreesTest() =>
            Assert.Equal(Angle.FromDegrees(2), 2.Degrees());

        [Fact]
        public void NumberToGradiansTest() =>
            Assert.Equal(Angle.FromGradians(2), 2.Gradians());

        [Fact]
        public void NumberToMicrodegreesTest() =>
            Assert.Equal(Angle.FromMicrodegrees(2), 2.Microdegrees());

        [Fact]
        public void NumberToMicroradiansTest() =>
            Assert.Equal(Angle.FromMicroradians(2), 2.Microradians());

        [Fact]
        public void NumberToMillidegreesTest() =>
            Assert.Equal(Angle.FromMillidegrees(2), 2.Millidegrees());

        [Fact]
        public void NumberToMilliradiansTest() =>
            Assert.Equal(Angle.FromMilliradians(2), 2.Milliradians());

        [Fact]
        public void NumberToNanodegreesTest() =>
            Assert.Equal(Angle.FromNanodegrees(2), 2.Nanodegrees());

        [Fact]
        public void NumberToNanoradiansTest() =>
            Assert.Equal(Angle.FromNanoradians(2), 2.Nanoradians());

        [Fact]
        public void NumberToNatoMilsTest() =>
            Assert.Equal(Angle.FromNatoMils(2), 2.NatoMils());

        [Fact]
        public void NumberToRadiansTest() =>
            Assert.Equal(Angle.FromRadians(2), 2.Radians());

        [Fact]
        public void NumberToRevolutionsTest() =>
            Assert.Equal(Angle.FromRevolutions(2), 2.Revolutions());

        [Fact]
        public void NumberToTiltTest() =>
            Assert.Equal(Angle.FromTilt(2), 2.Tilt());

    }
}
