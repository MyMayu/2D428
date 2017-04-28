using UnityEngine;
using System.Collections;

public class TranslationResult
{
    public string Error_code { get; set; }
    public string Error_msg { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Query { get; set; }
    public Translation[] Trans_result { get; set; }
}