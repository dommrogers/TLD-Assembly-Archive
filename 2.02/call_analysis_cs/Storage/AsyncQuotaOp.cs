using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class AsyncQuotaOp : AsyncOp<AsyncQuotaOp>
{
	public delegate void QuotaRequestDelegate(TitleStorage storage, AsyncQuotaOp op, StorageQuota quota);

	public TitleStorage Storage;

	public StorageQuota Quota;

	private QuotaRequestDelegate Callback;

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TitleStorage), Member = "RequestQuotaAsync")]
	public AsyncQuotaOp(TitleStorage storage, QuotaRequestDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Complete(uint result, StorageQuota quota)
	{
	}
}
