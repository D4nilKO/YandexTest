using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Coin: MonoBehaviour
    {
        public void Destroy()
        {
            gameObject.SetActive(false);
        }
    }
}