using System;
using RPG.Saving;
using UnityEngine;

namespace RPG.Stats
{
    public class Experience : MonoBehaviour, ISaveable
    {
        [SerializeField] float experiencePoints = 0;

        //public delegate void ExperienceGainedDelegate();
        //Action is the same as a void delegate with no parameters
        public event Action onExperienceGained;

        public void GainExperience(float experience)
        {
            this.experiencePoints += experience;
            onExperienceGained();
        }

        public float GetExperience()
        {
            return experiencePoints;
        }

        public object CaptureState()
        {
            return experiencePoints;
        }

        public void RestoreState(object state)
        {
            experiencePoints = (float)state;
        }
    }
}