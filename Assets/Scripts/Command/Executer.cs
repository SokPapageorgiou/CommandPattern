using System.Collections.Generic;
using UnityEngine;

public class Executer : MonoBehaviour
{
    private Queue<ICommand> _queue = new();
    private Stack<ICommand> _undo = new();
    
    public void Enqueue(ICommand command) => _queue.Enqueue(command);

    private void Update()
    {
        while (_queue.Count > 0)
        {
            var command = _queue.Dequeue();
            command.Execute();
            _undo.Push(command);
        }

        if (_undo.Count > 0 && Input.GetKeyDown(KeyCode.Z)) _undo.Pop().Undo();
    }
}
