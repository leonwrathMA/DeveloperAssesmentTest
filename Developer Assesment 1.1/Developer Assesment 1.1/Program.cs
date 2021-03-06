﻿using System;
using System.Threading;

namespace Developer_Assesment_1._1
{
    class Program
    {
        //below is an example of a class variable
        private static int classVariable { get; set; }
        //below is an example of an instance variable
        private int instanceVariable { get; set; }

        //lock object for thread safe variables
        private readonly object lockObj = new object();

        public int getclassVariableMethod() {
            //here i lock the object, so if multiple threads try to access it they will wait until the lock is lifted.
            lock (lockObj)
            {
                return classVariable;
            }
        }

        public void setclassVariableMethod(int newValue)
        {
            //here i lock the object, so if multiple threads try to access it they will wait until the lock is lifted.
            lock (lockObj)
            {
                classVariable = newValue;
            }
        }

        public int getinstanceVariableMethod()
        {
            //here i lock the object, so if multiple threads try to access it they will wait until the lock is lifted.
            lock (lockObj)
            {
                return instanceVariable;
            }
        }

        public void setinstanceVariableMethod(int newValue)
        {
            //here i lock the object, so if multiple threads try to access it they will wait until the lock is lifted.
            lock (lockObj)
            {
                instanceVariable = newValue;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
