 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player, checkpoint;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GameObject.FindWithTag("StartLevel");
        camera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject); //destroy player character
           GameObject newplayer=Instantiate(Player, checkpoint.transform.position, Quaternion.identity); //spawn a new player character at checkpoint position
            camera.GetComponent<FollowPlayer>().gameObjectFollowedByCamera = newplayer; //set object to follow on camera
            newplayer.GetComponent<BoxCollider2D>().enabled = true;
            newplayer.GetComponent<Movement>().enabled = true;
            print("Killed");
        }
    }
}
