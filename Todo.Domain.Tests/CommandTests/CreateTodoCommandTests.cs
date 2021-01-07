using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();

            Assert.AreEqual(false, command.Valid);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            var command = new CreateTodoCommand("Titulo da Tarefa", "Wellington", DateTime.Now);
            command.Validate();

            Assert.AreEqual(true, command.Valid);
        }
    }
}