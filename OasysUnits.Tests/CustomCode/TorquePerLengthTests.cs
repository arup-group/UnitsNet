﻿//------------------------------------------------------------------------------
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

namespace OasysUnits.Tests.CustomCode
{
    public class TorquePerLengthTests : TorquePerLengthTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;
        protected override double KilogramForceCentimetersPerMeterInOneNewtonMeterPerMeter => 10.197162130;
        protected override double KilogramForceMetersPerMeterInOneNewtonMeterPerMeter => 0.101971621;
        protected override double KilogramForceMillimetersPerMeterInOneNewtonMeterPerMeter => 101.971621298;
        protected override double KilonewtonCentimetersPerMeterInOneNewtonMeterPerMeter => 1E-1;
        protected override double KilonewtonMetersPerMeterInOneNewtonMeterPerMeter => 1E-3;
        protected override double KilonewtonMillimetersPerMeterInOneNewtonMeterPerMeter => 1;
        protected override double KilopoundForceFeetPerFootInOneNewtonMeterPerMeter =>  0.224808943099E-3;
        protected override double KilopoundForceInchesPerFootInOneNewtonMeterPerMeter => 2.69770722235E-3;
        protected override double MeganewtonCentimetersPerMeterInOneNewtonMeterPerMeter => 1E-4;
        protected override double MeganewtonMetersPerMeterInOneNewtonMeterPerMeter => 1E-6;
        protected override double MeganewtonMillimetersPerMeterInOneNewtonMeterPerMeter => 1E-3;
        protected override double MegapoundForceFeetPerFootInOneNewtonMeterPerMeter => 0.224808943099E-6;
        protected override double MegapoundForceInchesPerFootInOneNewtonMeterPerMeter => 2.69770722235E-6;
        protected override double NewtonCentimetersPerMeterInOneNewtonMeterPerMeter => 1E2;
        protected override double NewtonMetersPerMeterInOneNewtonMeterPerMeter => 1;
        protected override double NewtonMillimetersPerMeterInOneNewtonMeterPerMeter => 1E3;
        protected override double PoundForceFeetPerFootInOneNewtonMeterPerMeter => 0.224808943099;
        protected override double PoundForceInchesPerFootInOneNewtonMeterPerMeter => 2.69770722235;
        protected override double TonneForceCentimetersPerMeterInOneNewtonMeterPerMeter => 1.01971621298e-2;
        protected override double TonneForceMetersPerMeterInOneNewtonMeterPerMeter => 1.01971621298e-4;
        protected override double TonneForceMillimetersPerMeterInOneNewtonMeterPerMeter => 1.01971621298e-1;
    }
}
