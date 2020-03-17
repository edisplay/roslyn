﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildBoss
{
    internal static class Extensions
    {
        internal static string GetRelativeName(this PackagePart part)
        {
            var relativeName = part.Uri.ToString().Replace('/', '\\');
            if (!string.IsNullOrEmpty(relativeName) && relativeName[0] == '\\')
            {
                relativeName = relativeName.Substring(1);
            }

            return relativeName;
        }

        internal static string GetName(this PackagePart part) => Path.GetFileName(GetRelativeName(part));
    }
}
