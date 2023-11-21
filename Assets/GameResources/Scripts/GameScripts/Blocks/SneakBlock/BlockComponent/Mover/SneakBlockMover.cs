using Game.Sneak;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    public abstract class SneakBlockMover : SneakComponentBase {
        /* Fields */
        [Header("Components")]
        [SerializeField] protected SneakBlockAnimator animator;

        [Header("Parameters")]
        [SerializeField] protected float defaultDuration = .25f;

        protected Vector2 nextPos;
        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */
        /// <summary> ブロック単位の移動 </summary>
        public void Move(SneakInputProvider inputProvider)
        {
            animator.PlayMovingAnim(nextPos, defaultDuration, () => {
                OnMoveCompleted(inputProvider);
            });
        }

        /// <summary> 移動完了時の処理 </summary>
        protected virtual void OnMoveCompleted(SneakInputProvider inputProvider)
        {
            SetNextPos(inputProvider);
        }

        /// <summary> 移動先の決定処理 </summary>
        protected abstract void SetNextPos(SneakInputProvider inputProvider);
    }
}