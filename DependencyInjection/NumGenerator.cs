﻿namespace DependencyInjection
{
    public class NumGenerator : INumGenerator
    {
        public int RandomValue { get; }

        public NumGenerator()
        {
            RandomValue = new Random().Next(1_000);
        }
    }
    public interface INumGenerator
    {
        public int RandomValue { get; }
    }
}
