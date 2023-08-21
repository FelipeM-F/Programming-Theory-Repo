using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Material material;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;
        
        InvokeRepeating("ObjectRandomize", 2.0f, 0.5f);
    }
    
    void Update()
    {   
        transform.Rotate(15.0f * Time.deltaTime, 25.0f * Time.deltaTime, 5.0f * Time.deltaTime);

    }

    void ObjectRandomize(){
        material.color= new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
        transform.localScale  = new Vector3(Random.Range(0.5f,4.5f), Random.Range(0.5f,4.5f) , Random.Range(0.5f,4.5f));
        transform.position = new Vector3(Random.Range(-8.5f,8.5f) , 0 , Random.Range(-4.5f,4.5f)) ;
    }
}
