using System;
using JustDoIt.Method;
using JustDoIt.Service;
using JustDoIt.View;

namespace JustDoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoMethod method = new TodoMethod();
            ITodoService todoService = new TodoService(method);
            var todoView = new TodoView(todoService);

            todoView.ViewShowTodoList();









        }
    }
}
