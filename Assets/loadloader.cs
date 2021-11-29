using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadloader : MonoBehaviour
{
    public int ILevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToloadLevel = false;
  
  void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject collisionGameObject = collision.gameObject;
        Debug.Log(collisionGameObject.tag);
        if(collisionGameObject.tag == "Player")
        {
            LoadScene();
        }

    }       
    private void LoadScene()
    {
        if (useIntegerToloadLevel)
        {
            SceneManager.LoadScene(ILevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }

    }
}
