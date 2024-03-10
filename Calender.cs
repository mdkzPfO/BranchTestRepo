using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Calender
{
    //日付に関する最大値
    public int Goal = 10;
    //後で作る
    //日付毎に発生するイベント用にリストを作る。探索とかもあるので後で考える
    List<EventModel> EventList;
    public Calender()
    {
        EventList = new List<EventModel>();
        for (int i = 0; i < Goal; i++)
        {
            EventList.Add(new EventModel());
        }
    }
}
