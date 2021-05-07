﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See License.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLineDotnetCore.Infrastructure
{
    static class ExceptionExtensions
    {
        public static void RethrowWhenAbsentIn(this Exception exception, IEnumerable<Type> validExceptions)
        {
            if (!validExceptions.Contains(exception.GetType()))
            {
                throw exception;
            }
        }
    }
}
