using Game.Block.SneakBlock;
using GameUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Sneak
{
    public class SneakCore : ObjectCore<SneakCore>
    {
        IBlockManager<SneakBlockBase> blockManager;

        /* Properties */
        public SneakInputProvider InputProvider { get; private set; }
        public IReadOnlyList<SneakBlockBase> Blocks => blockManager.Blocks;

        //--------------------------------------------------
        /* Messages */
        protected override void Awake()
        {
            InputProvider = new SneakInputProvider();
            InputProvider.Initialize();

            blockManager = GetComponentInChildren<IBlockManager<SneakBlockBase>>();
            blockManager.Initialize();

            base.Awake();
        }

        protected override void OnDestroy()
        {
            InputProvider.Dispose();

            base.OnDestroy();
        }
    }
}