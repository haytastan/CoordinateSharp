﻿/*
CoordinateSharp is a .NET standard library that is intended to ease geographic coordinate 
format conversions and location based celestial calculations.
https://github.com/Tronald/CoordinateSharp

Many celestial formulas in this library are based on Jean Meeus's 
Astronomical Algorithms (2nd Edition). Comments that reference only a chapter
are referring to this work.

License

Copyright (C) 2019, Signature Group, LLC
  
This program is free software; you can redistribute it and/or modify it under the terms of the GNU Affero General Public License version 3 
as published by the Free Software Foundation with the addition of the following permission added to Section 15 as permitted in Section 7(a): 
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY Signature Group, LLC. Signature Group, LLC DISCLAIMS THE WARRANTY OF 
NON INFRINGEMENT OF THIRD PARTY RIGHTS.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details. You should have received a copy of the GNU 
Affero General Public License along with this program; if not, see http://www.gnu.org/licenses or write to the 
Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA, 02110-1301 USA, or download the license from the following URL:

https://www.gnu.org/licenses/agpl-3.0.html

The interactive user interfaces in modified source and object code versions of this program must display Appropriate Legal Notices, 
as required under Section 5 of the GNU Affero General Public License.

You can be released from the requirements of the license by purchasing a commercial license. Buying such a license is mandatory 
as soon as you develop commercial activities involving the CoordinateSharp software without disclosing the source code of your own applications. 
These activities include: offering paid services to customers as an ASP, on the fly location based calculations in a web application, 
or shipping CoordinateSharp with a closed source product.

For more information, please contact Signature Group, LLC at this address: sales@signatgroup.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordinateSharp
{
    /// <summary>
    /// The main class for handling location based celestial information.
    /// </summary>
    /// <remarks>
    /// This class can calculate various pieces of solar and lunar data, based on location and date
    /// </remarks>
    [Serializable]
    public partial class Celestial
    { 
        internal DateTime? sunSet;
        internal DateTime? sunRise;
        internal DateTime? moonSet;
        internal DateTime? moonRise;

        internal double sunAltitude;
        internal double sunAzimuth;
        internal double moonAltitude;
        internal double moonAzimuth;

        internal Distance moonDistance;

        internal CelestialStatus sunCondition;
        internal CelestialStatus moonCondition;

        internal bool isSunUp;
        internal bool isMoonUp;

        internal MoonIllum moonIllum;
        internal Perigee perigee;
        internal Apogee apogee;
        internal AdditionalSolarTimes additionalSolarTimes;
        internal AstrologicalSigns astrologicalSigns;
        internal SolarEclipse solarEclipse;
        internal LunarEclipse lunarEclipse;

        /// <summary>
        /// Sunset time.
        /// </summary>
        public DateTime? SunSet { get { return sunSet; } }
        /// <summary>
        /// Sunrise time.
        /// </summary>
        public DateTime? SunRise { get { return sunRise; } }
        /// <summary>
        /// Moonset time.
        /// </summary>
        public DateTime? MoonSet { get { return moonSet; } }
        /// <summary>
        /// Moonrise time.
        /// </summary>
        public DateTime? MoonRise { get { return moonRise; } }

        /// <summary>
        /// Sun altitude in degrees (E of N).
        /// </summary>
        public double SunAltitude { get { return sunAltitude; } }
        /// <summary>
        /// Sun azimuth in degrees (E of N).
        /// </summary>
        public double SunAzimuth { get { return sunAzimuth; } }
        /// <summary>
        /// Moon altitude in degrees (corrected for parallax and refraction).
        /// </summary>
        public double MoonAltitude { get { return moonAltitude; } }
        /// <summary>
        /// Moon azimuth in degrees (E of N).
        /// </summary>
        public double MoonAzimuth { get { return moonAzimuth; } }

        /// <summary>
        /// Estimated moon distance from the earth.
        /// </summary>
        public Distance MoonDistance { get { return moonDistance; } }
        /// <summary>
        /// Sun's Condition based on the provided date.
        /// </summary>
        public CelestialStatus SunCondition { get { return sunCondition; } }
        /// <summary>
        /// Moon's condition based on the provided date.
        /// </summary>
        public CelestialStatus MoonCondition { get { return moonCondition; } }

        /// <summary>
        /// Determine if the sun is currently up, based on sunset and sunrise time at the provided location and date.
        /// </summary>
        public bool IsSunUp { get { return isSunUp; } }

        /// <summary>
        /// Determine if the moon is currently up, based on moonset and moonrise time at the provided location and date.
        /// </summary>
        public bool IsMoonUp { get { return isMoonUp; } }

        /// <summary>
        /// Moon ilumination details based on the provided date.
        /// </summary>
        /// <remarks>
        /// Contains phase, phase name, fraction and angle
        /// </remarks>
        public MoonIllum MoonIllum { get { return moonIllum; } }
        /// <summary>
        /// Moons perigee details based on the provided date.
        /// </summary>
        public Perigee Perigee { get { return perigee; } }
        /// <summary>
        /// Moons apogee details based on the provided date.
        /// </summary>
        public Apogee Apogee { get { return apogee; } }

        /// <summary>
        /// Additional solar event times based on the provided date and location.
        /// </summary>
        /// <remarks>Contains civil and nautical dawn and dusk times.</remarks>
        public AdditionalSolarTimes AdditionalSolarTimes { get { return additionalSolarTimes; } }
        /// <summary>
        /// Astrological signs based on the provided date.
        /// </summary>
        /// <remarks>
        /// Contains zodiac, moon sign and moon name during full moon events
        /// </remarks>
        public AstrologicalSigns AstrologicalSigns { get { return astrologicalSigns; } }

        /// <summary>
        /// Returns a SolarEclipse.
        /// </summary>
        public SolarEclipse SolarEclipse { get { return solarEclipse; } }
        /// <summary>
        /// Returns a LunarEclipse.
        /// </summary>
        public LunarEclipse LunarEclipse { get { return lunarEclipse; } }
    }
}