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
    /// The type Directory Role.
    /// </summary>
    [DataContract]
    public partial class DirectoryRole : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets role template id.
        /// </summary>
        [DataMember(Name = "roleTemplateId", EmitDefaultValue = false, IsRequired = false)]
        public string RoleTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(InterfaceConverter<MembersCollectionWithReferencesPage>))]
        public IMembersCollectionWithReferencesPage Members { get; set; }
    
    }
}

