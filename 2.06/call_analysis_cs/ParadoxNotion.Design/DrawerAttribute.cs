using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public abstract class DrawerAttribute : Attribute
{
	public virtual int priority
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected DrawerAttribute()
	{
	}
}
