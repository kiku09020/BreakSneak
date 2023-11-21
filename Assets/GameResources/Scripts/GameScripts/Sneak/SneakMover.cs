using DG.Tweening;
using Game.Block.SneakBlock;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Sneak {
    public class SneakMover : SneakComponentBase {
        /* Fields */
        [SerializeField] float moveSpeed = 1f;
        [SerializeField] float moveCoolTime = .25f;

        float moveCoolTimer;

        //--------------------------------------------------
        /* Messages */
        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();

            Move();
        }

        //--------------------------------------------------
        /* Methods */
        void Move()
        {
            moveCoolTimer += Time.fixedDeltaTime;

            if (moveCoolTimer >= moveCoolTime) {
                moveCoolTimer = 0;

                foreach(var block in core.Blocks) {
                    block.GetComponent<SneakBlockMover>().Move(core.InputProvider);
                }
            }

            var forward = core.transform.forward;


        }

        // •ûŒü“]Š·
        void ChangeMovingDirection()
        {

        }
    }
}