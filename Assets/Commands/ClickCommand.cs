using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
	private Color color;
	private Color previousColor;
	private GameObject cube;
	MeshRenderer meshrenderer;
	
	
	public ClickCommand(GameObject cube, Color color)
	{
		this.color = color;
		this.cube = cube;
		meshrenderer = cube.GetComponent<MeshRenderer>();
		
	}
	
	public void Execute()
	{
		previousColor = meshrenderer.material.color;
		meshrenderer.material.color = color;
	}
	public void UnExecute()
	{
		meshrenderer.material.color = previousColor;
	}
	
   
}
