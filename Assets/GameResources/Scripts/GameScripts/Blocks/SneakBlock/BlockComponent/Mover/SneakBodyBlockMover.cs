using Game.Sneak;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    public class SneakBodyBlockMover : SneakBlockMover {
        /* Fields */

        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */

        protected override void SetNextPos(SneakInputProvider inputProvider)
        {
            nextPos = core.FrontBlock.Pos;
        }
    }
}