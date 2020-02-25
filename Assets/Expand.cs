using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    private float timeBtwShots;
    public float startTimeBtwShots;
    private Vector3 scale;
    private Vector3 tmp;
    public float scaleSpeed;
    public float desiredScale;
    Transform rb;

    // Start is called before the first frame update
    void Start()
    {
        scale = new Vector3(desiredScale, desiredScale, desiredScale);
        rb = GetComponent<Transform>();
        //timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        //if (timeBtwShots <= 0 && rb.transform.localScale != scale)
        //{
        //    rb.transform.localScale += scale * scaleSpeed;
        //    timeBtwShots = startTimeBtwShots;
        //}
        //else
        //    timeBtwShots -= Time.deltaTime;

        tmp += scale * Time.deltaTime * scaleSpeed;
    }
}
