using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{
    public class HealingPotionComponent : MonoBehaviour
    {
        [SerializeField] private int _healing;
        
        public void ApplyHealing(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyHealing(_healing);
            }
        }
    }
}