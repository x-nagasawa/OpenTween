﻿// OpenTween - Client of Twitter
// Copyright (c) 2007-2011 kiri_feather (@kiri_feather) <kiri.feather@gmail.com>
//           (c) 2008-2011 Moz (@syo68k)
//           (c) 2008-2011 takeshik (@takeshik) <http://www.takeshik.org/>
//           (c) 2010-2011 anis774 (@anis774) <http://d.hatena.ne.jp/anis774/>
//           (c) 2010-2011 fantasticswallow (@f_swallow) <http://twitter.com/f_swallow>
//           (c) 2014      kim_upsilon (@kim_upsilon) <https://upsilo.net/~upsilon/>
// All rights reserved.
//
// This file is part of OpenTween.
//
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License
// for more details.
//
// You should have received a copy of the GNU General Public License along
// with this program. If not, see <http://www.gnu.org/licenses/>, or write to
// the Free Software Foundation, Inc., 51 Franklin Street - Fifth Floor,
// Boston, MA 02110-1301, USA.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenTween.Setting.Panel
{
    public partial class GetPeriodPanel : SettingPanelBase
    {
        public GetPeriodPanel()
        {
            InitializeComponent();
        }

        private void UserstreamPeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(UserstreamPeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.UserstreamPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd < 0 || prd > 60)
            {
                MessageBox.Show(Properties.Resources.UserstreamPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }
        }

        private void TimelinePeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(TimelinePeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TimelinePeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 15 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.TimelinePeriod_ValidatingText2);
                e.Cancel = true;
                return;
            }
        }

        private void ReplyPeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(ReplyPeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TimelinePeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 15 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.TimelinePeriod_ValidatingText2);
                e.Cancel = true;
                return;
            }
        }

        private void DMPeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(DMPeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 15 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText2);
                e.Cancel = true;
                return;
            }
        }

        private void PubSearchPeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(PubSearchPeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.PubSearchPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 30 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.PubSearchPeriod_ValidatingText2);
                e.Cancel = true;
            }
        }

        private void ListsPeriod_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(ListsPeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 15 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText2);
                e.Cancel = true;
                return;
            }
        }

        private void UserTimeline_Validating(object sender, CancelEventArgs e)
        {
            int prd;
            try
            {
                prd = int.Parse(UserTimelinePeriod.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText1);
                e.Cancel = true;
                return;
            }

            if (prd != 0 && (prd < 15 || prd > 6000))
            {
                MessageBox.Show(Properties.Resources.DMPeriod_ValidatingText2);
                e.Cancel = true;
                return;
            }
        }
    }
}