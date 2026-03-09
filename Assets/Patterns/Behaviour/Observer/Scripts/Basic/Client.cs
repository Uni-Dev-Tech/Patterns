using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.Basic
{
    public class Client : MonoBehaviour
    {
        public void Start()
        {
            var subject = new Subject();
            subject.Attach(new ConcreteObserver());
            subject.State = 5;
        }
    }
}