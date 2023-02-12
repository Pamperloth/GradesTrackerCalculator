using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class RAWSCORES : MonoBehaviour
{


        public InputField s;
        public InputField s1;
        public Text StudentTotalRawScore;

        public void STUDENTRAWSCORERESULT()
        {


        float Student = float.Parse(s.text); 
        float Student1 = float.Parse(s1.text); 

        StudentTotalRawScore.text = (Student + Student1).ToString();

        }

}


 