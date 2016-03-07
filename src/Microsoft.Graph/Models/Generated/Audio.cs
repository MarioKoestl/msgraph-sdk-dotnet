// ------------------------------------------------------------------------------
//  Copyright (c) 2016 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Audio.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Audio
    {
    
        /// <summary>
        /// Gets or sets album.
        /// </summary>
        [DataMember(Name = "album", EmitDefaultValue = false, IsRequired = false)]
        public string Album { get; set; }
    
        /// <summary>
        /// Gets or sets albumArtist.
        /// </summary>
        [DataMember(Name = "albumArtist", EmitDefaultValue = false, IsRequired = false)]
        public string AlbumArtist { get; set; }
    
        /// <summary>
        /// Gets or sets artist.
        /// </summary>
        [DataMember(Name = "artist", EmitDefaultValue = false, IsRequired = false)]
        public string Artist { get; set; }
    
        /// <summary>
        /// Gets or sets bitrate.
        /// </summary>
        [DataMember(Name = "bitrate", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Bitrate { get; set; }
    
        /// <summary>
        /// Gets or sets composers.
        /// </summary>
        [DataMember(Name = "composers", EmitDefaultValue = false, IsRequired = false)]
        public string Composers { get; set; }
    
        /// <summary>
        /// Gets or sets copyright.
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false, IsRequired = false)]
        public string Copyright { get; set; }
    
        /// <summary>
        /// Gets or sets disc.
        /// </summary>
        [DataMember(Name = "disc", EmitDefaultValue = false, IsRequired = false)]
        public Int16? Disc { get; set; }
    
        /// <summary>
        /// Gets or sets discCount.
        /// </summary>
        [DataMember(Name = "discCount", EmitDefaultValue = false, IsRequired = false)]
        public Int16? DiscCount { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Duration { get; set; }
    
        /// <summary>
        /// Gets or sets genre.
        /// </summary>
        [DataMember(Name = "genre", EmitDefaultValue = false, IsRequired = false)]
        public string Genre { get; set; }
    
        /// <summary>
        /// Gets or sets hasDrm.
        /// </summary>
        [DataMember(Name = "hasDrm", EmitDefaultValue = false, IsRequired = false)]
        public bool? HasDrm { get; set; }
    
        /// <summary>
        /// Gets or sets isVariableBitrate.
        /// </summary>
        [DataMember(Name = "isVariableBitrate", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsVariableBitrate { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets track.
        /// </summary>
        [DataMember(Name = "track", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Track { get; set; }
    
        /// <summary>
        /// Gets or sets trackCount.
        /// </summary>
        [DataMember(Name = "trackCount", EmitDefaultValue = false, IsRequired = false)]
        public Int32? TrackCount { get; set; }
    
        /// <summary>
        /// Gets or sets year.
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Year { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
