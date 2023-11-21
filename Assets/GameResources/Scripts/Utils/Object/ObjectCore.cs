using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    [DisallowMultipleComponent]
    public class ObjectCore<T> : MonoBehaviour where T:ObjectCore<T>
    {
        List<ObjectComponent<T>> components = new List<ObjectComponent<T>>();

        //--------------------------------------------------
        /* Messages */
        protected virtual void Awake()
        {
            // Get components
            components.AddRange(GetComponents<ObjectComponent<T>>());
            components.AddRange(GetComponentsInChildren<ObjectComponent<T>>());
            components.Sort((a, b) => a.Priority - b.Priority);

            // Initialize components
            components.ForEach(component => {
                component.Initialize(this as T);
                component.OnAwake();
            });
        }

        protected virtual void Start()
        {
            components.ForEach(component => component.OnStart());
        }

        protected virtual void Update()
        {
            components.ForEach(component => component.OnUpdate());
        }

        protected virtual void FixedUpdate()
        {
            components.ForEach(component => component.OnFixedUpdate());
        }

        protected virtual void OnDestroy()
        {
            components.ForEach(component => component.OnDestroyed());
        }
    }
}
