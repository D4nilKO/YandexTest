using TMPro;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textTMPMove;
        [SerializeField] private TextMeshProUGUI _textTMPShoot;
        
        [SerializeField] private PlayerMover _playerMover;
        [SerializeField] private PlayerShooter _playerShooter;

        private string _textMove;
        private string _textShoot;
        
        private KeyCode _moveKey;
        private KeyCode _shootKey;

        private void Start()
        {
            _moveKey = _playerMover.GetKey;
            _shootKey = _playerShooter.GetKey;

            _textMove = $"Press {_moveKey} to start";
            _textShoot = $"Press {_shootKey} to shoot";
            
            _textTMPMove.text = _textMove;
            _textTMPShoot.text = _textShoot;

            _textTMPMove.gameObject.SetActive(true);
            _textTMPShoot.gameObject.SetActive(true);

            Time.timeScale = 0;
        }

        // Можно сделать анимацию типа текст появляется по буквам и также исчезает

        private void Update()
        {
            if (Input.GetKey(_moveKey))
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            _textTMPMove.gameObject.SetActive(false);
            _textTMPShoot.gameObject.SetActive(false);
            
            Time.timeScale = 1;
            
            gameObject.SetActive(false);
        }
    }
}