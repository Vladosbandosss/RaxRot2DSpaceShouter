using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    [SerializeField] private float speed = 0.3f;
    Material backGroundMaterial;
    private void Awake()
    {
        backGroundMaterial = GetComponent<Renderer>().material; 
     }

   
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = new Vector2(speed * Time.deltaTime, 0);
        backGroundMaterial.mainTextureOffset += offset;
    }
}
