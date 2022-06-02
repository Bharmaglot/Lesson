using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

    public class Animals
    {

    }

    public class Cat : Animals

    {

    }

    public interface ITestCovariance<out T>
    {
        T Test(int t);
    }


    public class TestCovariance<T> : ITestCovariance<T>
    {
        public T Test(int t)
        {
            return default;
        }
    }

    public interface ITestContravariance<in T>
    {
        void Test(T t);
    }

    public class TestContravariance<T> : ITestContravariance<T> 
    {
        public void Test(T t)
        {

        }
    }

    public sealed class ExampleCovariance
    {
        public void Main()
        {
            Animals animals = new Cat();


            ITestCovariance<Animals> testInvariance = new TestCovariance<Animals>();

            ITestCovariance<Animals> testCovariance = new TestCovariance<Cat>();

            ITestContravariance<Cat> testContravariance = new TestContravariance<Animals>(); 
        }
    }
}