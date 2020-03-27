using System;
using System.Collections.Generic;

using ITEA_Collections.Common;

namespace ITEA_Collections.Usings
{
    public class DictionaryUsing : IBaseCollectionUsing
    {
        public Dictionary<int, string> Dictionary { get; set; }
        int count = 0;
        public DictionaryUsing()
        {
            Dictionary = new Dictionary<int, string>();
        }

        public void Add(object ts)
        {
            Dictionary.Add(count++, ts.ToString());
        }

        public void AddMany(object[] ts)
        {
            for (int i = 0; i < ts.Length; i++)
            {
                var item = ts[i];
                Dictionary.Add(count++, item.ToString());
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public object[] GetAll()
        {
            object[] arrayCollections = new object[Dictionary.Count];
            foreach (var item in Dictionary)
            {
                for (int i = 0; i < Dictionary.Count; i++)
                {
                    arrayCollections[i] = item;
                }
            }
            return arrayCollections;
        }

        public object GetByID(int index)
        {
            try
            {
                return Dictionary[index];
            }
            catch (Exception exception)
            {
                Extensions.ToConsole(exception.GetType().Name + exception.Message);
                Extensions.ToConsole($"Данного индекса - {index}, нет!");
                return null;
            }
        }

        public void RemoveByID(int index)
        {
            try
            {
                Dictionary.Remove(index);
                Extensions.ToConsole($"Элемент {index} успешно удален");
            }
            catch (ArgumentOutOfRangeException)
            {
                Extensions.ToConsole("Данного элемента нет!");
            }
        }

        public void ShowAll()
        {
            foreach (var item in GetAll())
            {
                Extensions.ToConsole($"{Dictionary[count++]}: {item}");
            }
        }
    }
}
