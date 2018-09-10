using StringParserAssignment.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringParserAssignment.Repository
{
    public abstract class Parser
    {
        internal abstract string Parse(string input);

        protected virtual SentenceElement GetOutPut(string inputText)
        {
            inputText = Regex.Replace(inputText, @"\r\n", " ");
            inputText = Regex.Replace(inputText, @",", " ");

            var setences = inputText.Split(new[] { '.' }).Where(a => !string.IsNullOrWhiteSpace(a)).Select((s) =>
            {
                var words = s.Split(new[] { ' ' }).Where(a => !string.IsNullOrWhiteSpace(a)).OrderBy(o => o).ToArray();

                var sentence = new WordElement { Words = words };
                return sentence;

            }).ToArray();

            var text = new SentenceElement { Sentences = setences };
            return text;
        }
    }
}
