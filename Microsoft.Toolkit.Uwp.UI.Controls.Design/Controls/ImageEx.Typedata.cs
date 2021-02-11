// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Design
{
#if VS_DESIGNER_PROCESS_ISOLATION
    internal static partial class ControlTypes
    {
        internal static readonly Type ImageEx = typeof(ImageEx);
    }
#else
    internal static partial class ControlTypes
    {
        internal const string ImageEx = RootNamespace + "." + nameof(ImageEx);
    }

    internal static class ImageEx
    {
        internal const string NineGrid = nameof(NineGrid);
    }
#endif
}