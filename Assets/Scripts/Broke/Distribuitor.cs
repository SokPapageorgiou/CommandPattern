using System;
using UnityEngine;

namespace Broke
{
    public class Distribuitor : MonoBehaviour
    {
        public event EventHandler<string> scoreUpdated;

        public void Publish(object obj, string message)
        {
            scoreUpdated.Invoke(obj, message); 
        }
            
    }
}
