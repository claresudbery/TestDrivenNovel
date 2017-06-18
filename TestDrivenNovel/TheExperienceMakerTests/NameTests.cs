using NovelDomain.ActualNovels;
using NovelDomain.ActualNovels.TheExperienceMaker;
using NUnit.Framework;

namespace TestDrivenNovel.TheExperienceMakerTests
{
    [TestFixture]  
    class NameTests 
    {
        [Test]
        public void Novel_is_called_TheExperienceMaker()
        {
            // Arrange & Act
            var novel = new TheExperienceMaker();

            // Assert
            Assert.AreEqual(NovelNames.TheExperienceMaker, novel.Name);
        } 

        [Test]
        public void Protagonist_is_called_Seren()
        {
            // Arrange
            var novel = new TheExperienceMaker();

            // Act
            var protagonist = novel.GetProtagonist();

            // Assert
            Assert.AreEqual("Seren", protagonist.Name);
        }
    }
}
