using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{

    public int x;
    public int y;
    BoardController board;
    // Use this for initialization
    void Start()
    {
        board = GetComponentInParent<BoardController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        board.ClickGem(x, y);



    }
    void OnMouseUp()
    {
        Debug.Log("Up");
    }
}
