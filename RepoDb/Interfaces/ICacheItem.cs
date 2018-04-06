﻿using System;

namespace RepoDb.Interfaces
{
    public interface ICacheItem
    {
        string Key { get; }
        object Value { get; }
        DateTime Timestamp { get; }
    }
}
