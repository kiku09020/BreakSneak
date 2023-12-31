using Game.Sneak;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    public class SneakHeadBlockMover : SneakBlockMover {
        /* Fields */

        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */

        protected override void SetNextPos(SneakInputProvider inputProvider)
        {
            Vector2 moveDir=Vector2.zero;

            // 入力があれば、その方向に移動
            if (inputProvider.IsMoveInput) {
                moveDir = inputProvider.MoveInputVector;
            }

            // 入力がなければ、前方向に移動
            else {
                moveDir = core.transform.forward;
            }

            nextPos = core.Pos + moveDir;
        }
    }
}