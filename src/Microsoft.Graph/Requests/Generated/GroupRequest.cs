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
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type GroupRequest.
    /// </summary>
    public partial class GroupRequest : BaseRequest, IGroupRequest
    {
        /// <summary>
        /// Constructs a new GroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Group using PUT.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <returns>The created Group.</returns>
        public Task<Group> CreateAsync(Group groupToCreate)
        {
            return this.CreateAsync(groupToCreate, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Group using PUT.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Group.</returns>
        public async Task<Group> CreateAsync(Group groupToCreate, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<Group>(groupToCreate, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Group>(null, completionOption, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <returns>The Group.</returns>
        public Task<Group> GetAsync()
        {
            return this.GetAsync(HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Group.</returns>
        public async Task<Group> GetAsync(HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Group>(null, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <returns>The updated Group.</returns>
        public Task<Group> UpdateAsync(Group groupToUpdate)
        {
            return this.UpdateAsync(groupToUpdate, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Group.</returns>
        public async Task<Group> UpdateAsync(Group groupToUpdate, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Group>(groupToUpdate, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="groupToInitialize">The <see cref="Group"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Group groupToInitialize)
        {
        
            if (groupToInitialize != null && groupToInitialize.AdditionalData != null)
            {
        
                if (groupToInitialize.Members != null && groupToInitialize.Members.CurrentPage != null)
                {
                    groupToInitialize.Members.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.MemberOf != null && groupToInitialize.MemberOf.CurrentPage != null)
                {
                    groupToInitialize.MemberOf.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.Owners != null && groupToInitialize.Owners.CurrentPage != null)
                {
                    groupToInitialize.Owners.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("owners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Owners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.Threads != null && groupToInitialize.Threads.CurrentPage != null)
                {
                    groupToInitialize.Threads.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("threads@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Threads.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.CalendarView != null && groupToInitialize.CalendarView.CurrentPage != null)
                {
                    groupToInitialize.CalendarView.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.CalendarView.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.Events != null && groupToInitialize.Events.CurrentPage != null)
                {
                    groupToInitialize.Events.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("events@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Events.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.Conversations != null && groupToInitialize.Conversations.CurrentPage != null)
                {
                    groupToInitialize.Conversations.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("conversations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Conversations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.AcceptedSenders != null && groupToInitialize.AcceptedSenders.CurrentPage != null)
                {
                    groupToInitialize.AcceptedSenders.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("acceptedSenders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.AcceptedSenders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (groupToInitialize.RejectedSenders != null && groupToInitialize.RejectedSenders.CurrentPage != null)
                {
                    groupToInitialize.RejectedSenders.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("rejectedSenders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.RejectedSenders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
            }

        
        }
    }
}
