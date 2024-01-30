using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class EnemyCollisionHandler: MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Bullet bullet))
            {
                NightPool.Despawn(bullet.gameObject);
                NightPool.Despawn(gameObject);
            }
        }
    }
}