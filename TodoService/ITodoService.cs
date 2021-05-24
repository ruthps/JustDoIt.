using System;
using System.Collections.Generic;
using System.Text;
using JustDoIt.Entity;
using JustDoIt.Method;

namespace JustDoIt.Service
{
    public interface ITodoService
    {
        void ShowTodoList();
        void AddTodoList(string todo);
        void RemoveTodoList(int no);
    }
    class TodoService : ITodoService
    {
        private readonly ITodoMethod _todoMethod;

        public TodoService(ITodoMethod todoMethod)
        {
            _todoMethod = todoMethod;
        }

        public void ShowTodoList()
        {
            var todoLists = _todoMethod.GetAll();

            Console.WriteLine("TODOLIST");
            for (var i = 0; i < todoLists.Length; i++)
            {
                var todo = todoLists[i];
                var no = i + 1;
                if (todo != null)
                {
                    Console.WriteLine(no + ". " + todo.todo);
                }
            }
        }
        public void AddTodoList(string todo)
        {
            var todoList = new TodoList(todo);
            _todoMethod.Add(todoList);
            Console.WriteLine("Berhasil menambah Todo : " + todoList.todo);
        }

        public void RemoveTodoList(int no)
        {
            var success = _todoMethod.Remove(no);
            if(success)
            {
                Console.WriteLine("Berhasil menghapus Todo: " + no);
            }
            else
            {
                Console.WriteLine("Gagal menghapus Todo: " + no);
            }
        }

    }
}
