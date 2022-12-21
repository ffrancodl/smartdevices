//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using AdapterExample;
using NUnit.Framework;

namespace Tests
{
    public class AdapterTest
    {
        [Test]
        public void Test()
        {
            Plug plug = new Plug("1");
            ISmartDevice Adapter = new Adapter (plug);
            Adapter.On();
            Adapter.Off();
            Assert.AreEqual(Adapter.GetStatus(), "On");
        }
    }
}