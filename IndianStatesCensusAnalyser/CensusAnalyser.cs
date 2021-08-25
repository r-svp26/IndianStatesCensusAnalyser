using IndianStatesCensusAnalyser.DTO;
using System.Collections.Generic;

namespace IndianStatesCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US
        }
        Dictionary<string, CensusDTO> dataMap;     
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
