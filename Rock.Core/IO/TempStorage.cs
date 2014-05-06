﻿using System.Collections.Generic;

namespace Rock.IO
{
    public static class TempStorage
    {
        public static IEnumerable<IBucketItem> GetItems(string bucket)
        {
            return Default.TempStorage.GetItems(bucket);
        }

        public static void AddItem<T>(string bucket, string key, T value)
        {
            Default.TempStorage.AddItem(bucket, key, value);
        }

        public static T GetValue<T>(string bucket, string key)
        {
            return Default.TempStorage.GetValue<T>(bucket, key);
        }

        public static void Delete(string bucket, string key)
        {
            Default.TempStorage.GetItem(bucket, key).Delete();
        }
    }
}