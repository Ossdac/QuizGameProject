using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Theme 
{
    [SerializeField] private string title;
    [SerializeField] private string themeDescription;
    [SerializeField] private Question[] questions;


    public string ThemeName { get { return title; } }
    public string ThemeDescription { get { return themeDescription; } }
    public Question[] Questions { get { return questions; } }

    public Theme() { }



}
