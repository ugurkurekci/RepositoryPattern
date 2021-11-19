﻿using Core.Repository.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ToDoListDal : EntityRepositoryBase<TodoList, CookieOvenDatabaseContext>, ITodoListDal
    {
    }
}
