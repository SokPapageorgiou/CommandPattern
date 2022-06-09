using UnityEngine;

public class MoveDirection : ICommand
{
    private GameObject target;
    private Vector3 direction;

    public MoveDirection(GameObject target, Vector3 direction)
    {
        this.target = target;
        this.direction = direction;
    }

    public void Execute()
    {
        target.transform.position += direction;
    }

    public void Undo()
    {
        target.transform.position -= direction;
    }
}
