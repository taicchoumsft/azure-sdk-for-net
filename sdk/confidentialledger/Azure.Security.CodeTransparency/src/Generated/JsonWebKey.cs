// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.CodeTransparency
{
    /// <summary> rfc7517 JSON Web Key representation adapted from a shared swagger definition in the common types. </summary>
    public partial class JsonWebKey
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JsonWebKey"/>. </summary>
        /// <param name="kty">
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The "kty" value is a case-sensitive string.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kty"/> is null. </exception>
        internal JsonWebKey(string kty)
        {
            Argument.AssertNotNull(kty, nameof(kty));

            Kty = kty;
            X5c = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="JsonWebKey"/>. </summary>
        /// <param name="alg">
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </param>
        /// <param name="crv"> The "crv" (curve) parameter identifies the curve type. </param>
        /// <param name="d"> RSA private exponent or ECC private key. </param>
        /// <param name="dp"> RSA Private Key Parameter. </param>
        /// <param name="dq"> RSA Private Key Parameter. </param>
        /// <param name="e"> RSA public exponent, in Base64. </param>
        /// <param name="k"> Symmetric key. </param>
        /// <param name="kid">
        /// The "kid" (key ID) parameter is used to match a specific key.  This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the "kid" value is
        /// unspecified.  When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values.  (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The "kid"
        /// value is a case-sensitive string.
        /// </param>
        /// <param name="kty">
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The "kty" value is a case-sensitive string.
        /// </param>
        /// <param name="n"> RSA modulus, in Base64. </param>
        /// <param name="p"> RSA secret prime. </param>
        /// <param name="q"> RSA secret prime, with p &lt; q. </param>
        /// <param name="qi"> RSA Private Key Parameter. </param>
        /// <param name="use">
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </param>
        /// <param name="x"> X coordinate for the Elliptic Curve point. </param>
        /// <param name="x5c">
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </param>
        /// <param name="y"> Y coordinate for the Elliptic Curve point. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JsonWebKey(string alg, string crv, string d, string dp, string dq, string e, string k, string kid, string kty, string n, string p, string q, string qi, string use, string x, IReadOnlyList<string> x5c, string y, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Alg = alg;
            Crv = crv;
            D = d;
            Dp = dp;
            Dq = dq;
            E = e;
            K = k;
            Kid = kid;
            Kty = kty;
            N = n;
            P = p;
            Q = q;
            Qi = qi;
            Use = use;
            X = x;
            X5c = x5c;
            Y = y;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JsonWebKey"/> for deserialization. </summary>
        internal JsonWebKey()
        {
        }

        /// <summary>
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </summary>
        public string Alg { get; }
        /// <summary> The "crv" (curve) parameter identifies the curve type. </summary>
        public string Crv { get; }
        /// <summary> RSA private exponent or ECC private key. </summary>
        public string D { get; }
        /// <summary> RSA Private Key Parameter. </summary>
        public string Dp { get; }
        /// <summary> RSA Private Key Parameter. </summary>
        public string Dq { get; }
        /// <summary> RSA public exponent, in Base64. </summary>
        public string E { get; }
        /// <summary> Symmetric key. </summary>
        public string K { get; }
        /// <summary>
        /// The "kid" (key ID) parameter is used to match a specific key.  This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the "kid" value is
        /// unspecified.  When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values.  (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The "kid"
        /// value is a case-sensitive string.
        /// </summary>
        public string Kid { get; }
        /// <summary>
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The "kty" value is a case-sensitive string.
        /// </summary>
        public string Kty { get; }
        /// <summary> RSA modulus, in Base64. </summary>
        public string N { get; }
        /// <summary> RSA secret prime. </summary>
        public string P { get; }
        /// <summary> RSA secret prime, with p &lt; q. </summary>
        public string Q { get; }
        /// <summary> RSA Private Key Parameter. </summary>
        public string Qi { get; }
        /// <summary>
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </summary>
        public string Use { get; }
        /// <summary> X coordinate for the Elliptic Curve point. </summary>
        public string X { get; }
        /// <summary>
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </summary>
        public IReadOnlyList<string> X5c { get; }
        /// <summary> Y coordinate for the Elliptic Curve point. </summary>
        public string Y { get; }
    }
}
