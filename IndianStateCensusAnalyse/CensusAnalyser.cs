﻿using IndianStateCensusAnalyse.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyse
{
    public class CensusAnalyser
    {        
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        //Dictionary
        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}