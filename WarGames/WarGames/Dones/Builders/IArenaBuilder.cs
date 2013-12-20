﻿namespace Drones.Builders
{
    public interface IArenaBuilder
    {
        IArena Create(uint latitude, uint longitude);
    }
}
