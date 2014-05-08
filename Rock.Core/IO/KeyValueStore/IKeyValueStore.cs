﻿using System.Collections.Generic;

namespace Rock.IO
{
    public interface IKeyValueStore
    {
        IEnumerable<IBucket> GetBuckets();
        IBucket GetBucket(string bucketName);
    }
}