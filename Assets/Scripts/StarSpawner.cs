using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;

    public GameObject triangle;

    public GameObject square;


    private int starCount;

    // Start is called before the first frame update
    void Start()
    {
        GameObject clone = Instantiate(star, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
        clone.gameObject.tag = "Clone";
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void SpawnStar()
    {
        GameObject clone = Instantiate(star, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
        clone.gameObject.tag = "Clone";
    }

    public void DestroyAllStars()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag("Clone");


        for(int i = 0; i < clones.Length; i++)
        {
            Destroy(clones[i]);

        }
    }
}


