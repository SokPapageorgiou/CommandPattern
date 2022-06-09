using System;
using UnityEngine;

namespace Broke
{
    public class ScoreTracker : MonoBehaviour
    {
        private Distribuitor distribuitor;
        private Score score;

        private void Awake()
        {
            distribuitor = FindObjectOfType<Distribuitor>();
            distribuitor.scoreUpdated += UpdateScore;
        }

        private void UpdateScore(object sender, string type)
        {
            if (type.CompareTo("red") == 0) score.Red++;
            else if(type.CompareTo("green") == 0) score.Green++;
            else if (type.CompareTo("blue") == 0) score.Blue++;
            
            Debug.Log(score);
        }
    }
}
