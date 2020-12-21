﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{

    public GameObject brush;
    public float brushsize = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(1))
        {
            //cast a ray to the plane
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                //instanciate a brush
                var paint = Instantiate(brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                paint.transform.localScale = Vector3.one * brushsize;
            }

        }

    }
}
