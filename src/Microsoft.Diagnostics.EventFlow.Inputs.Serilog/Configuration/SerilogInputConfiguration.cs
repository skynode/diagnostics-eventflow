﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Diagnostics.EventFlow.Configuration
{
    /// <summary>
    /// Stores configuration options for <see cref="Microsoft.Diagnostics.EventFlow.Inputs.SerilogInput"/>.
    /// </summary>
    public class SerilogInputConfiguration: ItemConfiguration
    {
        /// <summary>
        /// True if Serilog maxiumum destructuring depth setting should be used, otherwise false.
        /// </summary>
        /// <remarks>Defaults to false (destructuring depth is ignored) for backward compatibility.</remarks>
        public bool UseSerilogDepthLevel { get; set; } = false;
    }
}
