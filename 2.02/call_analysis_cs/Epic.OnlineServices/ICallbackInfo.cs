namespace Epic.OnlineServices;

internal interface ICallbackInfo
{
	object ClientData { get; }

	Result? GetResultCode();
}
