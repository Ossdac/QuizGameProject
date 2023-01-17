using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/QuizCreator")]
public class QuizCreater : ScriptableObject
{
    [SerializeField] private List<Theme> themes;
}
