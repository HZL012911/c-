using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("SampleScene011", LoadSceneMode.Single);
        //  StartCoroutine(Load());
        GameObject caed = GameObject.Find("Cube");
        DontDestroyOnLoad(caed);
        //GameObject Cylinder = GameObject.Find("Cylinder");
        //DontDestroyOnLoad(Cylinder);
    }

    public static IEnumerable Load()
   {
       AsyncOperation d  =SceneManager.LoadSceneAsync("");
        d.allowSceneActivation = false;
       while (d.progress>0.9 )
        {
            Debug.Log("d ");
            yield return null;
            
        }
        d.allowSceneActivation = true;
        if (d.isDone)
        {
            Debug.Log("yitiaozhuan");
        }
        else
        {
            Debug.Log("weitiaozhuan");
        }

    }
    void Update()
    {
         
    }
}
