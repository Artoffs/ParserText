namespace TextParser
{
    public class Constants
    {
        public const string RUSSIAN_ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя-";
        public const string ENGLISH_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string FULL_ALPHABET = RUSSIAN_ALPHABET + ENGLISH_ALPHABET;
        public const string RUSSIAN_CONSONANTS = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩбвгджзйклмнпрстфхцчшщ";
        public const string ENGLISH_CONSONANTS = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
        public const string FULL_CONSONANTS = RUSSIAN_CONSONANTS + ENGLISH_CONSONANTS;
        public const string PUNCTUATION = "!?.";
    }
}
