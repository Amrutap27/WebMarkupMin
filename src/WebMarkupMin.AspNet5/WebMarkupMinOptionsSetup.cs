﻿using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Internal;
using Microsoft.Framework.OptionsModel;

namespace WebMarkupMin.AspNet5
{
	/// <summary>
	/// Sets up default options for <see cref="WebMarkupMinOptions"/>
	/// </summary>
	public class WebMarkupMinOptionsSetup : ConfigureOptions<WebMarkupMinOptions>
    {
		/// <summary>
		/// Hosting environment
		/// </summary>
		public IHostingEnvironment _hostingEnvironment;


		/// <summary>
		/// Constructs a instance of <see cref="WebMarkupMinOptionsSetup"/>
		/// </summary>
		public WebMarkupMinOptionsSetup(IHostingEnvironment hostingEnvironment)
			: base(ConfigureWebMarkupMinOptions)
		{
			_hostingEnvironment = hostingEnvironment;
		}


		/// <summary>
		/// Sets a default options
		/// </summary>
		public static void ConfigureWebMarkupMinOptions(WebMarkupMinOptions options)
		{ }

		public override void Configure(
			[NotNull] WebMarkupMinOptions options,
			string name = "")
		{
			options.HostingEnvironment = _hostingEnvironment;

			base.Configure(options, name);
		}
	}
}