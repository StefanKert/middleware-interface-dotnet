﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace fiskaltrust.ifPOS.v1.de
{
    [DataContract]
    public class EndExportSessionResponse
    {
        [DataMember(Order = 10)]
        StartExportSessionResponse Session { get; set; }

        [DataMember(Order = 20)]
        bool IsValid { get; set; }

        [DataMember(Order = 30)]
        bool IsErased { get; set; }
    }
}
