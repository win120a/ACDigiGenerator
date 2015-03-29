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

using KeyGenDll;
using KeyGenUI.Properties;
using System;
using System.Windows.Forms;

namespace KeyGenUI
{
    public partial class Form1 : Form
    {
        string[] nums = KeyGen.Gen3DigitKeys();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("本程序仅为娱乐，严禁用于破解或其他非法用途！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (!Settings.Default.IsGPLNoticeShowed)
            {
                gpl_Click(null, null);
                Settings.Default.IsGPLNoticeShowed = true;
                Settings.Default.Save();
            }

            if (Settings.Default.LastNumPos < 0 || Settings.Default.LastNumPos > (nums.Length - 1))
            {
                Settings.Default.LastNumPos = 0;
                Settings.Default.Save();
            }

            if (Settings.Default.LastNumPos == 0)
            {
                p.Enabled = false;
            }

            if (Settings.Default.LastNumPos == (nums.Length - 1))
            {
                n.Enabled = false;
            }

            textBox1.Text = nums[Settings.Default.LastNumPos];
        }

        private void p_Click(object sender, EventArgs e)
        {
            Settings.Default.LastNumPos -= 1;
            Settings.Default.Save();
            textBox1.Text = nums[Settings.Default.LastNumPos];

            if (Settings.Default.LastNumPos == 0)
            {
                p.Enabled = false;
            }

            if (Settings.Default.LastNumPos == (nums.Length - 1))
            {
                n.Enabled = false;
            }

            if (Settings.Default.LastNumPos != 0)
            {
                p.Enabled = true;
            }

            if (Settings.Default.LastNumPos != (nums.Length - 1))
            {
                n.Enabled = true;
            }
        }

        private void n_Click(object sender, EventArgs e)
        {
            Settings.Default.LastNumPos += 1;
            Settings.Default.Save();
            textBox1.Text = nums[Settings.Default.LastNumPos];

            if (Settings.Default.LastNumPos == 0)
            {
                p.Enabled = false;
            }

            if (Settings.Default.LastNumPos == (nums.Length - 1))
            {
                n.Enabled = false;
            }

            if (Settings.Default.LastNumPos != 0)
            {
                p.Enabled = true;
            }

            if (Settings.Default.LastNumPos != (nums.Length - 1))
            {
                n.Enabled = true;
            }
        }

        private void r_Click(object sender, EventArgs e)
        {
            Settings.Default.LastNumPos = 0;
            Settings.Default.Save();
            textBox1.Text = nums[Settings.Default.LastNumPos];
            MessageBox.Show("复位完成。");
        }

        private void co_Click(object sender, EventArgs e)
        {
            Settings.Default.ConfirmedPass = textBox1.Text;
            Settings.Default.IsPasswordConfirmed = true;
            Settings.Default.Save();
            MessageBox.Show("密码确认完成。密码是：" + Settings.Default.ConfirmedPass);
        }

        private void rp_Click(object sender, EventArgs e)
        {
            if (Settings.Default.IsPasswordConfirmed)
            {
                MessageBox.Show("原来您确认的密码是：" + Settings.Default.ConfirmedPass);
            }
            else
            {
                MessageBox.Show("您没有确认密码。");
            }
        }

        private void q_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearp_Click(object sender, EventArgs e)
        {
            Settings.Default.ConfirmedPass = "000";
            Settings.Default.IsPasswordConfirmed = false;
            Settings.Default.Save();
            MessageBox.Show("密码清空完成。");
        }

        private void gpl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AC Digital Key Generator   Copyright (C) 2015 Andy Cheung \n\n" +
                "This program comes with ABSOLUTELY NO WARRANTY;\n" +
                "This is free software, and you are welcome to redistribute it " +
                "UNDER CERTAIN CONDITIONS;\n\n" + "Click OK for details.", "GPL Notice");
            MessageBox.Show("15. Disclaimer of Warranty. \n" +
                            "  THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY " +
                            "APPLICABLE LAW.  EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT " +
                            "HOLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM \"AS IS\" WITHOUT WARRANTY " +
                            "OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, " +
                            "THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR " +
                            "PURPOSE.  THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM " +
                            "IS WITH YOU.  SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF " +
                            "ALL NECESSARY SERVICING, REPAIR OR CORRECTION.", "The GPL says: (NO WARRANTY)");

            String g = @"  2. Basic Permissions.

  All rights granted under this License are granted for the term of
copyright on the Program, and are irrevocable provided the stated
conditions are met.  This License explicitly affirms your unlimited
permission to run the unmodified Program.  The output from running a
covered work is covered by this License only if the output, given its
content, constitutes a covered work.  This License acknowledges your
rights of fair use or other equivalent, as provided by copyright law.

  You may make, run and propagate covered works that you do not
convey, without conditions so long as your license otherwise remains
in force.  You may convey covered works to others for the sole purpose
of having them make modifications exclusively for you, or provide you
with facilities for running those works, provided that you comply with
the terms of this License in conveying all material for which you do
not control copyright.  Those thus making or running the covered works
for you must do so exclusively on your behalf, under your direction
and control, on terms that prohibit them from making any copies of
your copyrighted material outside their relationship with you.

  Conveying under any other circumstances is permitted solely under
the conditions stated below.  Sublicensing is not allowed; section 10
makes it unnecessary.";

            MessageBox.Show(g, "The GPL says: (Welcome redistribute)");
        }
    }
}
