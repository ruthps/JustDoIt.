using System;
using System.Collections.Generic;
using System.Text;
using JustDoIt.Service;
using JustDoIt.Input;

namespace JustDoIt.View
{
    class TodoView
    {
        private readonly ITodoService _todoService;

        public TodoView(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public void ViewShowTodoList()
        {            
            while (true)
            {
                Console.Clear();
                _todoService.ShowTodoList();


                Console.WriteLine("MENU: ");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Remove Todo");
                Console.WriteLine("x. Exit");


                //Console.WriteLine("MENU : ");
                //Console.WriteLine("1. Add Todo");
                //Console.WriteLine("2. Remove Todo");
                //Console.WriteLine("x. Exit");

               

                
                var input = InputClass.Input("Choose : ");

                if (input.Equals("1"))
                {
                    ViewAddTodoList();
                    Console.ReadKey();
                }
                else if (input.Equals("2"))
                {
                    ViewRemoveTodoList();
                    Console.ReadKey();
                }
                else if(input.Equals("x"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                }
            }
        }

        public void ViewRemoveTodoList()
        {
            Console.WriteLine("MENGHAPUS TODOLIST");

            var no = InputClass.Input("Nomor yang Dihapus (x Jika Batal)");
            if (no.Equals("x")) { }
            else
            {
                _todoService.RemoveTodoList(int.Parse(no));
            }
        }

        public void ViewAddTodoList()
        {
            Console.WriteLine("MENAMBAH TODOLIST");

            var todo = InputClass.Input("Todo (x Jika Batal)");

            if (todo.Equals("x")) { }
            else
            {
                _todoService.AddTodoList(todo);
            }
        }

        

    }
}
