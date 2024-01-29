using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(PlayerCollisionHandler))]
    public class PlayerScore : MonoBehaviour
    {
        private PlayerCollisionHandler _playerCollisionHandler;

        private int _score;

        public event Action<int> ScoreChanged;

        private int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreChanged?.Invoke(_score);
            }
        }

        private void Awake()
        {
            _playerCollisionHandler = GetComponent<PlayerCollisionHandler>();
            Score = 0;
        }

        private void OnEnable()
        {
            _playerCollisionHandler.TouchedCoin += IncreaseScore;
        }

        private void OnDisable()
        {
            _playerCollisionHandler.TouchedCoin -= IncreaseScore;
        }

        private void IncreaseScore()
        {
            Score++;
        }
    }
}