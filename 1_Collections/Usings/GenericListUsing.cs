using System;
using System.Collections.Generic;

using ITEA_Collections.Common;

namespace ITEA_Collections.Usings
{
    internal class GenericListUsing : IBaseCollectionUsing
    {
        public List<string> List { get; set; }
        int count = 0;
        public GenericListUsing()
        {
            List = new List<string>();
        }

        public void Add(object ts)
        {
            List.Add(ts.ToString());
        }

        public void AddMany(object[] ts)
        {
            string[] str = new string[ts.Length];
            for (int i = 0; i < ts.Length; i++)
            {
                str[i] = ts[i].ToString();
            }
            List.AddRange(str);
        }

        public void Clear()
        {
            List.Clear();
        }

        public object[] GetAll()
        {
            return List.GetRange(0, List.Count).ToArray();
        }

        public object GetByID(int index)
        {
            try
            {
                return List[index];
            }
            catch (Exception exception)
            {
                Extensions.ToConsole(exception.GetType().Name + exception.Message);
                Extensions.ToConsole($"Данного элемента нет! { index}");
                return null;
            }
        }

        public void RemoveByID(int index)
        {
            try
            {
                List.RemoveAt(index);
                Extensions.ToConsole($"Индекс удален - №{index}", ConsoleColor.DarkYellow);
            }
            catch (ArgumentOutOfRangeException)
            {
                Extensions.ToConsole($"Данного элемента нет! {index}");
            }
        }

        public void ShowAll()
        {
            foreach (var item in GetAll())
                Extensions.ToConsole($"{List.IndexOf(item.ToString())}: {item}", ConsoleColor.Cyan);
        }
    }
}
