using System.Collections;
using UnityEngine;

public class MusAnim : MonoBehaviour
{
    private SpriteRenderer musicOn;
    private float _movementSpeed = 0.1f;

    void Start()
    {
        musicOn = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        musicOn.color = new Color(musicOn.color.r, musicOn.color.g, musicOn.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));

        transform.position += transform.up * Time.deltaTime * _movementSpeed;
    }
}
