﻿using NodaTime;

namespace DevChatter.DevStreams.Core.Twitch
{
    public class ChannelLiveState
    {
        public string TwitchId { get; set; }
        public bool IsLive { get; set; }
        public Instant StartedAt { get; set; }
        public Duration TimeOnline => SystemClock.Instance.GetCurrentInstant() - StartedAt;
        public int ViewerCount { get; set; }
    }
}
