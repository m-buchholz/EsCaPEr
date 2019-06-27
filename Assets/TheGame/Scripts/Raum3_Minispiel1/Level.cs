using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Level : MonoBehaviour
{

    public Text text;
    public EnemyManager EM;
    public GameObject obj;
    public GameObject greenLight;
    public float lightTime = 2f;
    public float time;

    

    private int count;

    private int countH;
    private int countNa;
    private int countPt;
    private Rigidbody rb;



    public string lvl = "lvl";

    public string lvl1 = "Sauerstoff"; //O2 
    public string lvl2 = "Wasser"; //H2O
    public string lvl3 = "Platin" ; //NaOH
    public string lvl4 = "Natriumhydroxid"; //Pt
    public string end = "WELL DONE!";



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
        //EM = GetComponent<EnemyManager>();
        //text.text = "Sauerstoff";
        setCountTextO();
        greenLight.SetActive(false);
        


    }

    

    // Update is called once per frame
    void Update()
    {
        
        //swtitch lvl, sets counters to 0
        if (text.text.Equals(lvl1) && count == 2)
        {
            setName2();
         
            DestroyAllO();
            DestroyAllH();
            DestroyAllNa();
            DestroyAllPt();
            
        }

        if (text.text.Equals(lvl2) && countH >= 2 && count >= 1)
        {
            setName3();
            DestroyAllO();
            DestroyAllH();
            DestroyAllNa();
            DestroyAllPt();
            
        }

        if(text.text.Equals(lvl3) && countPt >=1)
        {
            setName4();
            DestroyAllO();
            DestroyAllH();
            DestroyAllNa();
            DestroyAllPt();
            
        }

        if (text.text.Equals(lvl4) && countNa >= 1 && count >= 1 && countH >= 1)
        {
            setName5();
            DestroyAllO();
            DestroyAllH();
            DestroyAllNa();
            DestroyAllPt();
           //makes sure no more molecules are comin by destroying game object with enemy manager script
            Destroy(obj);
        }

        //Debug.Log("counter " + count);
       // Debug.Log("part 1 " + text.text.Equals(lvl1));
       // Debug.Log("part2 " + text.text.Equals(lvl));
    }



    //Checking for TAGS, counting molecules
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("O"))
        {
            if(text.text.Equals(lvl1) &&count <=2)
            {
                blinkGreen();
            }
            
            count = count + 1;
            
        }

        if (other.gameObject.CompareTag("H"))
        {
            countH = countH + 1;
            
        }

        if (other.gameObject.CompareTag("Pt"))
        {
            countPt = countPt + 1;
        }

        if (other.gameObject.CompareTag("Na"))
        {
            countNa = countNa + 1;
        }

    }
    //destroys all circles on field
    private void DestroyAllO()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("O");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);

    }

    private void DestroyAllH()
    {
        GameObject[] enemiesH = GameObject.FindGameObjectsWithTag("H");
        foreach (GameObject enemyH in enemiesH)
            GameObject.Destroy(enemyH);

    }

    private void DestroyAllNa()
    {
        GameObject[] enemiesN = GameObject.FindGameObjectsWithTag("Na");
        foreach (GameObject enemyN in enemiesN)
            GameObject.Destroy(enemyN);

    }

    private void DestroyAllPt()
    {
        GameObject[] enemiesP = GameObject.FindGameObjectsWithTag("Pt");
        foreach (GameObject enemyP in enemiesP)
            GameObject.Destroy(enemyP);

    }

    //updates O counter... puts first name/lvl in text field
    void setCountTextO()
    {
        if (text.text.Equals(lvl1) || text.text.Equals(lvl))
        {
            text.text = lvl1;
            Debug.Log("counter " + count);
        }
        
    }

    // switches the level and texts
      void setName2 ()
      {
          //if (text.text.Equals(lvl1) && count == 2)
          //{
        text.text = lvl2;
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
        //}
    }

    void setName3()
    {
        text.text = lvl3;
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
    }

    void setName4()
    {
        text.text = lvl4;
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
    }


    void setName5()
    {
        text.text = end;
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
    }


    void blinkGreen()
    {
        time = 0;
        while(time < lightTime)
        {
            greenLight.SetActive(true);
            time += Time.deltaTime;
            //System.Threading.Thread.Sleep(5000);
            greenLight.SetActive(false);
        }
        //greenLight.SetActive(false);
    }

}