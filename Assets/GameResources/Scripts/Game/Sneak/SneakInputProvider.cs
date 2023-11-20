using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Sneak
{
    public class SneakInputProvider
    {
        /* Fields */
        SneakInputClass inputData = new SneakInputClass();

        //-------------------------------------------------------------------
        /* Properties */
        public Vector2 MoveInputVector { get; private set; }
        public bool IsMoveInput => MoveInputVector.magnitude > 0;
        public bool IsDashInput { get; private set; }

        //-------------------------------------------------------------------
        /* Messages */
        public void Initialize()
        {
            inputData.SneakInput.Move.performed += ctx => MoveInputVector = ctx.ReadValue<Vector2>();
            inputData.SneakInput.Dash.performed += ctx => IsDashInput = true;

            inputData.Enable();
        }

        public void Dispose()
        {
            inputData?.Dispose();
        }

        //-------------------------------------------------------------------
        /* Methods */
    }
}