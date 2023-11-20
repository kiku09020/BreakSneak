using GameUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Sneak
{
    public class SneakCore : ObjectCore
    {
        /* Properties */
        public SneakInputProvider InputProvider { get; private set; }

        //--------------------------------------------------
        /* Messages */
        protected override void Awake()
        {
            InputProvider = new SneakInputProvider();
            InputProvider.Initialize();

            base.Awake();
        }

        protected override void OnDestroy()
        {
            InputProvider.Dispose();

            base.OnDestroy();
        }
    }
}