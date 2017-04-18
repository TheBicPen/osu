﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Beatmaps;
using osu.Game.Modes.Mania.Objects;
using System.Collections.Generic;
using System;
using osu.Game.Modes.Objects.Types;
using osu.Game.Modes.Beatmaps;

namespace osu.Game.Modes.Mania.Beatmaps
{
    internal class ManiaBeatmapConverter : BeatmapConverter<ManiaBaseHit>
    {
        public override IEnumerable<Type> ValidConversionTypes { get; } = new[] { typeof(IHasXPosition) };

        public override Beatmap<ManiaBaseHit> Convert(Beatmap original)
        {
            return new Beatmap<ManiaBaseHit>(original)
            {
                HitObjects = new List<ManiaBaseHit>() // Todo: Implement
            };
        }
    }
}
