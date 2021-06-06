using Newtonsoft.Json;

namespace BibleApp.Models
{
    
    public class BibleVerseModel
    {
        [JsonProperty("chapter")]
        public int Chapter { get; set; }

        [JsonProperty("verse")]
        public int Verse { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("translation_id")]
        public string TranslationId { get; set; }

        [JsonProperty("book_id")]
        public string BookId { get; set; }

        [JsonProperty("book_name")]
        public string BookName { get; set; }
    }
}
