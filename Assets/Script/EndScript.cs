using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject us;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            endScreen.gameObject.SetActive(true);
            us.gameObject.SetActive(false);
        }
    }
}
