//
//  INasaCountdownKata.cs
//
//  Author:
//       ElderMael <sftwr.mael@gmail.com>
//
//  Copyright (c) 2012 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace CSharpKata
{
    public interface INasaCountdownKata
    {
        /// <summary>
        /// Issue the NASA countdown
        /// </summary>
        /// <param name="start">number to start with</param>
        /// <returns>array with numbers from 'start' to 0</returns>
        int[] Countdown(int start);
    }
}

