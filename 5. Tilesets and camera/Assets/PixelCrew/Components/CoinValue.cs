using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{

    public class CoinValue : MonoBehaviour
    {
        private int _coinValue = 0;
        [SerializeField] private Hero _hero;
        [SerializeField] private GameObject _coin;
        //int _coinCounter = 0;
        public void CoinCounter()
        {
            if (_coin.gameObject.layer == 12)
            {
                _coinValue = 1;
            }
            else if (_coin.gameObject.layer == 13)
            {
                _coinValue = 10;
            }

            _hero._coinCounter += _coinValue;
            Debug.Log("Amount of coins collected: " + _hero._coinCounter);
        }
    }
}