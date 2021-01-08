using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMoveUp: ICommand
{
	Transform player;
	float speed;
	
	public UserMoveUp(Transform player, float speed)
	{
		this.player = player;
		this.speed = speed;
	}
	public void Execute()
	{
		player.Translate(Vector3.up * Time.fixedDeltaTime * speed);
	}
	public void UnExecute()
	{
		player.Translate(Vector3.down * Time.fixedDeltaTime * speed);
	}
}

public class UserMoveDown: ICommand
{
	Transform player;
	float speed;
	
	public UserMoveDown(Transform player, float speed)
	{
		this.player = player;
		this.speed = speed;
	}
	public void Execute()
	{
		player.Translate(Vector3.down * Time.fixedDeltaTime * speed);
	}
	public void UnExecute()
	{
		player.Translate(Vector3.up * Time.fixedDeltaTime * speed);
	}
}
