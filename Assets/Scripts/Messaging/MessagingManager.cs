using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagingManager : MonoBehaviour
{
   public static MessagingManager Instance { get; private set; }

   public List<Action> subscribers = new List<Action>();

   

    private void Awake()
    {
        Debug.Log("Messaging Manager Started");

        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }


    public void Subscribe(Action subscriber)
    {
        Debug.Log("Subscriber registered");
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(Action subscriber)
    {
        Debug.Log("Subsriber Registered");
        subscribers.Remove(subscriber);
    }

    public void ClearAllSubscribers()
    {
        subscribers.Clear();
    }

    public void Broadcast()
    {
        Debug.Log("Broadcast requested, No of Subscribers = " + subscribers.Count);
        foreach(var subscriber in subscribers)
        {
            subscriber();
        }
    }
}
