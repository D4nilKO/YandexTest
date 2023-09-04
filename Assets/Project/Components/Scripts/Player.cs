using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(PlayerMover))]
    [RequireComponent(typeof(PlayerCollisionHandler))]
    public class Player : MonoBehaviour
    {
        private PlayerMover _mover;
        [SerializeField] private int _score;

        private void Start()
        {
            _mover = GetComponent<PlayerMover>();

            ResetPlayer();
        }

        public void IncreaseScore()
        {
            _score++;
        }

        public void ResetPlayer()
        {
            _score = 0;
            _mover.Reset();
        }

        public void Die()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}