using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour
{

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public GameObject pausecanvas;
    public GameObject inventorycanvas;

    public void Pause()
    {
        pausecanvas.SetActive(true);
    }

    public void ExitPause()
    {
        pausecanvas.SetActive(false);
        inventorycanvas.SetActive(false);
    }
    public void OpenInventory()
    {
        inventorycanvas.SetActive(true);
        pausecanvas.SetActive(false); // To save rendering? Or just layer the canvas?

    }
    public void ExitInventory()
    {
        pausecanvas.SetActive(true); // To save rendering? Or just layer the canvas?
        inventorycanvas.SetActive(false);
    }
}
