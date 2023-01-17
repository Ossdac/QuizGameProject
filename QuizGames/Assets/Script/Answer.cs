using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Answer 
{
    [SerializeField] private string title;
    [SerializeField] private bool correctAnswer;

    public string Text { get { return title; } }
    public bool CorrectAnswer { get { return correctAnswer; } }

    public Answer(string answer) { this.title = answer; correctAnswer = false; }

    public Answer(string answer, bool correctAnswer)
    {
        this.title = answer;
        this.correctAnswer = correctAnswer;
    }
}
