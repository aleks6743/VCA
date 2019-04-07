using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class TaskContoller : MonoBehaviour
{
    public Question question;

    public Text task;
    public List<Text> variants;

    [SerializeField]
    List<Question> qlist;

    // Start is called before the first frame update
    void Start()
    {
        task.text = question.text;
        qlist = Resources.LoadAll<Question>("Data").ToList();
       
        for (int i = 0; i < variants.Count; i++)
        {
            variants[i].text = question.answers[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
