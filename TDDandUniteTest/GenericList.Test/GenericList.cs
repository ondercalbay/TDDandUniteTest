
using System;
namespace GenericList.Test
{
    class GenericList<T>
    {
        private T[] m_InnerItems = new T[0];

        private int m_Count = 0;
        public int Count
        {
            get { return m_Count; }
        }

        public void AddItem(T item)
        {
            T[] newItemsArray = new T[m_Count + 1];
            Array.Copy(m_InnerItems, newItemsArray, m_InnerItems.Length);
            newItemsArray[m_Count] = item;
            this.m_InnerItems = newItemsArray;
            m_Count++;
        }

        internal void RemoveItem(int index)
        {
            T[] newItemsArray = new T[m_Count - 1];

            for (int i = 0; i < m_InnerItems.Length; i++)
            {
                if (index >= m_InnerItems.Length)
                {
                    newItemsArray[i] = m_InnerItems[i];
                }
                else
                {
                    newItemsArray[i - 1] = m_InnerItems[i];
                }

            }
            this.m_InnerItems = newItemsArray;
            m_Count--;
        }
    }
}
