using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class CoinMagnet : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Coin coin))
            {
                coin.SetAttractionMode(_player, true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Coin coin))
            {
                coin.SetAttractionMode(_player, false);
            }
        }
    }
}