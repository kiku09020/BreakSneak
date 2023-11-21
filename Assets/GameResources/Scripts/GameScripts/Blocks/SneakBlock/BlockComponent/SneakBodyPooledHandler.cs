using DesignPatterns.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    /// <summary> BodyÉvÅ[Éãóp </summary>
    public class SneakBodyPooledHandler : PooledObject<SneakBodyPooledHandler> {
        /* Fields */
        [SerializeField] SneakBodyBlock bodyBlock;

        //-------------------------------------------------------------------
        /* Properties */
        public SneakBodyBlock Block => bodyBlock;

        //-------------------------------------------------------------------
        /* Messages */
        public override void OnCreated()
        {
            base.OnCreated();
        }

        public override void OnGetFromPool()
        {
            base.OnGetFromPool();
        }

        public override void OnReleasedToPool()
        {
            base.OnReleasedToPool();
        }

        //-------------------------------------------------------------------
        /* Methods */

    }
}