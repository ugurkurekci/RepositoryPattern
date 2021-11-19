using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TodoListService : ITodoListService
    {
        private readonly ITodoListDal _todoListDal;

        public TodoListService(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public IResult Add(TodoList todoList)
        {
            _todoListDal.Add(todoList);
            return new SuccessResult();
        }

        public IResult Delete(TodoList todoList)
        {
            _todoListDal.Delete(todoList);
            return new SuccessResult();
        }

        public IDataResult<List<TodoList>> GetAll()
        {
            return new SuccessDataResult<List<TodoList>>(_todoListDal.GetAll());
        }

        public IDataResult<TodoList> GetTodoListByDescription(string todoListDescription)
        {
            return new SuccessDataResult<TodoList>(_todoListDal.Get(p => p.ToDoDescription == todoListDescription));

        }

        public IDataResult<TodoList> GetTodoListById(int todoListId)
        {
            return new SuccessDataResult<TodoList>(_todoListDal.Get(p => p.Id == todoListId));
        }

        public IDataResult<List<TodoList>> GetTodoListByName(string todoListName)
        {
            return new SuccessDataResult<List<TodoList>>(_todoListDal.GetAll(o => o.ToDoName == todoListName));
        }

        public IDataResult<List<TodoList>> GetTodoListByToDoIsItDone(bool ToDoIsItDone)
        {
            return new SuccessDataResult<List<TodoList>>(_todoListDal.GetAll(o => o.ToDoIsItDone == ToDoIsItDone));
        }

        public IResult Update(TodoList todoList)
        {
            _todoListDal.Update(todoList);
            return new SuccessResult();
        }
    }
}
