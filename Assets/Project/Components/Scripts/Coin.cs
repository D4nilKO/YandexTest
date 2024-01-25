using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Coin : MonoBehaviour
    {
        private void OnBecameInvisible()
        {
            if (gameObject.activeInHierarchy)
            {
                NightPool.Despawn(gameObject);
            }
        }
    }
}