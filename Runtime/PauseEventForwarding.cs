// SPDX-License-Identifier: Apache-2.0
// © 2023-2025 Depra <n.melnikov@depra.org>

using UnityEngine;
using UnityEngine.Events;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[AddComponentMenu(MENU_PATH + nameof(PauseEventForwarding), DEFAULT_ORDER)]
	internal sealed class PauseEventForwarding : ScenePauseListener
	{
		[SerializeField] private UnityEvent _onPaused;
		[SerializeField] private UnityEvent _onResumed;

		public override void OnPause() => _onPaused.Invoke();

		public override void OnResume() => _onResumed.Invoke();
	}
}