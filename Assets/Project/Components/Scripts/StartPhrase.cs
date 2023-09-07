using TMPro;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class StartPhrase : MonoBehaviour
    {
        [SerializeField] private TMP_Text _phrase;

        [SerializeField] private PlayerMover _playerMover;

        private void OnEnable()
        {
            _playerMover.GameStarted += OnGameStarted;
        }

        private void OnDisable()
        {
            _playerMover.GameStarted -= OnGameStarted;
        }

        private void Start()
        {
            _phrase.gameObject.SetActive(true);
        }

        private void OnGameStarted()
        {
            _phrase.gameObject.SetActive(false);
        }
    }
}