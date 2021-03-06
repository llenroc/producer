﻿using System;

namespace Producer.Functions
{
	public static class EnvironmentVariables
	{
		static Uri _documentDbUri;

		public static Uri DocumentDbUri => _documentDbUri ?? (_documentDbUri = new Uri (DocumentDbUrl));

		public static readonly string DocumentDbUrl = Environment.GetEnvironmentVariable (RemoteDocumentDbUrl);

		public static readonly string DocumentDbKey = Environment.GetEnvironmentVariable (RemoteDocumentDbKey);

		public static readonly string StorageAccountConnection = Environment.GetEnvironmentVariable (AzureWebJobsStorage);

		public static readonly string MediaServicesAccountKey = Environment.GetEnvironmentVariable (AzureMediaServicesKey);

		public static readonly string MediaServicesAccountName = Environment.GetEnvironmentVariable (AzureMediaServicesAccount);

		public static readonly string NotificationHubName = Environment.GetEnvironmentVariable (AzureWebJobsNotificationHubName);

		public static readonly string [] Admins = Environment.GetEnvironmentVariable (AppAdminEmails).ToLower ().Trim (';').Split (';');

		public static readonly string [] Producers = Environment.GetEnvironmentVariable (AppProducerEmails).ToLower ().Trim (';').Split (';');


		public const string AzureWebJobsStorage = nameof (AzureWebJobsStorage);

		public const string AzureMediaServicesKey = nameof (AzureMediaServicesKey);

		public const string AzureMediaServicesAccount = nameof (AzureMediaServicesAccount);

		public const string RemoteDocumentDbUrl = nameof (RemoteDocumentDbUrl);

		public const string RemoteDocumentDbKey = nameof (RemoteDocumentDbKey);

		public const string AppAdminEmails = nameof (AppAdminEmails);

		public const string AppProducerEmails = nameof (AppProducerEmails);

		public const string AzureWebJobsNotificationHubsConnectionString = nameof (AzureWebJobsNotificationHubsConnectionString);

		public const string AzureWebJobsNotificationHubName = nameof (AzureWebJobsNotificationHubName);
	}
}
