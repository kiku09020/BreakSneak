using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    public class ObjectComponent : MonoBehaviour
    {
        /* Fields */
        [Header("Component Settings")]
        [SerializeField] int priority = 0;

        protected ObjectCore core;

        //--------------------------------------------------
        /* Properties */
        public int Priority => priority;

        //--------------------------------------------------
        /* Messages */
        public virtual void OnAwake() { }
        public virtual void OnStart() { }
        public virtual void OnUpdate() { }
        public virtual void OnFixedUpdate() { }
        public virtual void OnDestroyed() { }

        //--------------------------------------------------
        /* Methods */
        public void Initialize(ObjectCore core)
        {
            this.core = core;
        }
    }
}
