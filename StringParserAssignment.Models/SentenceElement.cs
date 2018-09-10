using System.Xml.Serialization;

namespace StringParserAssignment.Models
{
    public class SentenceElement
    {
        [XmlElement("Sentence")]
        public WordElement[] Sentences { get; set; }
    }
}
