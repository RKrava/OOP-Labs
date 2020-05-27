using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public struct LinkedList : IEnumerable  // односвязный список
    {
        Node head; // головной/первый элемент
        Node tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента в конец
        public void Add(double data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление парных элемента
        public void RemoveOdd()
        {
            Node current = head;
            Node previous = null;
            int counter = 1;
            foreach(double item in this)
            {
                if(counter % 2 == 0)
                {
                    this.Remove(item);
                }
                counter++;
            }
        }
        public bool Remove(double data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        // количество елементов больших чем средний
        public int NumberOfElementsBiggerThanAvg()
        {
            double avg = 0;
            foreach(double item in this)
            {
                avg = avg + item;
            }
            avg /= Count;

            int counter = 0;

            foreach(double item in this)
            {
                if(item > avg)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }


        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    public class Node
    {
        public Node(double data)
        {
            Data = data;
        }
        public double Data { get; set; }
        public Node Next { get; set; }
    }
}
