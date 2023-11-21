using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock {
    public class SneakBlockAnimator : SneakComponentBase {
        /* Fields */
        [SerializeField] Ease movingAnimEase;

        //-------------------------------------------------------------------
        /* Properties */

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */
        public void PlayMovingAnim(Vector2 targetPos, float duration, System.Action onComp)
        {
            core.transform.DOLocalMove(targetPos, duration)
                .SetEase(movingAnimEase)
                .OnComplete(() => onComp?.Invoke());
        }

    }
}