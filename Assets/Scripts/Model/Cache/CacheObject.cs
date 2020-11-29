﻿using System;
using UnityEngine;

namespace Gb_Unity3D_CSharp
{
    /// <summary>
    /// Закешированный объект
    /// </summary>
    [Serializable]
    public class CacheObject
    {
        public GameObject Prefab;
        public int PoolSize;
        public string Tag;
        
        public CacheObject(GameObject prefab, int poolSize, string tag)
        {
            Prefab = prefab;
            PoolSize = poolSize;
            Tag = tag;
        }
    }
}