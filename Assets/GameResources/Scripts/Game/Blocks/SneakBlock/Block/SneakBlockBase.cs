using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Block.SneakBlock
{
    public class SneakBlockBase : BlockBase
    {
        /* Fields */
        /// <summary> ���̃u���b�N�̈ʒu </summary>
        protected Vector2Int nextPos;

        /// <summary> �O�̃u���b�N </summary>
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
        /// <summary> �ړ��������̏��� </summary>
        public virtual void OnMoveCompleted()
        {

        }
    }
}