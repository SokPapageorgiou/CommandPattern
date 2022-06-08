using UnityEngine;

public class MoveUp : ICommand
{
    private GameObject target;

    public MoveUp(GameObject target)
    {
        this.target = target;
    }

    public void Execute()
    {
        target.transform.position += Vector3.up;
    }

    public void Undo()
    {
        target.transform.position -= Vector3.up;
    }
}