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

    /// <summary>
    /// The interface IDriveItemRequestBuilder.
    /// </summary>
    public partial interface IDriveItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDriveItemRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDriveItemRequest Request(IList<Option> options);
        
        /// <summary>
        /// Gets the request builder for CreatedByUser.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferencesRequestBuilder"/>.</returns>
        IUserWithReferencesRequestBuilder CreatedByUser { get; }

        /// <summary>
        /// Gets the request builder for LastModifiedByUser.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferencesRequestBuilder"/>.</returns>
        IUserWithReferencesRequestBuilder LastModifiedByUser { get; }

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IPermissionsCollectionRequestBuilder"/>.</returns>
        IPermissionsCollectionRequestBuilder Permissions { get; }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IChildrenCollectionRequestBuilder"/>.</returns>
        IChildrenCollectionRequestBuilder Children { get; }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IThumbnailsCollectionRequestBuilder"/>.</returns>
        IThumbnailsCollectionRequestBuilder Thumbnails { get; }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IDriveItemContentRequestBuilder"/>.</returns>
        IDriveItemContentRequestBuilder Content { get; }
        
        /// <summary>
        /// Gets the request builder for DriveItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateLinkRequestBuilder"/>.</returns>
        IDriveItemCreateLinkRequestBuilder CreateLink(
            string type,
            string scope = null);

        /// <summary>
        /// Gets the request builder for DriveItemSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSearchRequestBuilder"/>.</returns>
        IDriveItemSearchRequestBuilder Search(
            string q = null);
    
    }
}
