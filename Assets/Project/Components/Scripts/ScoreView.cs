using TMPro;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private PlayerScore _playerScore;
        [SerializeField] private TextMeshProUGUI _scoreTMP;

        private void OnEnable()
        {
            _playerScore.ScoreChanged += ShowScore;
        }

        private void OnDisable()
        {
            _playerScore.ScoreChanged -= ShowScore;
        }

        private void ShowScore(int score)
        {
            _scoreTMP.text = score.ToString();
        }
    }
}