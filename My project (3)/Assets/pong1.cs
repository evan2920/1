using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pong1 : MonoBehaviour
{
    public bool ispong1;
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ispong1)
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        else
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
    }
}
