﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Microsoft.AspNetCore.Razor.Evolution
{
    /// <summary>
    /// An abstraction for working with a project containing Razor files.
    /// </summary>
    public abstract class RazorProject
    {
        /// <summary>
        /// Gets a sequence of <see cref="RazorProjectItem"/> under the specific path in the project.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        /// <returns>The sequence of <see cref="RazorProjectItem"/>.</returns>
        public abstract IEnumerable<RazorProjectItem> EnumerateItems(string basePath);

        /// <summary>
        /// Gets a <see cref="RazorProjectItem"/> for the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="RazorProjectItem"/>.</returns>
        public abstract RazorProjectItem GetItem(string path);

        /// <summary>
        /// Gets the sequence of files named <paramref name="fileName"/> that are applicable to the specified path.
        /// </summary>
        /// <param name="path">The path of a project item.</param>
        /// <param name="fileName">The file name to seek.</param>
        /// <returns>A sequence of applicable <see cref="RazorProjectItem"/> instances.</returns>
        /// <remarks>
        /// This method returns paths starting from the directory of <paramref name="path"/> and
        /// traverses to the project root.
        /// e.g.
        /// /Views/Home/View.cshtml -> [ /Views/Home/FileName.cshtml, /Views/FileName.cshtml, /FileName.cshtml ]
        /// </remarks>
        public virtual IEnumerable<RazorProjectItem> FindHierarchicalItems(string path, string fileName)
        {
            EnsureValidPath(path);
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(fileName));
            }

            Debug.Assert(!string.IsNullOrEmpty(path));
            if (path.Length == 1)
            {
                yield break;
            }

            StringBuilder builder;
            var fileNameIndex = path.LastIndexOf('/');
            var length = path.Length;
            Debug.Assert(fileNameIndex != -1);
            if (string.Compare(path, fileNameIndex + 1, fileName, 0, fileName.Length) == 0)
            {
                // If the specified path is for the file hierarchy being constructed, then the first file that applies
                // to it is in a parent directory.
                builder = new StringBuilder(path, 0, fileNameIndex, fileNameIndex + fileName.Length);
                length = fileNameIndex;
            }
            else
            {
                builder = new StringBuilder(path);
            }

            var index = length;
            while (index > 0 && (index = path.LastIndexOf('/', index - 1)) != -1)
            {
                builder.Length = index + 1;
                builder.Append(fileName);

                var itemPath = builder.ToString();
                yield return GetItem(itemPath);
            }
        }

        /// <summary>
        /// Performs validation for paths passed to methods of <see cref="RazorProject"/>.
        /// </summary>
        /// <param name="path">The path to validate.</param>
        protected virtual void EnsureValidPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(Resources.ArgumentCannotBeNullOrEmpty, nameof(path));
            }

            if (path[0] != '/')
            {
                throw new ArgumentException(Resources.RazorProject_PathMustStartWithForwardSlash, nameof(path));
            }
        }
    }
}
