using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using TitatnicExplorer.Data;

namespace TitanicExplorer.Data.Tests
{
    public class DataTests
    {
        
        public DataTests()
        {
           this.SampleDataPath = Path.GetTempFileName();

           File.WriteAllText(this.SampleDataPath, Resource.passengers);
        }

        public string SampleDataPath
        {
            get; set;
        }

        [Fact]
        public void LoadData()
        {
            var passengers = Passenger.LoadFromFile(this.SampleDataPath);

            Assert.Equal(887, passengers.Count());

            Assert.Equal("Mr. Owen Harris Braund", passengers.First().Name);
        }
    }
    
}