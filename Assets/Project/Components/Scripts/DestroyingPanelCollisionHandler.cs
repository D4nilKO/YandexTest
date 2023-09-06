using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class DestroyingPanelCollisionHandler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            NightPool.Despawn(collision.gameObject);
            
        }
    }
}