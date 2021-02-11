// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

#if VS_DESIGNER_PROCESS_ISOLATION
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.Model;
#else
using Microsoft.VisualStudio.DesignTools.Extensibility;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
using Microsoft.VisualStudio.DesignTools.Extensibility.Model;
#endif

namespace Microsoft.Toolkit.Uwp.UI.Controls.Design
{
    internal class RadialProgressBarDefaults : DefaultInitializer
    {
        public override void InitializeDefaults(ModelItem item)
        {
            item.Properties[nameof(RadialProgressBar.Value)].SetValue(0d);
        }
    }

    internal class RadialProgressBarMetadata : AttributeTableBuilder
    {
        public RadialProgressBarMetadata()
            : base()
        {
            AddCallback(ControlTypes.RadialProgressBar,
                b =>
                {
                    b.AddCustomAttributes(new FeatureAttribute(typeof(RadialProgressBarDefaults)));
                    b.AddCustomAttributes(nameof(RadialProgressBar.Thickness), new CategoryAttribute(Properties.Resources.CategoryAppearance));
                    b.AddCustomAttributes(nameof(RadialProgressBar.Outline), new CategoryAttribute(Properties.Resources.CategoryBrush));
                    b.AddCustomAttributes(new ToolboxCategoryAttribute(ToolboxCategoryPaths.Toolkit, false));
                }
            );
        }
    }
}
