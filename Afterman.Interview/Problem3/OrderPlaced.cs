﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Afterman.Interview.Problem3
{
    public class OrderPlaced :
        IEvent
    {
        public Guid OrderId { get; set; }
    }
}
