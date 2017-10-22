﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPR.Models.Games
{
    public class Game
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public string HomeTeamScore { get; set; }
        public string AwayTeamScore { get; set; }

        public bool NotifyAway { get; set; }
        public bool NotifyHome { get; set; }

        public string Score { get; set; }
        public string Link { get; set; }

        public string Time { get; set; }

        public bool IsOver => Score != null && Score.ToLower().Contains("final");

        public string GetSummary()
        {
            return
                $"Home: {HomeTeam} Score: {HomeTeamScore} Notify: {NotifyHome} Away: {AwayTeam} Score: {AwayTeamScore} Notify: {NotifyAway} Score: {Score} Link: {Link} Is Over: {IsOver}";
        }
    }
}