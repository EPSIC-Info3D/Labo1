namespace Epsic.Info3Dev.Labo1.Tests
{
    using Epsic.Info3Dev.Labo1.Step1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Step1Tests
    {
        [TestMethod, TestCategory("Step1")]
        public void StudentSetAgeTest() 
        {
            var sut = new Student();

            sut.SetAge(21);

            Assert.AreEqual("I'm 21 years old", sut.ShowAge());
        }

        [TestMethod, TestCategory("Step1")]
        public void StudentGreetTest() 
        {
            var sut = new Student();

            Assert.AreEqual("Hello!", sut.Greet());
        }

        [TestMethod, TestCategory("Step1")]
        public void StudentStudyTest() 
        {
            var sut = new Student();

            Assert.AreEqual("I'm studying", sut.Study());
        }

        [TestMethod, TestCategory("Step1")]
        public void TeacherGreetTest() 
        {
            var sut = new Teacher();

            Assert.AreEqual("Hello!", sut.Greet());
        }

        [TestMethod, TestCategory("Step1")]
        public void TeacherStudyTest() 
        {
            var sut = new Teacher();

            Assert.AreEqual("I'm explaining", sut.Explain());
        }
    }
}

