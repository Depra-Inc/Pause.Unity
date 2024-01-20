// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;
using UnityEngine.Events;

namespace Depra.Pause
{
	[RequireComponent(typeof(IPauseService))]
	internal sealed class PauseEventForwarder : MonoBehaviour, IPauseListener
	{
		[SerializeField] private UnityEvent _onPaused;
		[SerializeField] private UnityEvent _onResumed;

		void IPauseListener.Pause() => _onPaused.Invoke();

		void IPauseListener.Resume() => _onResumed.Invoke();
	}
}