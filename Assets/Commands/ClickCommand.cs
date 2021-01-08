using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
	private Color color;
	private GameObject cube;
	
	
	public ClickCommand(GameObject cube, Color color)
	{
		this.color = color;
		this.cube = cube;
	}
	
	public void Execute()
	{
		cube.GetComponent<MeshRenderer>().material.color = color;
	}
	public void UnExecute()
	{
		
	}
	
   
}
