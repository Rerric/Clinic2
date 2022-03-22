using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject[] animations;

    public int current;

    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            current += 1;
            if (current == 3)
            {
                current = 0;
            }
        }

        for (var i = 0; i < 3; i++)
        {
            if (i == current)
            {
                animations[i].SetActive(true);
            }
            else animations[i].SetActive(false);
        }
    }
}
