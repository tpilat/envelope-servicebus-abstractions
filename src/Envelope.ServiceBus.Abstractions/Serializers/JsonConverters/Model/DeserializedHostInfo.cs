﻿using Envelope.Infrastructure;
using Envelope.ServiceBus.Hosts;

namespace Envelope.ServiceBus.Serializers.JsonConverters.Model;

internal class DeserializedHostInfo : IHostInfo
{
	public string HostName { get; set; }

	public Guid HostId { get; set; }

	public Guid InstanceId { get; set; }

	public HostStatus HostStatus { get; set; }

	public EnvironmentInfo EnvironmentInfo { get; set; }
}
