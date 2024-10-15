using Microsoft.VisualStudio.TestPlatform.TestHost;
using sortowanie;

namespace TestyJednostkoweBubble
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            int[] tab = { 1, 4, 2, 5, 3 };
            int[] tab2 = { 1, 2, 3, 4, 5 };

            int[] result = SORT.Sortoj(tab);

            Assert.Equal(tab2, result);
        }
    }
}