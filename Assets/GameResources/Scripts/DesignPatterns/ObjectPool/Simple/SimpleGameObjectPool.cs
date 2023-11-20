using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    /// <summary> �����PooledObject�𐶐�����I�u�W�F�N�g�v�[�� </summary>
    public class SimpleGameObjectPool : SimpleObjectPool<GameObject> 
    {
        [SerializeField,Tooltip("�������ɗL�������邩")] 
        bool setActiveOnCreate = true;
        //-------------------------------------------------------------------
        /* Events */
        protected override GameObject OnCreate(GameObject prefab, Transform parent)
        {
            var obj = base.OnCreate(prefab, parent);
            obj.SetActive(setActiveOnCreate);
            return obj;
        }

        protected override void OnGetFromPool(GameObject obj)
        {
            obj.SetActive(true);
        }

        protected override void OnReleaseToPool(GameObject obj)
        {
           obj.SetActive(false);
        }

        protected override void OnDestroyObject(GameObject obj)
        {
            Destroy(obj);
        }
    }
}