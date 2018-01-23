using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{


    public List<GameObject> GemTypes;
    public Vector2 BoardSize;
    public GameObject[,] Gems;
    // Use this for initialization
    void Start()
    {
        Gems = new GameObject[(int)BoardSize.x, (int)BoardSize.y];
        for (int x = 0; x < BoardSize.x; x++)
        {
            for (int y = 0; y < BoardSize.y; y++)
            {

                Gems[x, y] = GameObject.Instantiate(GemTypes[Random.Range(0, GemTypes.Count)]);
                Gems[x, y].GetComponent<GemController>().x = x;
                Gems[x, y].GetComponent<GemController>().y = y;
                Gems[x, y].transform.parent = this.transform;
                Gems[x, y].transform.position = new Vector3(x, y, 0) / 2;
            }
        }
    }
    public void ClickGem(int x, int y)
    {
        GetColumn(x).ForEach(f => f.transform.localScale = new Vector3(1, 0.5f, 0));
        GetRow(y).ForEach(f => f.transform.localScale = new Vector3(0.5f,1, 0));
    }

    public List<GameObject> GetColumn(int x)
    {
        List<GameObject> row = new List<GameObject>();
        for (int y = 0; y < BoardSize.y; y++)
        {
            row.Add(Gems[x, y]);
        }
        return row;
    }
    public List<GameObject> GetRow(int y)
    {
        List<GameObject> row = new List<GameObject>();
        for (int x = 0; x < BoardSize.x; x++)
        {
            row.Add(Gems[x, y]);
        }
        return row;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
