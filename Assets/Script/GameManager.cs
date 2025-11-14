using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public TMP_Text textTacadas;
    public TMP_Text textPar;
    public int tacadas;
    public int par;
    private int recorde;

    void Start()
    {
        if (gm == null)
        {
            gm = this.gameObject.GetComponent<GameManager>();

            tacadas = 0;
            textTacadas.text = "Tacadas: 0";
            textPar.text = "Par:" + par;

        }

    }

    // Update is called once per frame
    void tacada(){
    {
            Debug.Log("tacada++");
            tacadas++;
            textTacadas.text = "Tacadas" + tacadas;

        }
    }
}