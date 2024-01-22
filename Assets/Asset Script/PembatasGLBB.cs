using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PembatasGLBB : MonoBehaviour
{
    public TMPro.TMP_Text percepatan, waktutempuh;

    public GameObject[] pembagiT;
    float penguranganT;
    
    float posisiT;
    int a;
    int bebanbalok;

    //deklarasi percepatan
    double perc, perc2, te, te2, te3;
    double perc1, perc3, perc4, s;
    double[] vnol, vte, jar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (a == 1)
        {
            
            
            te = 10 - penguranganT;
            te2 = (te*te)/2;
            perc = 7000 / (te2);
            perc2 = perc / 10000;
            posisiT = (180 - 4000);

            te3 = te/2;
            waktutempuh.text = te3.ToString();
            s = 0.7;
            perc1 = s / ((te3) / 2);
            perc3 = System.Math.Round(perc1, 2);
            percepatan.text = perc3.ToString();

            vte = new double[12];
            jar = new double[12];
            jar[0] = 180;
            vte[0] = 0;

            a = 2;
        }
        else if (a == 2)
        {
            for (int m = 1; m <= te; m++)
            {
                jar[m] = vte[m - 1] + ((1 / 2) * perc * m * m);
                vte[m] = ((vte[m - 1])) + (perc * m);
                pembagiT[m].transform.localPosition = new Vector2(20.36f, (posisiT));
                posisiT = posisiT + (float)jar[m];
                if (m == te)
                {
                    a = 0;
                }
                else
                {
                    a = 2;
                }
            }
        }
        else
        {
            if (bebanbalok == 1)
            {
                penguranganT = 0;
            }
            else if (bebanbalok == 2)
            {
                penguranganT = 1;
            }
            else if (bebanbalok == 3)
            {
                penguranganT = 2;
            }
            else if (bebanbalok == 4)
            {
                penguranganT = 3;
            }
        }

    }
    private void OnGUI()
    {

    }

    public void run(int nilai)
    {
        a = nilai;
    }
    public void refresh()
    {
        waktutempuh.text = "?".ToString();
        percepatan.text = "?".ToString();

        bebanbalok = 0;
        penguranganT = 0;
        a = 0;
    }
    public void beban(int nilainya)
    {
        bebanbalok = nilainya;
    }
}
