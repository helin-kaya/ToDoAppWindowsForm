using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppDataLayer;
using ToDoAppEntityLayer.Entities;

namespace ToDoAppBusinessLayer
{
    public class ToDoManager
    {
        MyContext context;

        public ToDoManager()
        {
            context = context ?? new MyContext();
        }

       public bool AddNewToDo(ToDo td)
        {
            try
            {
                context.ToDoTable.Add(td);
                return context.SaveChanges() > 0 ? true : false;

                            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteToDo(ToDo td)
        {
            try
            {
                context.ToDoTable.Remove(td);
                return context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
