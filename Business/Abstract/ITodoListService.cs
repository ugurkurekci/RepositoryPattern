using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITodoListService
    {
        IDataResult<List<TodoList>> GetAll();
        IResult Add(TodoList todoList);
        IResult Update(TodoList todoList);
        IResult Delete(TodoList todoList);
        IDataResult<TodoList> GetTodoListById(int todoListId);
        IDataResult<List<TodoList>> GetTodoListByName(string todoListName);
        IDataResult<TodoList> GetTodoListByDescription(string todoListDescription);
        IDataResult<List<TodoList>> GetTodoListByToDoIsItDone(Boolean ToDoIsItDone);
    }
}
