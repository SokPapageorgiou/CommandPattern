using System;
using UnityEngine;

namespace Broke
{
    public class Distribuitor : MonoBehaviour
    {
        public event Action<string> scoreUpdated;
    }
}
