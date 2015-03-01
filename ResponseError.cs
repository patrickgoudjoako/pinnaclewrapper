﻿using System;
using System.Xml.Serialization;

namespace PinnacleWrapper
{
    [Serializable]
    [XmlRoot("err")]
    public class ResponseError
    {
        [XmlAttribute("code")]
        public int Code { get; set; }

        [XmlText]
        public string Message { get; set; }
    }
}
