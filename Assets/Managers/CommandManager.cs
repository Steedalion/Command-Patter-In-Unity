using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class CommandManager : MonoBehaviour
{
	
	List<ICommand> commandBuffer = new List<ICommand>();
	private static CommandManager instance;
	WaitForSeconds wait = new WaitForSeconds(1);
	public static CommandManager Instance
	{
		get {
			if(instance == null)
				Debug.LogError("The CommandManager is NULL");
			
			return instance;
		}
	}
	
	
	private void Awake()
	{
		instance = this;
	}
	
	public void Add(ICommand command)
	{
		commandBuffer.Add(command);
	}
	#region Play
	public void Play()
	{
		StartCoroutine(PlayCommands());
		
	}
	
	IEnumerator PlayCommands()
	{
		Debug.Log("Playing commands"+commandBuffer.Count);
		foreach (ICommand item in commandBuffer)
		{
			item.Execute();
			yield return wait;
		}
	}
	public void ReversePlay()
	{
		StartCoroutine(ReverseCommands());
		
	}
	IEnumerator ReverseCommands()
	{
		foreach (var item in Enumerable.Reverse(commandBuffer))
		{
			item.UnExecute();
			yield return wait;
		}

	}
	public void Done()
	{
		GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
		foreach (var cube in cubes)
		{
			cube.GetComponent<MeshRenderer>().material.color = Color.white;
		}
	}
	public void Reset()
	{
		commandBuffer.Clear();
	}
	#endregion 
	//Play: play back all commands , 1sec dely
	// Rewind, play in reverse;
	//Done = all white
	//Reset Clear buffer
}
