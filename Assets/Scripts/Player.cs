using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;
    public float thrust = 1.0f;
    public float superthrust = 1.5f;
    private Rigidbody2D rb2D;
    public OnGround onGround;
    public bool isGround = false;
    public bool isDead = false;
    public bool isSquat = false;
    public GameObject bomb;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.gameObject.GetComponent<Rigidbody2D>();
        isDead = false;
    }

    // Update is called once per frame
    private void Update()
    {
        //update
        this.gameObject.transform.Translate(speed, 0, 0);
        isGround = onGround.IsGround();

        //input manager
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            if (isSquat == true)
            {
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                isSquat = false;

                rb2D.velocity = new Vector3(0.2f, superthrust) * 8;
                Debug.Log("super jump");
            }
            else
            {
                rb2D.velocity = new Vector3(0, thrust) * 8;
                Debug.Log("jump");
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && isSquat == false)
        {
            gameObject.transform.localScale = new Vector3(1.1f, 0.5f, 1);
            isSquat = true;
            Debug.Log("squat");
        }
        if (Input.GetKey(KeyCode.LeftShift) == false && isSquat == true)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            isSquat = false;
            Debug.Log("un-squat");

        }
        if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.N))
        {
            Instantiate(bomb,gameObject.transform.position,gameObject.transform.rotation);
            Debug.Log("bomb");
        }


        //check
        if (gameObject.transform.position.y < -1.0f)
        {
            isDead = true;
        }
    }

}


