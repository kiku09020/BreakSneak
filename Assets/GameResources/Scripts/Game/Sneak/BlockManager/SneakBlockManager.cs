using Game.Block;
using Game.Block.SneakBlock;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Sneak {
    public interface IBlockManager<T> where T: BlockBase
    {
        IReadOnlyList<T> Blocks { get; }

        void Initialize();
    }

    public class SneakBlockManager : MonoBehaviour,IBlockManager<SneakBlockBase> {
        /* Fields */
        [Header("Block")]
        [SerializeField] SneakHeadBlock headBlock;
        [SerializeField] SneakBodyBlockPool bodyBlockPool;

        [Header("Prameters")]
        [SerializeField, Tooltip("最初の体のブロック数")] int startBodyCount = 3;

        [Space]
        [SerializeField, Tooltip("生成時の方向")] Vector2 startDir = Vector2.down;

        List<SneakBlockBase> blocks;

        //-------------------------------------------------------------------
        /* Properties */
        public IReadOnlyList<SneakBlockBase> Blocks => blocks;

        //-------------------------------------------------------------------
        /* Messages */

        //-------------------------------------------------------------------
        /* Methods */
        public void Initialize()
        {
            // 初期化、頭追加
            blocks = new List<SneakBlockBase>() { headBlock };

            // 体追加
            for (int i = 0; i < startBodyCount; i++) {
                var blockObj = bodyBlockPool.Pool.Get().Block;
                blocks.Add(blockObj);

                blockObj.transform.position = headBlock.transform.position + (Vector3)startDir * -(i + 1);
            }
        }
    }
}