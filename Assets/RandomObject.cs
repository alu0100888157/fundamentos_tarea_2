using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject Terrain;
    public GameObject Ethan;
    Renderer thisrend;
    // Start is called before the first frame update
    void Start()
    {
        Terrain = GameObject.Find("Terrain");
        Ethan = GameObject.Find("ThirdPersonController");
        thisrend = GetComponent<Renderer>();
        transform.position = new Vector3(Random.Range(0f, 50f), 1, Random.Range(100f, 170f));
        //var rb = GetComponent<Rigidbody>();
        //rb.velocity = RandomVector(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(((Ethan.transform.position.x - this.transform.position.x >= -0.3) && (Ethan.transform.position.x - this.transform.position.x <= 0.3)) || ((Ethan.transform.position.z - this.transform.position.z >= -0.3) && (Ethan.transform.position.z - this.transform.position.z <= 0.3)))
        {
            thisrend.material.SetColor("_Color", Color.green);

        }
    }
    /*private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        //var y = Input.GetAxis("Vertical");
        var z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }*/
}
