﻿using Sandbox.Common.ObjectBuilders.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Definitions
{
    [MyDefinitionType(typeof(MyObjectBuilder_PlanetGeneratorDefinition))]
    public class MyPlanetGeneratorDefinition : MyDefinitionBase
    {
        public MyRangedValue Diameter;

        public MyRangedValue Deviation;

        public MyRangedValue StructureRatio;

        public MyRangedValue NormalNoiseValue;

        public bool HasAtmosphere;

        public MyStructureParams HillParams;

        public MyStructureParams CanyonParams;

        public float HostilityProbability;

        public MyRangedValue NumLayers;

        public MyPoleParams SouthPole;

        public MyPoleParams NorthPole;

        public MyRangedValue FloraMaterialSpawnProbability;

        public MyRangedValue MaterialsMaxDeph;

        public MyRangedValue MaterialsMinDeph;

        public MyRangedValue OrganicHeightEnd;

        public MyOreProbabilityRange[] MetalsOreProbability;

        public MyRangedValue GravityFalloffPower;

        public MyAtmosphereColorShift HostileAtmosphereColorShift;

        protected override void Init(MyObjectBuilder_DefinitionBase builder)
        {
            base.Init(builder);
            var ob = builder as MyObjectBuilder_PlanetGeneratorDefinition;

            Diameter = ob.Diameter;
            Deviation = ob.Deviation;
            StructureRatio = ob.StructureRatio;
            NormalNoiseValue = ob.NormalNoiseValue;
            HasAtmosphere = ob.HasAtmosphere;

            HillParams = ob.HillParams;
            CanyonParams = ob.CanyonParams;
            NumLayers = ob.NumLayers;
            HostilityProbability = ob.HostilityProbability;

            SouthPole = ob.SouthPole;
            NorthPole = ob.NorthPole;

            FloraMaterialSpawnProbability = ob.FloraMaterialSpawnProbability;


            OrganicHeightEnd = ob.OrganicHeightEnd;

            MetalsOreProbability =  ob.MetalsOreProbability;

            GravityFalloffPower = ob.GravityFalloffPower;

            HostileAtmosphereColorShift = ob.HostileAtmosphereColorShift;

            MaterialsMaxDeph = ob.MaterialsMaxDeph;
            MaterialsMinDeph = ob.MaterialsMinDeph;
        }
    }
}
