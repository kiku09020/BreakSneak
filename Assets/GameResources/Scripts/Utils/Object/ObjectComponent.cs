using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    public class ObjectComponent<T> : MonoBehaviour where T : ObjectCore<T>
    {
        /* Fields */
        [Header("Component Settings")]
        [SerializeField] int priority = 0;

        protected T core;

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
        public void Initialize(T core)
        {
            this.core = core;
        }
    }
}
