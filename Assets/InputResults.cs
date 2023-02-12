using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputResultsRawScores : MonoBehaviour
{
    public InputField StudentScore;
    public InputField StudentScore1;
    public InputField StudentScore2;
    public InputField StudentScore3;
    public InputField StudentScore4;
    public InputField StudentScore5;
    public InputField StudentScore6;
    public InputField StudentScore7;
    public InputField StudentScore8;
    public InputField StudentScore9;
    public InputField StudentScore10;
    public InputField StudentScore11;
    public InputField StudentScore12;
    public InputField StudentScore13;
    public InputField StudentScore14;
    public InputField StudentScore15;
    public InputField StudentScore16;
    public InputField StudentScore17;
    public InputField StudentScore18;
    public InputField StudentScore19;
    public InputField StudentScore20;
    public InputField StudentScore21;
    public InputField StudentScore22;
    public InputField StudentScore23;
    public InputField StudentScore24;
    public InputField StudentScore25;
    public InputField StudentScore26;
    public InputField StudentScore27;
    public InputField StudentScore28;
    public InputField StudentScore29;
    public InputField StudentScore30;
    public InputField RawStudentScoreTotal;
    //public InputField FinalGrade;
    //public InputField OverallScoreTotal;
    float s;
    float s1;
    float s2;
    float s3;
    float s4;
    float s5;
    float s6;
    float s7;
    float s8;
    float s9;
    float s10;
    float s11;
    float s12;
    float s13;
    float s14;
    float s15;
    float s16;
    float s17;
    float s18;
    float s19;
    float s20;
    float s21;
    float s22;
    float s23;
    float s24;
    float s25;
    float s26;
    float s27;
    float s28;
    float s29;
    float s30;
    float RSS;

    public float RSS1 { get => RSS; set => RSS = value; }

    //int RSS;
    //   int OTS;
    //  int GP;


    //Fishing Inputs
    void Start()
    {
        StudentScore.text = PlayerPrefs.GetString("SScore");
        StudentScore1.text = PlayerPrefs.GetString("SScore1");
        StudentScore2.text = PlayerPrefs.GetString("SScore2");
        StudentScore3.text = PlayerPrefs.GetString("SScore3");
        StudentScore4.text = PlayerPrefs.GetString("SScore4");
        StudentScore5.text = PlayerPrefs.GetString("SScore5");
        StudentScore6.text = PlayerPrefs.GetString("SScore6");
        StudentScore7.text = PlayerPrefs.GetString("SScore7");
        StudentScore8.text = PlayerPrefs.GetString("SScore8");
        StudentScore9.text = PlayerPrefs.GetString("SScore9");
        StudentScore10.text = PlayerPrefs.GetString("SScore10");
        StudentScore11.text = PlayerPrefs.GetString("SScore11");
        StudentScore12.text = PlayerPrefs.GetString("SScore12");
        StudentScore13.text = PlayerPrefs.GetString("SScore13");
        StudentScore14.text = PlayerPrefs.GetString("SScore14");
        StudentScore15.text = PlayerPrefs.GetString("SScore15");
        StudentScore16.text = PlayerPrefs.GetString("SScore16");
        StudentScore17.text = PlayerPrefs.GetString("SScore17");
        StudentScore18.text = PlayerPrefs.GetString("SScore18");
        StudentScore19.text = PlayerPrefs.GetString("SScore19");
        StudentScore20.text = PlayerPrefs.GetString("SScore20");
        StudentScore21.text = PlayerPrefs.GetString("SScore21");
        StudentScore22.text = PlayerPrefs.GetString("SScore22");
        StudentScore23.text = PlayerPrefs.GetString("SScore23");
        StudentScore24.text = PlayerPrefs.GetString("SScore24");
        StudentScore25.text = PlayerPrefs.GetString("SScore25");
        StudentScore26.text = PlayerPrefs.GetString("SScore26");
        StudentScore27.text = PlayerPrefs.GetString("SScore27");
        StudentScore28.text = PlayerPrefs.GetString("SScore28");
        StudentScore29.text = PlayerPrefs.GetString("SScore29");
        StudentScore30.text = PlayerPrefs.GetString("SScore30");


        s = float.Parse(StudentScore.text);
        s1 = float.Parse(StudentScore1.text);
        s2 = float.Parse(StudentScore2.text);
        s3 = float.Parse(StudentScore3.text);
        s4 = float.Parse(StudentScore4.text);
        s5 = float.Parse(StudentScore5.text);
        s6 = float.Parse(StudentScore6.text);
        s7 = float.Parse(StudentScore7.text);
        s8 = float.Parse(StudentScore8.text);
        s9 = float.Parse(StudentScore9.text);
        s10 = float.Parse(StudentScore10.text);
        s11 = float.Parse(StudentScore11.text);
        s12 = float.Parse(StudentScore12.text);
        s13 = float.Parse(StudentScore13.text);
        s14 = float.Parse(StudentScore14.text);
        s15 = float.Parse(StudentScore15.text);
        s16 = float.Parse(StudentScore16.text);
        s17 = float.Parse(StudentScore17.text);
        s18 = float.Parse(StudentScore18.text);
        s19 = float.Parse(StudentScore19.text);
        s20 = float.Parse(StudentScore20.text);
        s21 = float.Parse(StudentScore21.text);
        s22 = float.Parse(StudentScore22.text);
        s23 = float.Parse(StudentScore23.text);
        s24 = float.Parse(StudentScore24.text);
        s25 = float.Parse(StudentScore25.text);
        s26 = float.Parse(StudentScore26.text);
        s27 = float.Parse(StudentScore27.text);
        s28 = float.Parse(StudentScore28.text);
        s29 = float.Parse(StudentScore29.text);
        s30 = float.Parse(StudentScore30.text);
        RSS1 = float.Parse(RawStudentScoreTotal.text);

    }


    // Overall Calculations
    public void CalculateRawScore()
    {
        //RawStudentScoreTotal.text = PlayerPrefs.GetInt(s + s + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + s20 + s21 + s22 + s23 + s24 + s25 + s26 + s27 + s28 + s29 + s30);
        RSS1 = s + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10 + s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + s20 + s21 + s22 + s23 + s24 + s25 + s26 + s27 + s28 + s29 + s30;
        //RawStudentScoreTotal.text = StudentScore.text + StudentScore1.text + StudentScore2.text;


        
        //PlayerPrefs.SetString("SScore", RawStudentScoreTotal.text);
        PlayerPrefs.Save();
    }

    // public void CalculateOverallTestScores()


    // public void CalculateGradePercent()

}