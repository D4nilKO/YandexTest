using Project.Components.Scripts.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Components.Scripts.Utility
{
    public class GameOverHandler : MonoBehaviour
    {
        [SerializeField] private PlayerCollisionHandler _playerCollisionHandler;

        private void Awake()
        {
            if (_playerCollisionHandler == null)
            {
                _playerCollisionHandler = FindObjectOfType<PlayerCollisionHandler>();
                Debug.LogWarning($"{_playerCollisionHandler.GetType()} is not set manual and founded automatically");
            }
        }

        private void OnEnable()
        {
            _playerCollisionHandler.TouchedEnemy += ReloadLevel;
        }

        private void OnDisable()
        {
            _playerCollisionHandler.TouchedEnemy -= ReloadLevel;
        }

        private void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}