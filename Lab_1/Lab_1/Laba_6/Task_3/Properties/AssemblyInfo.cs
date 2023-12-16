using System;
using System.Collections.Generic;

public class FunctionCache<TKey, TResult>
{
    private readonly Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();
    private readonly Func<TKey, TResult> function;

    public delegate TResult FuncDelegate(TKey key);

    public FunctionCache(Func<TKey, TResult> function)
    {
        this.function = function ?? throw new ArgumentNullException(nameof(function));
    }

    public TResult GetResult(TKey key, TimeSpan cacheDuration)
    {
        if (cache.TryGetValue(key, out var cacheItem) && IsCacheValid(cacheItem, cacheDuration))
        {
            return cacheItem.Result;
        }

        TResult result = function(key);
        cache[key] = new CacheItem(result, DateTime.UtcNow);
        return result;
    }

    private bool IsCacheValid(CacheItem cacheItem, TimeSpan cacheDuration)
    {
        return DateTime.UtcNow - cacheItem.Timestamp <= cacheDuration;
    }

    private class CacheItem
    {
        public TResult Result { get; }
        public DateTime Timestamp { get; }

        public CacheItem(TResult result, DateTime timestamp)
        {
            Result = result;
            Timestamp = timestamp;
        }
    }
}
