using UnityEngine;

public class MoveRight : ICommand
{
    private GameObject target;

    public MoveRight(GameObject target)
    {
        this.target = target;
    }

    public void Execute()
    {
        target.transform.position += Vector3.right;
    }

    public void Undo()
    {
        target.transform.position -= Vector3.right;
    }
}
