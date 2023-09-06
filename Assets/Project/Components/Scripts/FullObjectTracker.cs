using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class FullObjectTracker: MonoBehaviour
    {
        [SerializeField] private GameObject _gameObject;
        
        private void Update()
        {
            transform.position = _gameObject.transform.position;
        }
    }
}