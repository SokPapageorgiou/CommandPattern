using System;
using UnityEngine;

namespace Broke
{
    public class Gem : MonoBehaviour
    {
        private Distribuitor distribuitor;

        private void Awake() => distribuitor = FindObjectOfType<Distribuitor>();

        private void OnTriggerEnter2D(Collider2D col) => distribuitor.Publish(this, "red");
    }
}
