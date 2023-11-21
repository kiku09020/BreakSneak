using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock
{
    public class SneakBodyBlock : SneakBlockBase
    {
        /* Fields */

        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */
        public override void OnMoveCompleted()
        {
            base.OnMoveCompleted();
            nextPos = Vector2Int.RoundToInt(frontBlock.transform.position);
        }
    }
}