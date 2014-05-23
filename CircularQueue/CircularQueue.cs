using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    class CircularQueue<E>
    {
        private E[] queue;
        private int head; 
        private int tail; 
        private int length; 

        public CircularQueue(int size)
        {
            queue = new E[size];
            head = tail = -1;
            length = size;
        }

        public void Add(E obj)
        {
            if ((head == 0 && tail == length - 1) || (tail + 1 == head))
            { 
                throw new Exception("Circular queue is full.");                  
            }
            else 
            { 
                if (tail == length - 1) 
                    tail = 0; 
                else 
                    tail++; 

                queue[tail] = obj;                  
            } 
            
            if (head == -1) 
                head = 0;

            //Console.Write("Added : " + Convert.ToString(obj));
            //Console.WriteLine("\tHead : " + head + "\tTail : " + tail);
        }

        public E Get()
        {
            E value = default(E); 

            if(head == -1) 
            { 
                throw new Exception("Circular queue is empty.");                
            } 
            else 
            { 
                value = queue[head];
                queue[head] = default(E); 

                if(head == tail) 
                    head = tail = -1; 
                else if(head == length - 1) 
                    head = 0; 
                else 
                    head++; 
            }

            //Console.Write("Retrive : " + value.ToString());
            //Console.WriteLine("\tHead : " + head + "\tTail : " + tail);

            return value;
        }      
      
        public Boolean HasSpace() 
        {
            if ((head == 0 && tail == length - 1) || (tail + 1 == head))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
