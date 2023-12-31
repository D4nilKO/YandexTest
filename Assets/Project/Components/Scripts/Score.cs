﻿using System;
using TMPro;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Score: MonoBehaviour
    {
        [SerializeField] private TMP_Text _score;

        [SerializeField] private Player _player;

        private void OnEnable()
        {
            _player.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            _player.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _score.text = score.ToString();
        }
    }
}