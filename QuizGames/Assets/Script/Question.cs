using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question 
{ 
    [SerializeField] private string title;
    [SerializeField] private Answer[] answers;

    public string Text { get { return title; } }
    public Answer[] Answers { get { return answers; } }

    public Question(string question, Answer[] answers)
    {
        this.title = question;
        this.answers = answers;
    }
}
