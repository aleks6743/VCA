using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Question : ScriptableObject
{
    public string text;
    public List<string> answers;
}
