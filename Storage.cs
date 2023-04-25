using System;

namespace OOP_lab4._1
{
    public class Storage
    {
        private Circle[] arr;
        private int size;
        private int count;

        public Storage()
        {
            size = 0;
            arr = new Circle[size];
            count = 0;
        }

        public Storage(int size)
        {
            this.size = size;
            arr = new Circle[size];
            count = 0;
        }

        public Circle GetObject(int index)
        {
            return arr[index];
        }

        public int GetCount()
        {
            return count;
        }
        
        public void AddObj(Circle obj)
        {
            if (!CheckSpace())
            {
                Resize();
            }
            
            for(int i = 0; i < size; i++)
            {
                if(arr[i] == null) {
                    arr[i] = obj;
                    count++;
                    break; 
                }
            }
        }

        private bool CheckSpace() 
        {
            if (count < size)
            {
                return true;
            }
            return false;
        }
        
        public void Resize()
        {
            Circle[] arrTmp = new Circle[size * 2 + 1];
            for (int i = 0; i < size; i++)
            {
                arrTmp[i] = arr[i];
            }
            arr = arrTmp;
            size *= 2;
        }

        public void DeleteObject(int index)
        {
            if (size > 0)
            {
                if (index <= size)
                {
                    count--;
                    Circle[] tmp_arr = new Circle[size];
                    for (int i = 0, j = 0; i < count + 1; i++)
                    {
                        if (i != index)
                        {
                            tmp_arr[j] = arr[i];
                            j++;
                        }
                    }
                    arr = tmp_arr;
                }
            }
        }
    }
}