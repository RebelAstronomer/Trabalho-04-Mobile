using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    private BoxCollider boxCollider;
    public AudioSource hitFX;
    public Camera cam;
    private GameObject levelControl;

    void Start()
    {
        boxCollider = this.GetComponent<BoxCollider>();
        levelControl = GameObject.Find("LevelController");
    }

    void OnTriggerEnter(Collider other)
    {
        boxCollider.enabled = false;
        hitFX.Play();
        player.GetComponent<PlayerMove>().enabled = false;
        cam.GetComponent<Animator>().enabled = true;
        if (levelControl != null)
        {
            levelControl.GetComponent<LevelDistance>().enabled = false;
            levelControl.GetComponent<EndRunSequence>().enabled = true;
        }
    }
}
