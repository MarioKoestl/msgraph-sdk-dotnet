// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TeamsAppAppDefinitionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class TeamsAppAppDefinitionsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, ITeamsAppAppDefinitionsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new TeamsAppAppDefinitionsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamsAppAppDefinitionsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamsAppAppDefinitionsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamsAppAppDefinitionsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new TeamsAppAppDefinitionsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamsAppDefinitionWithReferenceRequestBuilder"/> for the specified TeamsAppTeamsAppDefinition.
        /// </summary>
        /// <param name="id">The ID for the TeamsAppTeamsAppDefinition.</param>
        /// <returns>The <see cref="ITeamsAppDefinitionWithReferenceRequestBuilder"/>.</returns>
        public ITeamsAppDefinitionWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new TeamsAppDefinitionWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="ITeamsAppAppDefinitionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="ITeamsAppAppDefinitionsCollectionReferencesRequestBuilder"/>.</returns>
        public ITeamsAppAppDefinitionsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new TeamsAppAppDefinitionsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
