using IndianStatesCensusAnalyser;
using NUnit.Framework;
using IndianStatesCensusAnalyser.DTO;
using System.Collections.Generic;

namespace CensusAnalyserTest
{
    /// <summary>
    /// NUnit Test Class
    /// </summary>
    public class Tests
    {
        string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        string indianStateCensusFilePath = @"V:\BridgeLabz\IndianStatesCensusAnalyser\CensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";
        string indianStateCodeFilePath = @"V:\BridgeLabz\IndianStatesCensusAnalyser\CensusAnalyserTest\CSVFiles\IndiaStateCode.csv";
        
        CensusAnalyser censusAnalyser = null;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        /// <summary>
        /// TC-1.1
        /// </summary>
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29,totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}