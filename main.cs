using Godot;
using System;

public partial class main : Node2D
{
	private void _on_play_pressed()
	{
		GetTree().ChangeSceneToFile("res://machine.tscn");
	}
	
	private void _on_quit_pressed()
	{
		GetTree().Quit();
	}
}
