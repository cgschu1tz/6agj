using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class HUD : MonoBehaviour
    {
        GameObject Water;
        GameObject Nit;
        GameObject Iron;
        public void UpdateHud(int water, int nit, int iron)
        {
            UnityEngine.UI.Text WaterText = Water.GetComponent<UnityEngine.UI.Text>();
            UnityEngine.UI.Text NitText = Nit.GetComponent<UnityEngine.UI.Text>();
            UnityEngine.UI.Text IronText = Iron.GetComponent<UnityEngine.UI.Text>();

            WaterText.text = (Int32.Parse(WaterText.text) + water).ToString();
            NitText.text = (Int32.Parse(NitText.text) + nit).ToString();
            IronText.text = (Int32.Parse(IronText.text) + iron).ToString();
        }
        // Start is called before the first frame update
        void Start()
        {
            Water = GameObject.Find("WaterValue");
            Nit = GameObject.Find("NitValue");
            Iron = GameObject.Find("IronValue");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}