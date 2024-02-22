using System;
using boxpoker.network.Core;

namespace boxpoker.network.Repository
{
	public interface INetworkRepository
	{
		Task<AuthResponse> GetAuthPixToken();
	}
}