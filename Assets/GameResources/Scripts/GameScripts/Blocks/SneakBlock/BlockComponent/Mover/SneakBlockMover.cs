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
        /// <summary> �u���b�N�P�ʂ̈ړ� </summary>
        public void Move(SneakInputProvider inputProvider)
        {
            animator.PlayMovingAnim(nextPos, defaultDuration, () => {
                OnMoveCompleted(inputProvider);
            });
        }

        /// <summary> �ړ��������̏��� </summary>
        protected virtual void OnMoveCompleted(SneakInputProvider inputProvider)
        {
            SetNextPos(inputProvider);
        }

        /// <summary> �ړ���̌��菈�� </summary>
        protected abstract void SetNextPos(SneakInputProvider inputProvider);
    }
}