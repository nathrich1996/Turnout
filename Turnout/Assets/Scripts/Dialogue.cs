using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {
    public string name = "";

    [TextArea(3, 10)]
    public string[] sentences;
    [TextArea(3, 10)]
    public string[] answers;
    [TextArea(3, 10)]
    public string correctAnswer;
    [TextArea(3, 10)]
    public string correctResponse;
    [TextArea(3, 10)]
    public string incorrectResponse;


}
