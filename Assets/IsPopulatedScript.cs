using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPopulatedScript : MonoBehaviour
{
    public bool isPopulated;
    public FallWord fallWord;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Letter" && fallWord.moving == false)
        {
            isPopulated = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        isPopulated = false;
    }
}

