using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(PlayerMover))]
    [RequireComponent(typeof(PlayerCollisionHandler))]
    public class Player : MonoBehaviour
    {
        private PlayerMover _mover;
        private int _score;

        public event UnityAction<int> ScoreChanged;

        private void Start()
        {
            _mover = GetComponent<PlayerMover>();

            ResetPlayer();
        }

        public void IncreaseScore()
        {
            _score++;
            ScoreChanged?.Invoke(_score);
        }

        private void ResetPlayer()
        {
            _score = 0;
            ScoreChanged?.Invoke(_score);
            
            _mover.Reset();
        }

        public void Die()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}