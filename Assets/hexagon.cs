using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour
{
    public Rigidbody2D _rb;

    public float speed = 3f;



    void Start()
    {
        _rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * speed * Time.deltaTime;

        if (transform.localScale.x < 0.05f)
            Destroy(gameObject);
    }
}
