// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;
using UnityEngine.Events;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[RequireComponent(typeof(IPauseService))]
	[AddComponentMenu(MENU_PATH + nameof(PauseEventForwarding), DEFAULT_ORDER)]
	internal sealed class PauseEventForwarding : MonoBehaviour, IPauseListener
	{
		[SerializeField] private UnityEvent _onPaused;
		[SerializeField] private UnityEvent _onResumed;

		void IPauseListener.Pause() => _onPaused.Invoke();

		void IPauseListener.Resume() => _onResumed.Invoke();
	}
}