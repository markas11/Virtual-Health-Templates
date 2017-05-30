﻿/* 
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

namespace HealthCare.Web.ErrorHandler
    using System.Web.Mvc;
    using Microsoft.ApplicationInsights;

    /// <summary>
    /// Handles the AI error
    /// </summary>
    /// <seealso cref="System.Web.Mvc.HandleErrorAttribute" />
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)] 
        /// Called when an exception occurs.
        /// </summary>
        /// <param name="filterContext">The action-filter context.</param>
        public override void OnException(ExceptionContext filterContext)