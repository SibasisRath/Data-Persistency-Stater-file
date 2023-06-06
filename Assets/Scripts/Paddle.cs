using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 5.0f;
    public float MaxMovement = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;

        /*Vector3 pos = transform.position;
        Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = new Vector3(Mathf.Clamp(mouse.x, -2f, 2f),transform.position.y,transform.position.z);*/
    }
}
