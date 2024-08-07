// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> Response for detect API. </summary>
    public partial class FaceDetectionResult
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

        /// <summary> Initializes a new instance of <see cref="FaceDetectionResult"/>. </summary>
        /// <param name="faceRectangle"> A rectangle area for the face location on image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="faceRectangle"/> is null. </exception>
        internal FaceDetectionResult(FaceRectangle faceRectangle)
        {
            Argument.AssertNotNull(faceRectangle, nameof(faceRectangle));

            FaceRectangle = faceRectangle;
        }

        /// <summary> Initializes a new instance of <see cref="FaceDetectionResult"/>. </summary>
        /// <param name="faceId"> Unique faceId of the detected face, created by detection API and it will expire 24 hours after the detection call. To return this, it requires 'returnFaceId' parameter to be true. </param>
        /// <param name="recognitionModel"> The 'recognitionModel' associated with this faceId. This is only returned when 'returnRecognitionModel' is explicitly set as true. </param>
        /// <param name="faceRectangle"> A rectangle area for the face location on image. </param>
        /// <param name="faceLandmarks"> An array of 27-point face landmarks pointing to the important positions of face components. To return this, it requires 'returnFaceLandmarks' parameter to be true. </param>
        /// <param name="faceAttributes"> Face attributes for detected face. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FaceDetectionResult(Guid? faceId, FaceRecognitionModel? recognitionModel, FaceRectangle faceRectangle, FaceLandmarks faceLandmarks, FaceAttributes faceAttributes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FaceId = faceId;
            RecognitionModel = recognitionModel;
            FaceRectangle = faceRectangle;
            FaceLandmarks = faceLandmarks;
            FaceAttributes = faceAttributes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FaceDetectionResult"/> for deserialization. </summary>
        internal FaceDetectionResult()
        {
        }

        /// <summary> Unique faceId of the detected face, created by detection API and it will expire 24 hours after the detection call. To return this, it requires 'returnFaceId' parameter to be true. </summary>
        public Guid? FaceId { get; }
        /// <summary> The 'recognitionModel' associated with this faceId. This is only returned when 'returnRecognitionModel' is explicitly set as true. </summary>
        public FaceRecognitionModel? RecognitionModel { get; }
        /// <summary> A rectangle area for the face location on image. </summary>
        public FaceRectangle FaceRectangle { get; }
        /// <summary> An array of 27-point face landmarks pointing to the important positions of face components. To return this, it requires 'returnFaceLandmarks' parameter to be true. </summary>
        public FaceLandmarks FaceLandmarks { get; }
        /// <summary> Face attributes for detected face. </summary>
        public FaceAttributes FaceAttributes { get; }
    }
}
