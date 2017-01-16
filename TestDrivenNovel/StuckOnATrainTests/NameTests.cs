using NovelDomain;
using NUnit.Framework;

namespace TestDrivenNovel.StuckOnATrainTests
{
    [TestFixture]  
    class NameTests 
    {
        [Test]
        public void Novel_is_called_StuckOnATrain()
        {
            // Arrange & Act
            var novel = new StuckOnATrain();

            // Assert
            Assert.AreEqual("Stuck on a Train", novel.Name);
        } 

        [Test]
        public void Protagonist_is_called_Aloysius()
        {
            // Arrange
            var novel = new StuckOnATrain();

            // Act
            var protagonist = novel.GetProtagonist();

            // Assert
            Assert.AreEqual("Aloysius", protagonist.Name);
        }
    }
}
