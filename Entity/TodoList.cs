using System;
using System.Collections.Generic;
using System.Text;

namespace JustDoIt.Entity
{
    public class TodoList
    {
        public string todo { get; set; }

        public TodoList() { }

        public TodoList (string paramTodo)
        {
            todo = paramTodo;
        }
    }
}
