using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Calender
{
    //���t�Ɋւ���ő�l
    public int Goal = 10;
    //��ō��
    //���t���ɔ�������C�x���g�p�Ƀ��X�g�����B�T���Ƃ�������̂Ō�ōl����
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
