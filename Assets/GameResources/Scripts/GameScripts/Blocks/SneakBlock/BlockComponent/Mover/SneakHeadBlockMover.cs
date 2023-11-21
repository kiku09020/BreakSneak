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

            // ���͂�����΁A���̕����Ɉړ�
            if (inputProvider.IsMoveInput) {
                moveDir = inputProvider.MoveInputVector;
            }

            // ���͂��Ȃ���΁A�O�����Ɉړ�
            else {
                moveDir = core.transform.forward;
            }

            nextPos = core.Pos + moveDir;
        }
    }
}