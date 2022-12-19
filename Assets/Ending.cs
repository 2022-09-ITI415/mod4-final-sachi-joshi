using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text winText;
    
    void OnCollsionEnter (Collision coll) 
    {
    
        Debug.Log("HaveCollidedWithSomething" + coll.gameObject.name);
        GameObject collidedWith = coll.gameObject;
       if (collidedWith.tag == "Player")
        {
           winText.gameObject.SetActive(true);
           //WinText.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            //count = count + 1;

           // SetCountText();
        }
        Debug.Log("HaveCollidedWithSomething" + other.gameObject.name);
        GameObject collidedWith = other.gameObject;
       if (collidedWith.tag == "Player")
        {
           winText.gameObject.SetActive(true);
           //WinText.gameObject.SetActive(true);
        }
    }
}
    
