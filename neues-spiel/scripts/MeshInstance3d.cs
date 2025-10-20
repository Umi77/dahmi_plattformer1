using Godot;
using System;

public partial class MeshInstance3d : MeshInstance3D
{
	private float _speed = 30;
	private float _angularSpeed = Mathf.Pi;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        var direction = 0;
        if (Input.IsActionPressed("ui_left"))
        {
            direction = -1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            direction = 1;
        }

		var rotation = _angularSpeed * direction * (float)delta;
		RotateY(rotation);

		var velocity = Vector3.Zero;
        if (Input.IsActionPressed("ui_up"))
        {
            velocity = Vector3.Forward.Rotated(Vector3.Up, rotation) * _speed;
        }

        Position += velocity * (float)delta;
    }
}
