using Godot;
using System;

public partial class GameManager : Node
{
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("ui_accept"))
        {
            var nextScene = (PackedScene)ResourceLoader.Load("res://scenes/stage2.tscn");
            GetTree().ChangeSceneToPacked(nextScene);
        }
    }

}
