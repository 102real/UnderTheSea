using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudMaster : MonoBehaviour
{
    public GameObject WtChack;
    bool Ok;

    public GameObject INWT;
    public GameObject INWTT;

    public GameObject OUTWT;
    public GameObject OUTWTT;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ok = WtChack.GetComponent<MeshRenderer>().enabled;
        if (Ok)
        {
            Debug.Log("물안");
            OUTWT.SetActive(false);
            OUTWTT.SetActive(false);
            INWT.SetActive(true);
            INWTT.SetActive(true);

        }
        else
        {
            Debug.Log("물밖");
            INWT.SetActive(false);
            INWTT.SetActive(false);
            OUTWT.SetActive(true);
            OUTWTT.SetActive(true);

            

        }
    }
}
