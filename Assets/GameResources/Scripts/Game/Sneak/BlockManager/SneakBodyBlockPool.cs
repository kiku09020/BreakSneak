using DesignPatterns.ObjectPool;
using Game.Block.SneakBlock;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Sneak {
    public class SneakBodyBlockPool : SimpleCustomizedObjectPool<SneakBodyPooledHandler> {
        /* Fields */

        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */
        protected override void Init(bool isCheck, int defaultCapacity, int maxSize)
        {
            base.Init(isCheck, defaultCapacity, maxSize);
        }

        protected override SneakBodyPooledHandler OnCreate(SneakBodyPooledHandler prefab, Transform parent)
        {
            return base.OnCreate(prefab, parent);
        }

        //-------------------------------------------------------------------
        /* Methods */

    }
}