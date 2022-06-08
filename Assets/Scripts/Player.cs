using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Executer _executer;
    private void Awake()
    {
        _executer = FindObjectOfType<Executer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) _executer.Enqueue(new MoveUp(gameObject));
        if(Input.GetKeyDown(KeyCode.A)) _executer.Enqueue(new MoveLeft(gameObject));
        if(Input.GetKeyDown(KeyCode.S)) _executer.Enqueue(new MoveDown(gameObject));
        if(Input.GetKeyDown(KeyCode.D)) _executer.Enqueue(new MoveRight(gameObject));
    }
}
