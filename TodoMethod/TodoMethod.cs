using System;
using System.Collections.Generic;
using System.Text;
using JustDoIt.Entity;


namespace JustDoIt.Method
{
    public interface ITodoMethod
    {
        TodoList[] GetAll();
        void Add(TodoList todoList);
        bool Remove(int no);
    }

    class TodoMethod : ITodoMethod
    {
        private TodoList[] _data = new TodoList[10];

        private bool isFull()
        {
            var isFull = true;
            foreach (var item in _data)
            {
                if (item != null) continue;
                isFull = false;
                break;
            }
            return isFull;
        }

        private void ResizeIfFull()
        {
            // saat penuh array diresize jadi 2x kapasitasnya
            if (!isFull()) return;
            var temp = _data;
            _data = new TodoList[_data.Length * 2];

            for (var i = 0; i < temp.Length; i++)
            {
                _data[i] = temp[i];
            }
        }

        public TodoList[] GetAll()
        {
            return _data;
        }

        public void Add(TodoList todoList)
        {
            ResizeIfFull();

            //data ditambahkan ke index array yang pertama null
            for (var i = 0; i < _data.Length; i++)
            {
                if (_data[i] != null) continue;
                _data[i] = todoList;
                break;     
            }
           
        }

        public bool Remove(int no)
        {
            if ((no - 1) >= _data.Length)
            {
                return false;
            }

            if (_data[no - 1] == null)
            {
                return false;
            }

            for (var i = no - 1; i < _data.Length; i++)
            {
                if (i == (_data.Length - 1))
                {
                    _data[i] = null;
                }
                else
                {
                    _data[i] = _data[i + 1];
                }
            }

            return true;
        }
    }
}
