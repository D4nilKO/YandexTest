using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(Player))]
    public class PlayerCollisionHandler : MonoBehaviour
    {
        private Player _player;

        private void Start()
        {
            _player = GetComponent<Player>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Coin coin))
            {
                NightPool.Despawn(coin.gameObject);
                _player.IncreaseScore();
            }
            else
            {
                _player.Die();
            }
        }
    }
}