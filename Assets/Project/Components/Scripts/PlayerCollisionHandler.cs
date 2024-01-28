using System;
using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class PlayerCollisionHandler : MonoBehaviour
    {
        public event Action TouchedEnemy;
        public event Action TouchedCoin;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Coin coin))
            {
                NightPool.Despawn(coin.gameObject);
                TouchedCoin?.Invoke();
            }

            if (collision.TryGetComponent(out Enemy enemy))
            {
                TouchedEnemy?.Invoke();
            }

            if (collision.TryGetComponent(out Obstacle obstacle))
            {
                TouchedEnemy?.Invoke();
            }
        }
    }
}