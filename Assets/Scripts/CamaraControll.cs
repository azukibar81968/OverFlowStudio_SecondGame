using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControll : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);
    }
}
