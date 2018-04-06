namespace PokeDictionary
{
    /// <summary>
    /// Gen 3 - 5 Easy Chat dictionary
    /// </summary>
    abstract class EasyChat
    {
        /// <summary>
        /// Returns a new Easy Chat dictionary.
        /// </summary>
        /// <param name="g"><see cref="PokeDictionary.Generation">Generation</see> of the dictionary.</param>
        /// <param name="l"><see cref="PokeDictionary.Language">Language</see> of the dictionary.</param>
        /// <returns></returns>
        public static EasyChat New(Generation g, Language l = Language.English)
        {
            switch (g)
            {
                case Generation.Gen3: return new EasyChatGen3(l);
                case Generation.Gen4: return new EasyChatGen4(l);
                case Generation.Gen5: return new EasyChatGen5(l);
                default: return null; // default case shouldn't happen
            }
        }

        /// <summary>
        /// Gets the Easy Chat word/phrase for the given value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract string GetWord(short value);

        /// <summary>
        /// Gets the Easy Chat value for the given word/phrase.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public abstract short GetValue(string word);

        /// <summary>
        /// The <see cref="PokeDictionary.Language">Language</see> of the Easy Chat dictionary.
        /// </summary>
        public abstract Language Language { get; set; }

        /// <summary>
        /// The <see cref="PokeDictionary.Generation">Generation</see> of the Easy Chat dictionary.
        /// </summary>
        public abstract Generation Generation { get; }

        /// <summary>
        /// The words of the Easy Chat dictionary.
        /// </summary>
        public abstract string[] Words { get; }
    }
    
    /// <summary>
    /// Pokémon Generations that use an Easy Chat dictionary.
    /// </summary>
    public enum Generation
    {
        Gen3 = 3,
        Gen4 = 4,
        Gen5 = 5
    }

    /// <summary>
    /// Languages of Gen 3 - 5 Pokémon games.
    /// </summary>
    public enum Language
    {
        English = 1,
        French = 2,
        German = 3,
        Italian = 4,
        Spanish = 5,
        Japanese = 6,
        Korean = 7
    }
}