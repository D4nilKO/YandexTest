using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public static class UserUtils
    {
        public static void TryDespawn(GameObject targetGameObject)
        {
            if (targetGameObject.activeInHierarchy)
            {
                NightPool.Despawn(targetGameObject);
            }
        }
    }
}