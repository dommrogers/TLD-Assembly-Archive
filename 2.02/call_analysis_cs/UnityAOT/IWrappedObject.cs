using System;

namespace UnityAOT;

public interface IWrappedObject
{
	void SetNativePtr(IntPtr self);

	IntPtr GetNativePtr();
}
