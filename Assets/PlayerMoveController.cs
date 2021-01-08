using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
	float speed = 2.0f;
	ICommand move;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void FixedUpdate()
    {
	    if(Input.GetKey(KeyCode.W))
	    {
	    	ICommand move = new UserMoveUp(transform, speed);
	    	move.Execute();
	    	CommandManager.Instance.Add(move);
	    }
	    if(Input.GetKey(KeyCode.S))
	    {
	    	ICommand move = new UserMoveDown(transform, speed);
	    	move.Execute();
	    	CommandManager.Instance.Add(move);
	    }
    }
}
