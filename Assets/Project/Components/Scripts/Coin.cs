using UnityEngine;

namespace Project.Components.Scripts
{
    public class Coin : MonoBehaviour
    {
        private void OnBecameInvisible()
        {
            UserUtils.TryDespawn(gameObject);
        }
    }
}