//
//  TeaPartyKata.cs
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
using System.Text;

namespace CSharpKata
{
    public class TeaPartyKata : ITeaPartyKata
    {
        public TeaPartyKata()
        {
        }

        public string Welcome(string lastName, bool isWoman, bool isSir)
        {

            StringBuilder builder = new StringBuilder("Hello ");

            builder.Append(isSir ? "Sir" : String.Empty);

            builder.Append(!isSir && isWoman ? "Ms." : !isSir ? "Mr." : "");

            builder.Append(" ").Append(lastName);


            return builder.ToString();

        }


    }
}

