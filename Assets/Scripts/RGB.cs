using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGB : MonoBehaviour
{
    Color colr;
    [SerializeField] private Color color;
    [SerializeField] private bool rgb;
    SpriteRenderer sprite;
    public float Speed;
    float r, g, b;
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        sprite = GetComponent<SpriteRenderer>();
        colr = sprite.color;
        colr = color;
    }
    void Update()
    {
        if(rgb)
        {
            if (r < 1f)
            {
                r += Random.Range(0f, 1f) * Time.deltaTime;
            }
            else
            {
                r = Random.Range(0f, 1f);
            }
            if (g < 1f)
            {
                g += Random.Range(0f, 1f) * Time.deltaTime;
            }
            else
            {
                g = Random.Range(0f, 1f);
            }
            if (b < 1f)
            {
                b += Random.Range(0f, 1f) * Time.deltaTime;
            }
            else
            {
                b = Random.Range(0f, 1f);
            }
            colr.r = r;
            colr.g = g;
            colr.b = b;
        }
        sprite.color = colr;
    }
}
