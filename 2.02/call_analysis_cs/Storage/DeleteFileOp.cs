using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class DeleteFileOp : AsyncOp<DeleteFileOp>
{
	public delegate void DeleteFileDelegate(TitleStorage storage, DeleteFileOp op);

	public TitleStorage Storage;

	private DeleteFileDelegate Callback;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DeleteFileOp(TitleStorage storage, DeleteFileDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Complete(uint result)
	{
	}
}
