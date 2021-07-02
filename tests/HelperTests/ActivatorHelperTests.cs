using FluentAssertions;
using MatrTech.Utilities.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ActivatorHelperTests
{
    [TestClass]
    public class ActivatorHelperTests
    {
        [TestMethod]
        public void CreateInstance_WithoutParameters_NotBeNull()
        {
            ActivatorHelper.CreateInstance<TestClassWithoutParameters>()
                .Should()
                .NotBeNull();
        }

        [TestMethod]
        public void CreateInstance_WithParameters_NotBeNull()
        {
            ActivatorHelper.CreateInstance<TestClassWithParameters>(3)
                .Should()
                .NotBeNull();
        }

        [TestMethod]
        public void CreateInstance_WithParametersButNotProvided_ShouldThrowException()
        {
            Func<TestClassWithParameters?> func = () => ActivatorHelper.CreateInstance<TestClassWithParameters>();
            func.Should().Throw<MissingMethodException>();
        }

        private class TestClassWithoutParameters { }

        private class TestClassWithParameters
        {
            public TestClassWithParameters(int _)
            {
            }
        }
    }
}