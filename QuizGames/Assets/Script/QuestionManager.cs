using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private QuizCreater quizCreater;

    private List<Theme> themes;

    private Question[] questions;

    private void Start()
    {
        themes = new List<Theme>();
    }

    public void AddTheme(Theme theme) { themes.Add(theme); }
    public void RemoveTheme(Theme theme) { themes.Remove(theme); }

    public void PutTogetherQuestins()
    {
        int counter = 0;
        foreach (Theme theme in themes)
        {
            counter += theme.Questions.Length;
        }

        questions = new Question[counter];

        counter = 0;
        foreach (Theme theme in themes)
        {
            Array.Copy(theme.Questions, 0, questions, counter, theme.Questions.Length);
            counter += theme.Questions.Length;
        }
    }

    public void ShuffleQuestions()
    {
        Question temp;
        for (int i = 0; i < questions.Length - 1; i++)
        {
            int rnd = Random.Range(i, questions.Length);
            temp = questions[rnd];
            questions[rnd] = questions[i];
            questions[i] = temp;
        }
    }
}
