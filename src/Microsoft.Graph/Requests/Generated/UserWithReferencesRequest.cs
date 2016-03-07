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
    /// The type UserWithReferencesRequest.
    /// </summary>
    public partial class UserWithReferencesRequest : BaseRequest, IUserWithReferencesRequest
    {
        /// <summary>
        /// Constructs a new UserWithReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserWithReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <returns>The User.</returns>
        public Task<User> GetAsync()
        {
            return this.GetAsync(HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The User.</returns>
        public async Task<User> GetAsync(HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<User>(null, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserWithReferencesRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserWithReferencesRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="userToInitialize">The <see cref="User"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(User userToInitialize)
        {
        
            if (userToInitialize != null && userToInitialize.AdditionalData != null)
            {
        
                if (userToInitialize.OwnedDevices != null && userToInitialize.OwnedDevices.CurrentPage != null)
                {
                    userToInitialize.OwnedDevices.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("ownedDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.OwnedDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.RegisteredDevices != null && userToInitialize.RegisteredDevices.CurrentPage != null)
                {
                    userToInitialize.RegisteredDevices.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("registeredDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.RegisteredDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.DirectReports != null && userToInitialize.DirectReports.CurrentPage != null)
                {
                    userToInitialize.DirectReports.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("directReports@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.DirectReports.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.MemberOf != null && userToInitialize.MemberOf.CurrentPage != null)
                {
                    userToInitialize.MemberOf.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.CreatedObjects != null && userToInitialize.CreatedObjects.CurrentPage != null)
                {
                    userToInitialize.CreatedObjects.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("createdObjects@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CreatedObjects.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.OwnedObjects != null && userToInitialize.OwnedObjects.CurrentPage != null)
                {
                    userToInitialize.OwnedObjects.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("ownedObjects@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.OwnedObjects.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.Messages != null && userToInitialize.Messages.CurrentPage != null)
                {
                    userToInitialize.Messages.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("messages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Messages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.MailFolders != null && userToInitialize.MailFolders.CurrentPage != null)
                {
                    userToInitialize.MailFolders.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("mailFolders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.MailFolders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.Calendars != null && userToInitialize.Calendars.CurrentPage != null)
                {
                    userToInitialize.Calendars.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendars@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Calendars.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.CalendarGroups != null && userToInitialize.CalendarGroups.CurrentPage != null)
                {
                    userToInitialize.CalendarGroups.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendarGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CalendarGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.CalendarView != null && userToInitialize.CalendarView.CurrentPage != null)
                {
                    userToInitialize.CalendarView.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CalendarView.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.Events != null && userToInitialize.Events.CurrentPage != null)
                {
                    userToInitialize.Events.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("events@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Events.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.Contacts != null && userToInitialize.Contacts.CurrentPage != null)
                {
                    userToInitialize.Contacts.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("contacts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Contacts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
                if (userToInitialize.ContactFolders != null && userToInitialize.ContactFolders.CurrentPage != null)
                {
                    userToInitialize.ContactFolders.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("contactFolders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.ContactFolders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
            }

        
        }
    }
}
