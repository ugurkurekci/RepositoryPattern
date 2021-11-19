using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListService _todoListService;

        public TodoListController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpPost("todoListAdd")]
        public IActionResult TodoListAdd(TodoList todoList)
        {
            var result = _todoListService.Add(todoList);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPut("todoListUpdate")]
        public IActionResult TodoListUpdate(TodoList todoList)
        {
            var result = _todoListService.Update(todoList);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpDelete("todoListDelete")]
        public IActionResult TodoListDelete(TodoList todoList)
        {
            var result = _todoListService.Delete(todoList);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("todoListGetAll")]
        public IActionResult TodoListGetAll()
        {
            var result = _todoListService.GetAll();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("todoListById")]
        public IActionResult TodoListById(int id)
        {
            var result = _todoListService.GetTodoListById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("todoListByDescription")]
        public IActionResult TodoListByDescription(string TodoListDescription)
        {
            var result = _todoListService.GetTodoListByDescription(TodoListDescription);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("todoListByName")]
        public IActionResult TodoListByName(string TodoListName)
        {
            var result = _todoListService.GetTodoListByName(TodoListName);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("todoListByToDoIsItDon")]
        public IActionResult TodoListByToDoIsItDon(Boolean ToDoIsItDone)
        {
            var result = _todoListService.GetTodoListByToDoIsItDone(ToDoIsItDone);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
    }
}
