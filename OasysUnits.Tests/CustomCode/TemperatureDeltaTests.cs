﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this unit class and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyQuantity.extra.cs files to add code to generated unit classes.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.
using System;
using Xunit;

namespace OasysUnits.Tests.CustomCode
{
    public class TemperatureDeltaTests : TemperatureDeltaTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;
        protected override double DegreesCelsiusInOneKelvin => 1;
        protected override double DegreesDelisleInOneKelvin => -1.5d;
        protected override double DegreesFahrenheitInOneKelvin => 1.8;
        protected override double DegreesNewtonInOneKelvin => 0.33d;
        protected override double DegreesRankineInOneKelvin => 1.8;
        protected override double DegreesReaumurInOneKelvin => 0.8;
        protected override double DegreesRoemerInOneKelvin => 21 / 40d;
        protected override double KelvinsInOneKelvin => 1;
        protected override double MillidegreesCelsiusInOneKelvin => 1E3;

        [Fact]
        public void SpecificEntropyTimesTemperatureDeltaEqualsSpecificEnergy()
        {
            SpecificEnergy specificEnergy =  SpecificEntropy.FromJoulesPerKilogramKelvin(10) * TemperatureDelta.FromKelvins(6);
            Assert.Equal(SpecificEnergy.FromJoulesPerKilogram(60), specificEnergy);
        }

        [Fact]
        public void TemperatureDeltaTimesSpecificEntropyEqualsSpecificEnergy()
        {
            SpecificEnergy specificEnergy = TemperatureDelta.FromKelvins(10) * SpecificEntropy.FromJoulesPerKilogramKelvin(14);
            Assert.Equal(SpecificEnergy.FromJoulesPerKilogram(140), specificEnergy);
        }

        [Fact]
        public void EntropyTimesTemperatureDeltaEqualsEnergy()
        {
            Energy energy = Entropy.FromKilojoulesPerKelvin(3) * TemperatureDelta.FromKelvins(7);
            Assert.Equal(21, energy.Kilojoules);
        }

        [Fact]
        public void TemperatureDeltaTimesEntropyEqualsEnergy()
        {
            Energy energy = TemperatureDelta.FromKelvins(20) * Entropy.FromJoulesPerKelvin(4);
            Assert.Equal(Energy.FromJoules(80), energy);
        }

        [Fact]
        public void TemperatureDeltaDividedByTimeSpanEqualsTemperatureChangeRate()
        {
            TemperatureChangeRate changeRate = TemperatureDelta.FromKelvins(20) / TimeSpan.FromSeconds(2);
            Assert.Equal(TemperatureChangeRate.FromDegreesCelsiusPerSecond(10), changeRate);
        }

        [Fact]
        public void TemperatureDeltaDividedByDurationEqualsTemperatureChangeRate()
        {
            TemperatureChangeRate changeRate = TemperatureDelta.FromKelvins(20) / Duration.FromSeconds(2);
            Assert.Equal(TemperatureChangeRate.FromDegreesCelsiusPerSecond(10), changeRate);
        }
    }
}
