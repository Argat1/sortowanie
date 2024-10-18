using Microsoft.VisualStudio.TestPlatform.TestHost;
using sortowanie;

namespace TestyJednostkoweBubble
{
    public class UnitTest1
    {
        [Fact]
        public void TestySprawdzajaceSortowanie()
        {
            //Arenge - przygotuj dane wyjsciowe
            int[] tablica = { 1, 4, 2, 5, 3 };
            int[] tablicadosortowania = { 1, 2, 3, 4, 5 };
            //Act - wykonaj metode ktore chcesz przestawic
            int[] wynikoczekiwany = SORT.Sortoj(tablica);
            //Assert - sprawdz czy wynik metody jest zgodny z oczekiwana wartoscia
            Assert.Equal(tablicadosortowania, wynikoczekiwany);
        }
    }
}