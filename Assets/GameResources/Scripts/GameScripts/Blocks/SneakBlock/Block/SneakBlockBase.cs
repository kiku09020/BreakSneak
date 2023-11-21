using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    public abstract class SneakBlockBase : BlockBase<SneakBlockBase> {
        /* Fields */

        //-------------------------------------------------------------------
        /* Properties */
        public Vector2 Pos => transform.localPosition;

        public SneakBlockBase FrontBlock { get; private set; }

        //--------------------------------------------------
        /* Events */

        //-------------------------------------------------------------------
        /* Messages */
        /// <summary> èâä˙âªèàóù </summary>
        public void Initialize(SneakBlockBase frontBlock, Vector2 startDir)
        {
            FrontBlock = frontBlock;

            if (frontBlock != null) {
                transform.position = frontBlock.Pos - startDir;
            }
        }

        //-------------------------------------------------------------------
        /* Methods */
    }
}