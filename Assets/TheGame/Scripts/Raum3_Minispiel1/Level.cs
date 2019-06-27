using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Level : MonoBehaviour
{

    public Text text;
    public Text text2;
    public Text text3;
    public EnemyManager EM;
    public GameObject obj;
    public GameObject greenLight;

    public AudioSource pling;
    public AudioSource badum;
    public bool alreadyPlayed = false;

    public float lightTime = 2f;
    public float time;

    public int i;

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
        text2.text = "";
        text3.text = "";
        //EM = GetComponent<EnemyManager>();
        //text.text = "Sauerstoff";
        setCountTextO();
        greenLight.SetActive(false);
        


    }

    void rightCircle()
    {
        if (!alreadyPlayed)
        {
            pling.Play();
            alreadyPlayed = true;
        }
    }

    void unplay()
    {
        alreadyPlayed = false;
    }

    void wrongCircle()
    {
        badum.Play();
    }

    //sets all counters to Zero
    void setToZero()
    {
        text2.text = "";
        count = 0;
        countH = 0;
        countNa = 0;
        countPt = 0;
    }
    //Destroys all exsting circles 
    void DestroyAllMolecules()
    {
        DestroyAllO();
        DestroyAllH();
        DestroyAllNa();
        DestroyAllPt();
    }

    //wait for 2 seconds after lvl
    IEnumerator wait1()
    {
        yield return new WaitForSeconds(2);
        setName2();
        text2.text = "";
        obj.SetActive(true);

    }

    IEnumerator wait2()
    {
        yield return new WaitForSeconds(3);
        setName3();
        text2.text = "";
        obj.SetActive(true);
    }

    IEnumerator wait3()
    {
        yield return new WaitForSeconds(3);
        setName4();
        text2.text = "";
        obj.SetActive(true);
    }

    IEnumerator wait4()
    {
        yield return new WaitForSeconds(3);
        text.text = "";
        text2.text = "";
        text3.text = end;
    }


    // Update is called once per frame
    void Update()
    {
        //LVL1
        //sets all xcounters to zero if wrong/too many molecule is picked up
        if (text.text.Equals(lvl1))
        {

            if (count == 1)
            {
                text2.text = "O";
                rightCircle();
                
                
            }

            if (countH >0 || countNa >0 || countPt> 0)
            {
                setToZero();
                wrongCircle();
                
            }
            //checks for lvl completion
            if (count == 2)
            {
                text2.text = "O2";
                rightCircle();
                
                DestroyAllMolecules();
                obj.SetActive(false);
                StartCoroutine(wait1()); 
            }

        }
        //LVL2
        if (text.text.Equals(lvl2))
        {
            if(countH == 1 && count == 0)
            {
                rightCircle();
                text2.text = "H";
            }

            if(countH ==2 && count == 0)
            {            
                text2.text = "H2";
                rightCircle();
            }
            
            if(count == 1 && (countH == 0 || countH == 1))
            {
                setToZero();
                wrongCircle();
                
                
            }

            if (countH > 2 || countNa > 0 || countPt > 0 || count > 1)
            {
                setToZero();
                wrongCircle();
                
                
            }

            if (countH == 2 && count == 1 && countNa == 0 && countPt == 0)
            {
              
                rightCircle();
                text2.text = "H2O";
                DestroyAllMolecules();
                obj.SetActive(false);
                StartCoroutine(wait2());
                
            }

        }

        //LVL3
        if (text.text.Equals(lvl3))
        {
            if (countH > 0 || countNa > 0 || countPt > 1 || count > 0)
            {
                setToZero();
                wrongCircle();
                
            }

            if (countPt == 1)
            {
             
                rightCircle();
                DestroyAllMolecules();
                text2.text = "Pt";
                obj.SetActive(false);
                StartCoroutine(wait3());
                
                
            }
        }

        //LVL4
        if (text.text.Equals(lvl4))
        {
            if (countH > 1 || countNa > 1 || countPt > 0 || count > 1)
            {
                setToZero();
                wrongCircle();
                
            }

            if(countNa == 1 && count == 0 && countH == 0)
            {
                
                rightCircle();
                text2.text = "Na";
            }

            if (countNa == 1 && count == 1 && countH == 0)
            {
                
                rightCircle();
                text2.text = "NaO";
            }

            if ((countNa == 1 && count == 0 && countH == 1) || (countNa == 0 && (count ==1 || countH ==1)) ){
                setToZero();
                wrongCircle();
               
            }


            if (countNa == 1 && count == 1 && countH == 1)
            {
               
                rightCircle();
                DestroyAllMolecules();
                text2.text = "NaOH";
                //makes sure no more molecules are comin by destroying game object with enemy manager script
                Destroy(obj);
                StartCoroutine(wait4());
                
                
                
            }
        }
        Debug.Log("counter " + count);
        Debug.Log("counterH " + countH);
        // Debug.Log("part 1 " + text.text.Equals(lvl1));
        // Debug.Log("part2 " + text.text.Equals(lvl));
    }



    //Checking for TAGS, counting molecules
    void OnTriggerEnter2D(Collider2D other)
    {
        unplay();

        if (other.gameObject.CompareTag("O"))
        {   //a try to signal you did smth right
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