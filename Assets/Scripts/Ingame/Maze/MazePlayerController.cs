using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazePlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 inputVec;
    public Vector2 InputVec { get { return inputVec; } set { inputVec = value; } }
    public bool mazeClear = false;

    private Rigidbody2D rigid;
    private BoxCollider2D boxColl;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        //InputManage();
        Move();
    }
    //private void InputManage()
    //{
    //    float inputX = Input.GetAxisRaw("Horizontal");
    //    float inputY = Input.GetAxisRaw("Vertical");

    //    inputVec = new Vector2(inputX, inputY).normalized;
    //}
    private void Move()
    {
        rigid.MovePosition(rigid.position + inputVec * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            mazeClear = true;
            Invoke("Clear", 2f);
        }
    }
    private void Clear()
    {
        Managers.Game.PlayerUIOn();
        Managers.Game.PuzzleSolve();
        GameObject go = GameObject.FindGameObjectWithTag("Puzzle");
        Destroy(go);
    }
}
