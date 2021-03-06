﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zorbo.Core
{
    public interface IConfig
    {
        /// <summary>
        /// Configurable directory locations for common files (not serialized to Json)
        /// </summary>
        IDirectories Directories { get; set; }
        /// <summary>
        /// The default name
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Default avatar
        /// </summary>
        byte[] Avatar { get; set; }
        /// <summary>
        /// True if private messaging is supported, otherwise false
        /// </summary>
        bool AllowPrivate { get; set; }
        /// <summary>
        /// True if packet compression is supported, otherwise false
        /// </summary>
        bool AllowCompression { get; set; }
        /// <summary>
        /// True if packet encryption is supported, otherwise false
        /// </summary>
        bool AllowEncryption { get; set; }
        /// <summary>
        /// True if voice packets are enabled, otherwise false
        /// </summary>
        bool AllowVoice { get; set; }
    }
}
