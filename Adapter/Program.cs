using Adapter.Adapter;
using Adapter.Interface;
using Adapter.Models;
using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // execute client
            ExecuteClient();

            Console.ReadKey();
        }

        private static void ExecuteClient()
        {
            // bag of fruit
            var bagOfPeelableFruit = new List<IPeelable>();

            // add an orange
            bagOfPeelableFruit.Add(new Orange());

            // add an banana
            bagOfPeelableFruit.Add(new Banana());

            // add an apple
            bagOfPeelableFruit.Add(new SkinToPeelAdapter(new Apple()));

            // add an pear
            bagOfPeelableFruit.Add(new SkinToPeelAdapter(new Pear()));

            foreach (var item in bagOfPeelableFruit)
            {
                item.Peel();
            }
        }
    }
}
