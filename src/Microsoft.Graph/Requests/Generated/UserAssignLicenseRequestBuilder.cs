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
    using System.Text;

    /// <summary>
    /// The type UserAssignLicenseRequestBuilder.
    /// </summary>
    public partial class UserAssignLicenseRequestBuilder : BaseRequestBuilder, IUserAssignLicenseRequestBuilder
    {
    
        public UserAssignLicenseRequestBuilder(
            string requestUrl,
            IBaseClient client,
            AssignedLicense addLicenses,
            Guid removeLicenses)
            : base(requestUrl, client)
        {
            
            this.AddLicenses = addLicenses;
            this.RemoveLicenses = removeLicenses;

        }
    
        /// <summary>
        /// Gets the value of AddLicenses.
        /// </summary>
        public AssignedLicense AddLicenses { get; set; }
    
        /// <summary>
        /// Gets the value of RemoveLicenses.
        /// </summary>
        public Guid RemoveLicenses { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserAssignLicenseRequest Request(IList<Option> options = null)
        {
        
            return new UserAssignLicenseRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.AddLicenses,
                this.RemoveLicenses);
        
        }

    }
}

