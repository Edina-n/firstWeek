using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SkinScript : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;
    public GameObject caps;
    public Button rightButton; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {

        this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        this.transform.position = new Vector3(0f, -3f, 0); 
 
    }

    public void OnMouseUp()
    {
        this.transform.localScale = new Vector3(1f, 1f, 1f);

    }

}
