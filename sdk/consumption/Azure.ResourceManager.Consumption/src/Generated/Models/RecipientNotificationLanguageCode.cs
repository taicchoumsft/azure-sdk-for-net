// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Language in which the recipient will receive the notification. </summary>
    public readonly partial struct RecipientNotificationLanguageCode : IEquatable<RecipientNotificationLanguageCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecipientNotificationLanguageCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecipientNotificationLanguageCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnglishUnitedStatesValue = "en-us";
        private const string JapaneseJapanValue = "ja-jp";
        private const string ChinesePrcValue = "zh-cn";
        private const string GermanGermanyValue = "de-de";
        private const string SpanishSpainValue = "es-es";
        private const string FrenchFranceValue = "fr-fr";
        private const string ItalianItalyValue = "it-it";
        private const string KoreanKoreaValue = "ko-kr";
        private const string PortugueseBrazilValue = "pt-br";
        private const string RussianRussiaValue = "ru-ru";
        private const string ChineseTaiwanValue = "zh-tw";
        private const string CzechCzechRepublicValue = "cs-cz";
        private const string PolishPolandValue = "pl-pl";
        private const string TurkishTurkeyValue = "tr-tr";
        private const string DanishDenmarkValue = "da-dk";
        private const string EnglishUnitedKingdomValue = "en-gb";
        private const string HungarianHungaryValue = "hu-hu";
        private const string NorwegianNorwayValue = "nb-no";
        private const string DutchNetherlandsValue = "nl-nl";
        private const string PortuguesePortugalValue = "pt-pt";
        private const string SwedishSwedenValue = "sv-se";

        /// <summary> en-us. </summary>
        public static RecipientNotificationLanguageCode EnglishUnitedStates { get; } = new RecipientNotificationLanguageCode(EnglishUnitedStatesValue);
        /// <summary> ja-jp. </summary>
        public static RecipientNotificationLanguageCode JapaneseJapan { get; } = new RecipientNotificationLanguageCode(JapaneseJapanValue);
        /// <summary> zh-cn. </summary>
        public static RecipientNotificationLanguageCode ChinesePrc { get; } = new RecipientNotificationLanguageCode(ChinesePrcValue);
        /// <summary> de-de. </summary>
        public static RecipientNotificationLanguageCode GermanGermany { get; } = new RecipientNotificationLanguageCode(GermanGermanyValue);
        /// <summary> es-es. </summary>
        public static RecipientNotificationLanguageCode SpanishSpain { get; } = new RecipientNotificationLanguageCode(SpanishSpainValue);
        /// <summary> fr-fr. </summary>
        public static RecipientNotificationLanguageCode FrenchFrance { get; } = new RecipientNotificationLanguageCode(FrenchFranceValue);
        /// <summary> it-it. </summary>
        public static RecipientNotificationLanguageCode ItalianItaly { get; } = new RecipientNotificationLanguageCode(ItalianItalyValue);
        /// <summary> ko-kr. </summary>
        public static RecipientNotificationLanguageCode KoreanKorea { get; } = new RecipientNotificationLanguageCode(KoreanKoreaValue);
        /// <summary> pt-br. </summary>
        public static RecipientNotificationLanguageCode PortugueseBrazil { get; } = new RecipientNotificationLanguageCode(PortugueseBrazilValue);
        /// <summary> ru-ru. </summary>
        public static RecipientNotificationLanguageCode RussianRussia { get; } = new RecipientNotificationLanguageCode(RussianRussiaValue);
        /// <summary> zh-tw. </summary>
        public static RecipientNotificationLanguageCode ChineseTaiwan { get; } = new RecipientNotificationLanguageCode(ChineseTaiwanValue);
        /// <summary> cs-cz. </summary>
        public static RecipientNotificationLanguageCode CzechCzechRepublic { get; } = new RecipientNotificationLanguageCode(CzechCzechRepublicValue);
        /// <summary> pl-pl. </summary>
        public static RecipientNotificationLanguageCode PolishPoland { get; } = new RecipientNotificationLanguageCode(PolishPolandValue);
        /// <summary> tr-tr. </summary>
        public static RecipientNotificationLanguageCode TurkishTurkey { get; } = new RecipientNotificationLanguageCode(TurkishTurkeyValue);
        /// <summary> da-dk. </summary>
        public static RecipientNotificationLanguageCode DanishDenmark { get; } = new RecipientNotificationLanguageCode(DanishDenmarkValue);
        /// <summary> en-gb. </summary>
        public static RecipientNotificationLanguageCode EnglishUnitedKingdom { get; } = new RecipientNotificationLanguageCode(EnglishUnitedKingdomValue);
        /// <summary> hu-hu. </summary>
        public static RecipientNotificationLanguageCode HungarianHungary { get; } = new RecipientNotificationLanguageCode(HungarianHungaryValue);
        /// <summary> nb-no. </summary>
        public static RecipientNotificationLanguageCode NorwegianNorway { get; } = new RecipientNotificationLanguageCode(NorwegianNorwayValue);
        /// <summary> nl-nl. </summary>
        public static RecipientNotificationLanguageCode DutchNetherlands { get; } = new RecipientNotificationLanguageCode(DutchNetherlandsValue);
        /// <summary> pt-pt. </summary>
        public static RecipientNotificationLanguageCode PortuguesePortugal { get; } = new RecipientNotificationLanguageCode(PortuguesePortugalValue);
        /// <summary> sv-se. </summary>
        public static RecipientNotificationLanguageCode SwedishSweden { get; } = new RecipientNotificationLanguageCode(SwedishSwedenValue);
        /// <summary> Determines if two <see cref="RecipientNotificationLanguageCode"/> values are the same. </summary>
        public static bool operator ==(RecipientNotificationLanguageCode left, RecipientNotificationLanguageCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecipientNotificationLanguageCode"/> values are not the same. </summary>
        public static bool operator !=(RecipientNotificationLanguageCode left, RecipientNotificationLanguageCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecipientNotificationLanguageCode"/>. </summary>
        public static implicit operator RecipientNotificationLanguageCode(string value) => new RecipientNotificationLanguageCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecipientNotificationLanguageCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecipientNotificationLanguageCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
