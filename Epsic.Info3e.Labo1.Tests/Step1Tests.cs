namespace Epsic.Info3e.Labo1.Tests
{
    using Epsic.Info3e.Labo1.Step1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Step1Tests
    {
        [TestMethod, TestCategory("Step1")]
        public void StudentSetAgeTest() 
        {
            var sut = new Student();

            sut.SetAge(21);

            Assert.AreEqual(sut.ShowAge(), "My age is 21 years old");
        }

        [TestMethod, TestCategory("Step1")]
        public void StudentGreetTest() 
        {
            var sut = new Student();

            Assert.AreEqual(sut.Greet(), "Hello!");
        }

        [TestMethod, TestCategory("Step1")]
        public void StudentStudyTest() 
        {
            var sut = new Student();

            Assert.AreEqual(sut.Study(), "I'm studying");
        }

        [TestMethod, TestCategory("Step1")]
        public void TeacherGreetTest() 
        {
            var sut = new Teacher();

            Assert.AreEqual(sut.Greet(), "Hello!");
        }

        [TestMethod, TestCategory("Step1")]
        public void TeacherStudyTest() 
        {
            var sut = new Teacher();

            Assert.AreEqual(sut.Explain(), "I'm explaining");
        }
    }
}

