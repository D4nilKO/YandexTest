using TMPro;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textTMP;
        [SerializeField] private PlayerMover _playerMover;

        private string _text;
        private KeyCode _key = KeyCode.Space;

        private void Start()
        {
            _key = _playerMover.GetKey;

            _text = $"Press {_key} to start";
            _textTMP.text = _text;

            _textTMP.gameObject.SetActive(true);

            Time.timeScale = 0;
        }

        // Можно сделать анимацию типа текст появляется по буквам и также исчезает

        private void Update()
        {
            if (Input.GetKey(_key))
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            _textTMP.gameObject.SetActive(false);
            Time.timeScale = 1;
            
            gameObject.SetActive(false);
        }
    }
}