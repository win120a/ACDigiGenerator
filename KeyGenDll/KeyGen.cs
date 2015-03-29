/*
    AC Digital Key Generator.
    Generate keys in 3 digis.

    Copyright (C) 2015 Andy Cheung

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using System.Text;

namespace KeyGenDll
{
    public class KeyGen
    {
        private KeyGen()
        {
            // DO NOTHING.
        }

        public static string[] Gen3DigitKeys()
        {
            List<string> l = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                if (i < 10)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("00");
                    sb.Append(i);
                    l.Add(sb.ToString());
                    continue;
                }

                if (i < 100)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("0");
                    sb.Append(i);
                    l.Add(sb.ToString());
                    continue;
                }

                StringBuilder sBuilder = new StringBuilder();
                sBuilder.Append(i);
                l.Add(sBuilder.ToString());
            }

            return l.ToArray();
        }
    }
}
