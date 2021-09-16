using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text puntos;
    public Text moneda1;
    public Text moneda2;
    public Text moneda3;

    private int punto_ = 0;
    private int moneda1_ = 0;
    private int moneda2_ = 0;
    private int moneda3_ = 0;

   
    private void Start()
    {
        //puntos.text = "Puntos: " + punto_;
        //moneda1.text = "Moneda 1: " + moneda1_;
        //moneda2.text = "Moneda 2: " + moneda2_;
        //moneda3.text = "moneda 3: " + moneda3_;
    }

    public int getPunto()
    {
        return punto_;
    }

    public void puntosSuma(int punto)
    {
        punto_ += punto;
        puntos.text = "Puntos: " + punto_;
    }

    public int getMoneda1()
    {
        return moneda1_;
    }
    public void puntosMoneda1(int moneda)
    {
        moneda1_ += moneda;
        moneda1.text = "Moneda 1: " + moneda1_;
    }
    public int getMoneda2()
    {
        return moneda2_;
    }
    public void puntosMoneda2(int moneda)
    {
        moneda2_ += moneda;
        moneda2.text = "Moneda 2: " + moneda2_;
    }
    public int getMoneda3()
    {
        return moneda3_;
    }
    public void puntosMoneda3(int moneda)
    {
        moneda3_+= moneda;
        moneda3.text = "moneda 3: " + moneda3_;
    }
}
