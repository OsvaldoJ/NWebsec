// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Mvc.Common.Helpers;
using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the manifest-src directive for the CSP header (CSP 3). 
    /// </summary>
    public class CspManifestSrcAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive => CspDirectives.ManifestSrc;

        protected override bool ReportOnly => false;
    }
}