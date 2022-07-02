using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            //TODO: сумирайте двойките от startIndex до nextIndex
            Pair pair = new Pair(0, 0);

            for (int i = startIndex; i < this.nextIndex; i++)
            {
                pair.First += items[i].First;
                pair.Last += items[i].Last;
            }

            return pair;
        }

        public Pair Sum()
        {
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
            Pair pair = new Pair(0, 0);

            for (int i = 0; i < this.startIndex; i++)
            {
                pair.First += items[i].First;
                pair.Last += items[i].Last;
            }
            return pair;
        }

        public void Add(Pair item)
        {
            //TODO: Добавяне на двойката
            if (this.nextIndex >= this.items.Length)
            {
                this.items[startIndex] = this.SumIntervalPairs();
                this.startIndex++;
                this.nextIndex = this.startIndex;
                this.Count = 1;
            }

            this.items[nextIndex] = item;
            this.Count++;
            this.nextIndex++;
        }

        public void PrintCurrentState()
        {
            //TODO: отпечатайте всички двойки от 0 до nextIndex
            for (int i = 0; i < this.nextIndex; i++)
            {
                Console.WriteLine(this.items[i].ToString());
            }
        }

    }
}
