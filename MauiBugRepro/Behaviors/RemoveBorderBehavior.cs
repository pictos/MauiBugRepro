using Microsoft.Maui.Controls;

namespace MauiBugRepro.Behaviors;
public partial class RemoveBorder : Behavior<View>
{
	protected override void OnAttachedTo(View bindable)
	{
		base.OnAttachedTo(bindable);
		OnPlatformAttached(bindable);
	}

	protected override void OnDetachingFrom(View bindable)
	{
		base.OnDetachingFrom(bindable);
		OnPlatformDetached(bindable);
	}

	public partial void OnPlatformAttached(View view);

	public partial void OnPlatformDetached(View view);
}