using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public GameObject wingUp;
    public GameObject wingDown;

    public float flapStringth = 12;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && logic.birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStringth;
            wingUp.SetActive(true);
            wingDown.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            wingUp.SetActive(false);
            wingDown.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
