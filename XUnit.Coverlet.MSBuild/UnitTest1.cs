using System;
using Xunit;
using HomeWorkCheckApp;
namespace XUnit.Coverlet.MSBuild
{
    public class UnitTest1
    {
        [Fact]
        public void executeFileTestHest1ReturnsOutPutFileAndCompilerMesseges()
        {
            string MockedPath1 = "C:\\Users\\userr\\Desktop\\cf3.c";
            (var resultFileOutPut, var resultCompilerOutPut) = FilesExecuterHest1.executeFile(MockedPath1);
            Assert.IsInstanceOfType(resultFileOutPut, typeof(string));
            Assert.IsInstanceOfType(resultCompilerOutPut, typeof(string));
        }
    }

    [TestClass]
    public class FilesExecuterHest1Test
    {
        [TestMethod]
        public void executeFileTestHest1ReturnsOutPutFileAndCompilerMesseges()
        {
            


        }
        [TestMethod]
        public void executeFileTestHest2ReturnsOutPutFileAndCompilerMesseges()
        {
            string MockedPath1 = "C:\\Users\\userr\\Desktop\\cf3.c";
            (var resultFileOutPut, var resultCompilerOutPut) = FilesExecuterHest2.executeFile(MockedPath1, "123");
            Assert.IsInstanceOfType(resultFileOutPut, typeof(string));
            Assert.IsInstanceOfType(resultCompilerOutPut, typeof(string));


        }
    }
}
