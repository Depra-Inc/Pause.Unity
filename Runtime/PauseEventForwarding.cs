// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;
using UnityEngine.Events;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[RequireComponent(typeof(IPauseService))]
	[AddComponentMenu(MENU_PATH + nameof(PauseEventForwarding), DEFAULT_ORDER)]
	internal sealed class PauseEventForwarding : ScenePauseListener
	{
		[SerializeField] private UnityEvent _onPaused;
		[SerializeField] private UnityEvent _onResumed;

		public override void Pause() => _onPaused.Invoke();

		public override void Resume() => _onResumed.Invoke();
	}
}