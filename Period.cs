﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PinnacleWrapper
{
    [Serializable]
    [XmlRoot("period")]
    public class Period
    {
        [XmlAttribute("lineId")]
        public long LineId { get; set; }

        [XmlElement("number")]
        public int Number { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("cutoffDateTime")]
        public DateTime CutoffDateTime { get; set; }

        [XmlArray("spreads")]
        [XmlArrayItem("spread")]
        public List<Spread> Spreads { get; set; }

        [XmlElement("moneyLine")]
        public MoneyLine MoneyLine { get; set; }

        [XmlElement("maxBetAmount")]
        public BetAmount MaxBetAmount { get; set; }
    }
}
