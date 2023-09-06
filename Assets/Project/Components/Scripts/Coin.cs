using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private bool _isAttracting;

        [SerializeField] private float _speed;

        private void Update()
        {
            Attract();
        }

        public void SetAttractionMode(Player player, bool attractionMode)
        {
            if (_player == null)
            {
                _player = player;
            }

            _isAttracting = attractionMode;
        }

        private void Attract()
        {
            if (_isAttracting)
            {
                transform.position = Vector3.MoveTowards(gameObject.transform.position, _player.transform.position,
                    _speed * Time.deltaTime);
            }
        }
    }
}