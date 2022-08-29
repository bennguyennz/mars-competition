using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition.Tests
{
    internal class Tests : Global.Base
    {
        [Test]
        public void WhenILoginTheWebsite()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
    }
}
