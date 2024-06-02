using Project.Components.Scripts.Utility;
using UnityEngine;

namespace Project.Components.Scripts.Player
{
    public class Coin : MonoBehaviour
    {
        private void OnBecameInvisible()
        {
            UserUtils.TryDespawn(gameObject);
        }
    }
}