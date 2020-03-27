using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioSource m_audio;
    private Transform m_transform;

    private SpriteRenderer m_sr;
    private Color m_color;

    // references to our other scripts
    public StarSpawner starScript;
    public GameController gc;

    Transform playerPos;

    private void Start()
    {
        m_transform = this.gameObject.GetComponent<Transform>();
        m_sr = this.gameObject.GetComponent<SpriteRenderer>();
        ChangeColor();
        //ResetPositionAndScale();

    }

    private void OnMouseDown()
    {
        gc.IncreaseScore();
        GoToNewPosition();
        ChangeColor();
        m_audio.Play();
        starScript.SpawnStar();
     //   starScript.DestroyAllStars();
//        starScript.SpawnTriangle();
    }

   public void ChangeColor()
    {
        float r = Random.Range(0.6f, 0.9f);
        float g = Random.Range(0.6f, 0.9f);
        float b = Random.Range(0.6f, 0.9f);
        m_sr.color = new Color(r, g, b);
    }

    public void GoToNewPosition()
    {
        m_transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f));
        float new_scale = Random.Range(1.0f, 3.5f);
        m_transform.localScale = new Vector3(new_scale, new_scale);
    }

    public void ResetPositionAndScale()
    {
        m_transform.position = new Vector3(0.0f, 0.0f);
        m_transform.localScale = new Vector3(1.0f, 1.0f);
    }
}
