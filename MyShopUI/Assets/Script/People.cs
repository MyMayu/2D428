using UnityEngine;
using System.Collections;


public enum Type
{
    Nothing,
    Earth, //地球
    Alien,  //外星
}
public class People
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }

    public Type Tyoes = Type.Nothing;

    public People()
    {
        this.ID = -1;
    }

    public People(int id, string name, int number, Type type)
    {
        this.ID = ID;
        this.Name = name;
        this.Number = number;
        this.Tyoes = type;
    }
}
