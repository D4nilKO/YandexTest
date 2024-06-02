using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts.Enemy
{
    public class EnemyCollisionHandler: MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Bullet bullet))
            {
                NightPool.Despawn(bullet);
                NightPool.Despawn(gameObject);
            }
        }
    }
}