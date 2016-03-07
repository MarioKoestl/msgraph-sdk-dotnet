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
    /// The type Reminder.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Reminder
    {
    
        /// <summary>
        /// Gets or sets eventId.
        /// </summary>
        [DataMember(Name = "eventId", EmitDefaultValue = false, IsRequired = false)]
        public string EventId { get; set; }
    
        /// <summary>
        /// Gets or sets eventStartTime.
        /// </summary>
        [DataMember(Name = "eventStartTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeTimeZone EventStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets eventEndTime.
        /// </summary>
        [DataMember(Name = "eventEndTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeTimeZone EventEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets changeKey.
        /// </summary>
        [DataMember(Name = "changeKey", EmitDefaultValue = false, IsRequired = false)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets eventSubject.
        /// </summary>
        [DataMember(Name = "eventSubject", EmitDefaultValue = false, IsRequired = false)]
        public string EventSubject { get; set; }
    
        /// <summary>
        /// Gets or sets eventLocation.
        /// </summary>
        [DataMember(Name = "eventLocation", EmitDefaultValue = false, IsRequired = false)]
        public Location EventLocation { get; set; }
    
        /// <summary>
        /// Gets or sets eventWebLink.
        /// </summary>
        [DataMember(Name = "eventWebLink", EmitDefaultValue = false, IsRequired = false)]
        public string EventWebLink { get; set; }
    
        /// <summary>
        /// Gets or sets reminderFireTime.
        /// </summary>
        [DataMember(Name = "reminderFireTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeTimeZone ReminderFireTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
