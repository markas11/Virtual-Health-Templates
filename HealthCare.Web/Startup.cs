﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Microsoft">
//     Copyright © Microsoft, 2016
// </copyright>
// <summary>
//     The class.
// </summary>
// <auto-generated />
//  -------------------------------------------------------------------------------------------------------------------

using Microsoft.Owin;

[assembly: OwinStartup(typeof(HealthCare.Web.Startup))]

namespace HealthCare.Web
{
  using Owin;

  /// <summary>
  /// Startup Class
  /// </summary>
  public partial class Startup
  {
    /// <summary>
    /// Configurations the specified application.
    /// </summary>
    /// <param name="app">The application.</param>
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
    }
  }
}
