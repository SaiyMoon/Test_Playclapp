using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Cub;
    public GameObject PanelUI;
    public InputField Speed;
    public InputField TimeRespaun;
    public InputField Distans;

    private float time;
    private bool start = false;
    public void BtStart()
    {
        PanelUI.SetActive(false);
        time = ChekInput(TimeRespaun);
        start = true;
        InvokeRepeating("Inst", 0, time);  
    }
    
    public float ChekInput(InputField input)
    {
        if (!float.TryParse(input.text, out var number))
        {
            Debug.Log("Warning");
        }
        return number;
    }

    private void Inst()
    {
        Instantiate(Cub, transform.position, Quaternion.identity);       
    }
}
