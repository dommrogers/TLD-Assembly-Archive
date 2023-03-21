using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public abstract class DrawerAttribute : Attribute
{
	public virtual int priority
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
