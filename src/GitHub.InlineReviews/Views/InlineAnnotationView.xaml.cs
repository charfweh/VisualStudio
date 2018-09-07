﻿using System;
using System.Windows.Controls;
using GitHub.VisualStudio.UI.Helpers;

namespace GitHub.InlineReviews.Views
{
    public partial class InlineAnnotationView : UserControl
    {
        public InlineAnnotationView()
        {
            InitializeComponent();
            PreviewMouseWheel += ScrollViewerUtilities.FixMouseWheelScroll;
        }
    }
}
