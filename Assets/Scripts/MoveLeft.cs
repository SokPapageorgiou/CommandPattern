using UnityEngine;

public class MoveLeft : ICommand
{
    private GameObject target;

    public MoveLeft(GameObject target)
    {
        this.target = target;
    }

    public void Execute()
    {
        target.transform.position += Vector3.left;
    }

    public void Undo()
    {
        target.transform.position -= Vector3.left;
    }
}