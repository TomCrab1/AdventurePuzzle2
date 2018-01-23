using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {


    public List<GameObject> GemTypes;
    public Vector2 BoardSize;
	// Use this for initialization
	void Start () {
        for(int x = 0; x < BoardSize.x; x++)
        {
            for(int y = 0; y<BoardSize.y; y++)
            {
                GameObject newgem = GameObject.Instantiate(GemTypes[Random.Range(0,GemTypes.Count)]);
                newgem.transform.parent = this.transform;
                newgem.transform.position = new Vector3(x, y, 0)/2;
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
