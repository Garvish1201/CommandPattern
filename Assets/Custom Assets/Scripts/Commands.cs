using UnityEngine;


public abstract class Commands 
{
    abstract public void Excecute(Rigidbody player, float speed, int direction);
}

public class Zdirection : Commands
{
    public override void Excecute(Rigidbody player, float speed, int direction)
    {
        player.velocity = new Vector3
            (
                player.velocity.x, 
                player.velocity.y, 
                direction
            ).normalized * speed;
    }
}

public class Xdirection : Commands
{
    public override void Excecute(Rigidbody player, float speed, int direction)
    {
        player.velocity = new Vector3
            (
                direction,
                player.velocity.y,
                player.velocity.z
            ).normalized * speed;
    }
}