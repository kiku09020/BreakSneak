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

            // “ü—Í‚ª‚ ‚ê‚ÎA‚»‚Ì•ûŒü‚ÉˆÚ“®
            if (inputProvider.IsMoveInput) {
                moveDir = inputProvider.MoveInputVector;
            }

            // “ü—Í‚ª‚È‚¯‚ê‚ÎA‘O•ûŒü‚ÉˆÚ“®
            else {
                moveDir = core.transform.forward;
            }

            nextPos = core.Pos + moveDir;
        }
    }
}