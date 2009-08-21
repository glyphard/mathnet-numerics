﻿// <copyright file="SpecialFunctionsTests.cs" company="Math.NET">
// Math.NET Numerics, part of the Math.NET Project
// http://mathnet.opensourcedotnet.info
//
// Copyright (c) 2009 Math.NET
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace MathNet.Numerics.UnitTests.SpecialFunctionsTests
{
    using System;
    using MbUnit.Framework;
    using MathNet.Numerics;

    class SpecialFunctionsTests
    {
        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(0.1, 2.2527126517342059020062379568954763844479865649307379)]
        [Row(1.0, 0.0)]
        [Row(1.5, -0.12078223763524522234551844578164721225185272790259947)]
        [Row(Constants.Pi / 2, -0.11590380084550241329912089415904874214542604767006895)]
        [Row(2.0, 0.0)]
        [Row(2.5, 0.28468287047291915963249466968270192432013769555989498)]
        [Row(3.0, 0.693147180559945309417232121458176568075500134360255)]
        [Row(Constants.Pi, 0.82769459232343710152957855845235995115350173412073715)]
        [Row(3.5, 1.2009736023470742248160218814507129957702389154681574)]
        [Row(4.0, 1.7917594692280550008124773583807022727229906921830034)]
        [Row(4.5, 2.4537365708424422205041425034357161573318235106897606)]
        [Row(5.0, 3.1780538303479456196469416012970554088739909609035161)]
        [Row(5.5, 3.9578139676187162938774008558225909985513044919750065)]
        [Row(10.1, 13.02752673863323715481371189614224148681183971709386)]
        public void GammaLn(double x, double f)
        {
            AssertHelpers.AlmostEqual(f, SpecialFunctions.GammaLn(x), 14);
        }

        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(-1.5, 2.3632718012073547030642233111215269103967326081631802)]
        [Row(-0.5, -3.544907701811032054596334966682290365595098912244773)]
        [Row(0.1, 9.5135076986687312858079798958252325009137161063903012)]
        [Row(1.0, 1.0)]
        [Row(1.5, 0.88622692545275801364908374167057259139877472806119326)]
        [Row(Constants.Pi / 2, 0.89056089038153932801065963535912100593354196288475879)]
        [Row(2.0, 1.0)]
        [Row(2.5, 1.3293403881791370204736256125058588870981620920917912)]
        [Row(3.0, 2.0)]
        [Row(Constants.Pi, 2.2880377953400324179595889090602339228896881533562229)]
        [Row(3.5, 3.3233509704478425511840640312646472177454052302294767)]
        [Row(4.0, 6.0)]
        [Row(4.5, 11.631728396567448929144224109426265262108918305803166)]
        [Row(5.0, 24.0)]
        [Row(5.5, 52.342777784553520181149008492418193679490132376114268)]
        [Row(10.1, 454760.75144158558537612486797710217749925965322893332)]
        public void Gamma(double x, double f)
        {
            AssertHelpers.AlmostEqual(f, SpecialFunctions.Gamma(x), 13);
        }

        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(-1.5, 0.70315664064524318722569033366791109947350706200623256)]
        [Row(-0.5, 0.036489973978576520559023667001244432806840395339565891)]
        [Row(0.1, -10.423754940411076232100295314502760886768558023951363)]
        [Row(1.0, -0.57721566490153286060651209008240243104215933593992359)]
        [Row(1.5, 0.036489973978576520559023667001244432806840395339565888)]
        [Row(Constants.Pi / 2, 0.10067337642740238636795561404029690452798358068944001)]
        [Row(2.0, 0.42278433509846713939348790991759756895784066406007641)]
        [Row(2.5, 0.70315664064524318722569033366791109947350706200623255)]
        [Row(3.0, 0.92278433509846713939348790991759756895784066406007641)]
        [Row(Constants.Pi, 0.97721330794200673329206948640618234364083460999432603)]
        [Row(3.5, 1.1031566406452431872256903336679110994735070620062326)]
        [Row(4.0, 1.2561176684318004727268212432509309022911739973934097)]
        [Row(4.5, 1.3888709263595289015114046193821968137592213477205183)]
        [Row(5.0, 1.5061176684318004727268212432509309022911739973934097)]
        [Row(5.5, 1.6110931485817511237336268416044190359814435699427405)]
        [Row(10.1, 2.2622143570941481235561593642219403924532310597356171)]
        public void DiGamma(double x, double f)
        {
            AssertHelpers.AlmostEqual(f, SpecialFunctions.DiGamma(x), 13);
        }

        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(0.0, Double.NegativeInfinity)]
        [Row(0.1, -10.423754940411076232100295314502760886768558023951363)]
        [Row(1.0, -0.57721566490153286060651209008240243104215933593992359)]
        [Row(1.5, 0.036489973978576520559023667001244432806840395339565888)]
        [Row(Constants.Pi / 2, 0.10067337642740238636795561404029690452798358068944001)]
        [Row(2.0, 0.42278433509846713939348790991759756895784066406007641)]
        [Row(2.5, 0.70315664064524318722569033366791109947350706200623255)]
        [Row(3.0, 0.92278433509846713939348790991759756895784066406007641)]
        [Row(Constants.Pi, 0.97721330794200673329206948640618234364083460999432603)]
        [Row(3.5, 1.1031566406452431872256903336679110994735070620062326)]
        [Row(4.0, 1.2561176684318004727268212432509309022911739973934097)]
        [Row(4.5, 1.3888709263595289015114046193821968137592213477205183)]
        [Row(5.0, 1.5061176684318004727268212432509309022911739973934097)]
        [Row(5.5, 1.6110931485817511237336268416044190359814435699427405)]
        [Row(10.1, 2.2622143570941481235561593642219403924532310597356171)]
        [Row(Double.PositiveInfinity, Double.PositiveInfinity)]
        public void DiGammaInv(double x, double f)
        {
            AssertHelpers.AlmostEqual(x, SpecialFunctions.DiGammaInv(f), 13);
        }

        /// <summary>
        /// Compute the t'th harmonic number using a loop.
        /// </summary>
        private double ExactHarmonic(int t)
        {
            double r = 0.0;
            for (int i = 1; i <= t; i++)
            {
                r += 1.0 / i;
            }
            return r;
        }

        [Test]
        [Row(1)]
        [Row(2)]
        [Row(4)]
        [Row(8)]
        [Row(16)]
        [Row(100)]
        [Row(1000)]
        [Row(10000)]
        [Row(100000)]
        [Row(1000000)]
        public void Harmonic(int i)
        {
            AssertHelpers.AlmostEqual(ExactHarmonic(i), SpecialFunctions.Harmonic(i), 13);
        }

        [Test]
        public void BetaLn()
        {
            AssertHelpers.AlmostEqual(System.Math.Log(0.5), SpecialFunctions.BetaLn(1.0, 2.0), 14);
            AssertHelpers.AlmostEqual(System.Math.Log(1.0), SpecialFunctions.BetaLn(1.0, 1.0), 14);
        }

        [Test]
        public void Beta()
        {
            AssertHelpers.AlmostEqual(0.5, SpecialFunctions.Beta(1.0, 2.0), 14);
            AssertHelpers.AlmostEqual(1.0, SpecialFunctions.Beta(1.0, 1.0), 14);
        }
    }
}