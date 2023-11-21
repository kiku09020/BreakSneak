using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock
{
    public class SneakBlockBase : BlockBase
    {
        /* Fields */
        /// <summary> 次のブロックの位置 </summary>
        protected Vector2Int nextPos;

        /// <summary> 前のブロック </summary>
        protected SneakBlockBase frontBlock;

        //-------------------------------------------------------------------
        /* Properties */

        //--------------------------------------------------
        /* Events */

        //-------------------------------------------------------------------
        /* Messages */
        public override void Initialize()
        {
            base.Initialize();


        }

        //-------------------------------------------------------------------
        /* Methods */
        /// <summary> 移動完了時の処理 </summary>
        public virtual void OnMoveCompleted()
        {

        }
    }
}