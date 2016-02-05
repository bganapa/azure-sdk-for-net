// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.AzureStack.Management;

namespace Microsoft.AzureStack.Management
{
    public partial class AzureStackClient : ServiceClient<AzureStackClient>, IAzureStackClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private ICloudOperations _clouds;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual ICloudOperations Clouds
        {
            get { return this._clouds; }
        }
        
        private ICurationOperations _curation;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual ICurationOperations Curation
        {
            get { return this._curation; }
        }
        
        private IDelegatedOfferOperations _delegatedOffers;
        
        /// <summary>
        /// Operations for delegated offers.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IDelegatedOfferOperations DelegatedOffers
        {
            get { return this._delegatedOffers; }
        }
        
        private IDelegatedProviderConfigurationOperations _delegatedProviderConfiguration;
        
        /// <summary>
        /// Operations for delegated provider configuration.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IDelegatedProviderConfigurationOperations DelegatedProviderConfiguration
        {
            get { return this._delegatedProviderConfiguration; }
        }
        
        private IEventTypesOperations _eventTypes;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IEventTypesOperations EventTypes
        {
            get { return this._eventTypes; }
        }
        
        private IExtensionMetadataOperations _extensionsMetadata;
        
        /// <summary>
        /// Operations for extensions metadata.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IExtensionMetadataOperations ExtensionsMetadata
        {
            get { return this._extensionsMetadata; }
        }
        
        private IGalleryItemOperations _galleryItem;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IGalleryItemOperations GalleryItem
        {
            get { return this._galleryItem; }
        }
        
        private IImportedSubscriptionOperations _importedSubscriptions;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IImportedSubscriptionOperations ImportedSubscriptions
        {
            get { return this._importedSubscriptions; }
        }
        
        private IManagedLocationOperations _managedLocations;
        
        /// <summary>
        /// Managed locations operations for admin.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedLocationOperations ManagedLocations
        {
            get { return this._managedLocations; }
        }
        
        private IManagedOfferOperations _managedOffers;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedOfferOperations ManagedOffers
        {
            get { return this._managedOffers; }
        }
        
        private IManagedPlanOperations _managedPlans;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedPlanOperations ManagedPlans
        {
            get { return this._managedPlans; }
        }
        
        private IManagedSubscriptionOperations _managedSubscriptions;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IManagedSubscriptionOperations ManagedSubscriptions
        {
            get { return this._managedSubscriptions; }
        }
        
        private IOfferOperations _offers;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IOfferOperations Offers
        {
            get { return this._offers; }
        }
        
        private IPackageOperations _package;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IPackageOperations Package
        {
            get { return this._package; }
        }
        
        private IPlanOperations _plans;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IPlanOperations Plans
        {
            get { return this._plans; }
        }
        
        private IProviderRegistrationOperations _providerRegistrations;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IProviderRegistrationOperations ProviderRegistrations
        {
            get { return this._providerRegistrations; }
        }
        
        private IPublicGalleryItemOperations _publicGalleryItem;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IPublicGalleryItemOperations PublicGalleryItem
        {
            get { return this._publicGalleryItem; }
        }
        
        private IResourceGroupOperations _resourceGroups;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceGroupOperations ResourceGroups
        {
            get { return this._resourceGroups; }
        }
        
        private IResourceOperations _resources;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceOperations Resources
        {
            get { return this._resources; }
        }
        
        private IResourceProviderOperations _resourceProviders;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IResourceProviderOperations ResourceProviders
        {
            get { return this._resourceProviders; }
        }
        
        private IShallowResourceOperations _shallowResources;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual IShallowResourceOperations ShallowResources
        {
            get { return this._shallowResources; }
        }
        
        private ISubscriptionOperations _subscriptions;
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        public virtual ISubscriptionOperations Subscriptions
        {
            get { return this._subscriptions; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        public AzureStackClient()
            : base()
        {
            this._clouds = new CloudOperations(this);
            this._curation = new CurationOperations(this);
            this._delegatedOffers = new DelegatedOfferOperations(this);
            this._delegatedProviderConfiguration = new DelegatedProviderConfigurationOperations(this);
            this._eventTypes = new EventTypesOperations(this);
            this._extensionsMetadata = new ExtensionMetadataOperations(this);
            this._galleryItem = new GalleryItemOperations(this);
            this._importedSubscriptions = new ImportedSubscriptionOperations(this);
            this._managedLocations = new ManagedLocationOperations(this);
            this._managedOffers = new ManagedOfferOperations(this);
            this._managedPlans = new ManagedPlanOperations(this);
            this._managedSubscriptions = new ManagedSubscriptionOperations(this);
            this._offers = new OfferOperations(this);
            this._package = new PackageOperations(this);
            this._plans = new PlanOperations(this);
            this._providerRegistrations = new ProviderRegistrationOperations(this);
            this._publicGalleryItem = new PublicGalleryItemOperations(this);
            this._resourceGroups = new ResourceGroupOperations(this);
            this._resources = new ResourceOperations(this);
            this._resourceProviders = new ResourceProviderOperations(this);
            this._shallowResources = new ShallowResourceOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._apiVersion = "1.0";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public AzureStackClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public AzureStackClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = null;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AzureStackClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._clouds = new CloudOperations(this);
            this._curation = new CurationOperations(this);
            this._delegatedOffers = new DelegatedOfferOperations(this);
            this._delegatedProviderConfiguration = new DelegatedProviderConfigurationOperations(this);
            this._eventTypes = new EventTypesOperations(this);
            this._extensionsMetadata = new ExtensionMetadataOperations(this);
            this._galleryItem = new GalleryItemOperations(this);
            this._importedSubscriptions = new ImportedSubscriptionOperations(this);
            this._managedLocations = new ManagedLocationOperations(this);
            this._managedOffers = new ManagedOfferOperations(this);
            this._managedPlans = new ManagedPlanOperations(this);
            this._managedSubscriptions = new ManagedSubscriptionOperations(this);
            this._offers = new OfferOperations(this);
            this._package = new PackageOperations(this);
            this._plans = new PlanOperations(this);
            this._providerRegistrations = new ProviderRegistrationOperations(this);
            this._publicGalleryItem = new PublicGalleryItemOperations(this);
            this._resourceGroups = new ResourceGroupOperations(this);
            this._resources = new ResourceOperations(this);
            this._resourceProviders = new ResourceProviderOperations(this);
            this._shallowResources = new ShallowResourceOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._apiVersion = "1.0";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AzureStackClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureStackClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AzureStackClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = null;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another AzureStackClient
        /// instance
        /// </summary>
        /// <param name='client'>
        /// Instance of AzureStackClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<AzureStackClient> client)
        {
            base.Clone(client);
            
            if (client is AzureStackClient)
            {
                AzureStackClient clonedClient = ((AzureStackClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
