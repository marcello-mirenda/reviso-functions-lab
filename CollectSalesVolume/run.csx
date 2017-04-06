#r "TestJobsReviso.dll"

using System.Net;
using TestJobsReviso;

public static async Task<HttpResponseMessage> Run(IAsyncCollector<SalesVolume> salesVolume, HttpRequestMessage req, TraceWriter log)
{
	return await Jobs.CollectSalesVolumeAsync(salesVolume, req, log);
}