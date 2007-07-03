// Copyright 2004-2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.MonoRail.Views.Brail.Tests
{
    using Castle.MonoRail.Framework.Tests;
    using NUnit.Framework;

    [TestFixture]
    public class DslLayoutFixture : AbstractTestCase
    {
        [Test]
        public void LayoutAndChildOuputUsingDsl()
        {
            string expected = "<html><p>Hello, Harris</p></html>";
            DoGet("dsl/testSubViewOutput.rails");
            AssertReplyEqualTo(expected);
        }

        [Test]
        public void ComponentOuputUsingDsl()
        {
            string expected =
                "<html><body><table><tr><th>Names</th></tr><tr><td>Ayende</td></tr><tr><td>Rahien</td></tr></table></body></html>";
            DoGet("dsl/testSubViewWithComponents.rails");
            AssertReplyEqualTo(expected);
        }

        [Test]
        [Ignore("We have issue with parameters references")]
        public void XmlDsl()
        {
            string expected = "to be verified";
            DoGet("dsl/testXml.rails");
            AssertReplyEqualTo(expected);
        }
    }
}