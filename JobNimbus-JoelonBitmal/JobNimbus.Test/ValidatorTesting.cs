using JobNimbus.Library;

namespace JobNimbus.Test
{
    public class ValidatorTesting
    {
        [Fact]
        public void TestOpenAndClose_Return_True()
        {
            var a = new Validator();
            //{} will return true
            Assert.True(a.ValidateString("{}"));
        }

        [Fact]
        public void TestCloseAndOpen_Return_False()
        {
            var a = new Validator();
            Assert.False(a.ValidateString("}{"));
        }

        [Fact]
        public void TestDoubleOpenAndClose_Return_False()
        {
            var a = new Validator();
            Assert.False(a.ValidateString("{{}"));
        }

        [Fact]
        public void TestEmptyString_Return_True()
        {
            var a = new Validator();
            Assert.True(a.ValidateString(""));
        }

        [Fact]
        public void TestOpenCloseWithCharactersInBetween_ReturnTrue()
        {
            var a = new Validator();
            Assert.True(a.ValidateString("{abc...xyz}"));
        }
    }
}