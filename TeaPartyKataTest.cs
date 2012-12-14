//
//  TeaPartyKataTest.cs
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
using NUnit.Framework;

namespace CSharpKata
{
    public class TeaPartyKataTest
    {
        public TeaPartyKataTest()
        {
        }

        [Test]
        public void testTeaParty()
        {
            ITeaPartyKata kata = new TeaPartyKata();

            Assert.AreEqual("Hello Ms. Austen", kata.Welcome("Austen", true, false));
            Assert.AreEqual("Hello Mr. Orwell", kata.Welcome("Orwell", false, false));
            Assert.AreEqual("Hello Sir Newton", kata.Welcome("Newton", false, true));

        }

    }
}

