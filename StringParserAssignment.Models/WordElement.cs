using System.Xml.Serialization;

namespace StringParserAssignment.Models
{
    public class WordElement
    {
        [XmlElement("Word")]
        public string[] Words { get; set; }
    }
}
