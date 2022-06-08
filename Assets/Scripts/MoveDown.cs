using UnityEngine;

public class MoveDown : ICommand
{
    private GameObject target;

    public MoveDown(GameObject target)
    {
        this.target = target;
    }

    public void Execute()
    {
        target.transform.position += Vector3.down;
    }

    public void Undo()
    {
        target.transform.position -= Vector3.down;
    }
}