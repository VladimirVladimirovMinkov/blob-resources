using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulding : MonoBehaviour
{
	
	public GameObject bottom;
	public float min;
	public float max;
	
    // Start is called before the first frame update
    void Start()
    {
		var size = Random.Range(min, max);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = bottom.transform.position + new Vector3(0, 0.5f+size/2, 0);	
		cube.transform.localScale = bottom.transform.localScale + new Vector3(1.5f, size, 1.5f);
		cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
