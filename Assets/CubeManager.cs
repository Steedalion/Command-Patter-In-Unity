using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			
			if(Physics.Raycast(ray, out hitInfo))
			{
				if(hitInfo.collider.CompareTag("Cube")){
					
					//hitInfo.collider.GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value, Random.value);
					ICommand clickCommand = new ClickCommand(hitInfo.collider.gameObject, new Color(Random.value,Random.value, Random.value));
					clickCommand.Execute();
					CommandManager.Instance.Add(clickCommand);
				}
			}
		}
        
    }
}
