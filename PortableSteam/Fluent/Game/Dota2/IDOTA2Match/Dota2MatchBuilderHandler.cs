﻿namespace PortableSteam.Fluent.Game
{
    using PortableSteam.Fluent.Game.Dota2.IDOTA2;
using PortableSteam.Infrastructure;
using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
using System;
using System.ComponentModel;

    public class Dota2MatchBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Dota2MatchBuilderHandler(string key) : base(key, (int)GameType.Dota2) { }
        /// <summary>
        /// Information about DotaTV-supported leagues.
        /// </summary>
        public GetLeagueListingBuilder GetLeagueListing()
        {
            return new GetLeagueListingBuilder(new GetLeagueListingRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// A list of in-progress league matches, as well as details of that match as it unfolds.
        /// </summary>
        public GetLiveLeagueGamesBuilder GetLiveLeagueGames()
        {
            return new GetLiveLeagueGamesBuilder(new GetLiveLeagueGamesRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// Information about a particular match.
        /// </summary>
        public GetMatchDetailsBuilder GetMatchDetails(long matchID)
        {
            return new GetMatchDetailsBuilder(new GetMatchDetailsRequest(this.Key, this.AppID) { MatchID = matchID });
        }
        /// <summary>
        /// A list of matches, filterable by various parameters.
        /// </summary>
        public GetMatchHistoryBuilder GetMatchHistory()
        {
            return new GetMatchHistoryBuilder(new GetMatchHistoryRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// A list of matches ordered by their sequence num.
        /// </summary>
        public GetMatchHistoryBySequenceNumBuilder GetMatchHistoryBySequenceNum()
        {
            return new GetMatchHistoryBySequenceNumBuilder(new GetMatchHistoryBySequenceNumRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// A list of scheduled league games coming up.
        /// </summary>
        public GetScheduledLeagueGamesBuilder GetScheduledLeagueGames()
        {
            return new GetScheduledLeagueGamesBuilder(new GetScheduledLeagueGamesRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// A list of all the teams set up in-game.
        /// </summary>
        public GetTeamInfoByTeamIDBuilder GetTeamInfoByTeamID()
        {
            return new GetTeamInfoByTeamIDBuilder(new GetTeamInfoByTeamIDRequest(this.Key, this.AppID));

        }
        /// <summary>
        /// Stats about a particular player within a tournament.
        /// <param name="identity">SteamIdentity.</param>
        /// </summary>
        public GetTournamentPlayerStatsBuilder GetTournamentPlayerStats(SteamIdentity identity)
        {
            return new GetTournamentPlayerStatsBuilder(new GetTournamentPlayerStatsRequest(this.Key, this.AppID) { AccountID = identity.AccountID });
        }

        #region Hidden

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }

        #endregion
    }
}
