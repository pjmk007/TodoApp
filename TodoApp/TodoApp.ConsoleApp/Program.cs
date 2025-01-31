﻿using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoRepository _repository = new TodoRepositoryInMemory();
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();

            //[1] 기본 데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
            }
            Console.WriteLine();

            //[2] 데이터 입력
            Todo todo = new Todo { Title = "Database", IsDone = true };
            _repository.Add(todo);
            todos = _repository.GetAll();//다시 로드

            //[3] 변경 데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.Id} - {t.Title}({t.IsDone})");
            }
        }
    }
}
