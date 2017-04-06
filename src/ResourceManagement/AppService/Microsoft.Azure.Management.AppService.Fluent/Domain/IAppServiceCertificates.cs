// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using AppServiceCertificate.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Entry point for certificate management API.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in future releases, including removal, regardless of any compatibility expectations set by the containing library version number.)
    /// </remarks>
    public interface IAppServiceCertificates  :
        ISupportsCreating<AppServiceCertificate.Definition.IBlank>,
        ISupportsDeletingById,
        ISupportsListingByResourceGroup<Microsoft.Azure.Management.AppService.Fluent.IAppServiceCertificate>,
        ISupportsListing<Microsoft.Azure.Management.AppService.Fluent.IAppServiceCertificate>,
        ISupportsGettingByResourceGroup<Microsoft.Azure.Management.AppService.Fluent.IAppServiceCertificate>,
        ISupportsGettingById<Microsoft.Azure.Management.AppService.Fluent.IAppServiceCertificate>,
        ISupportsDeletingByResourceGroup,
        IHasManager<IAppServiceManager>,
        IHasInner<ICertificatesOperations>
    {
    }
}