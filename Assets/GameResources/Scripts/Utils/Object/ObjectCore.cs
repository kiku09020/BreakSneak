using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    [DisallowMultipleComponent]
    public class ObjectCore : MonoBehaviour
    {
        List<ObjectComponent> components = new List<ObjectComponent>();

        //--------------------------------------------------
        /* Messages */
        protected virtual void Awake()
        {
            // Get components
            components.AddRange(GetComponents<ObjectComponent>());
            components.AddRange(GetComponentsInChildren<ObjectComponent>());
            components.Sort((a, b) => a.Priority - b.Priority);

            // Initialize components
            components.ForEach(component => {
                component.Initialize(this);
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
