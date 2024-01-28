using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class EnemyCollisionHandler: MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Obstacle obstacle))
            {
                
            }
        }
    }
}