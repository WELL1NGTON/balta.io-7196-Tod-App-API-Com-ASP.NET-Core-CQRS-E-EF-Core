using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuárioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuárioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "andrebaltieri", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuárioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "andrebaltieri", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_andrebaltieri()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("andrebaltieri"));

            foreach (var item in result)
                Assert.AreEqual("andrebaltieri", item.User);
        }

        // TODO: Test get only done or undone tasks
    }
}