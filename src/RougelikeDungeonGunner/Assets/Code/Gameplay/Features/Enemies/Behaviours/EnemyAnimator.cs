﻿using Code.Gameplay.Common.Visuals;
using Code.Gameplay.Features.Hero.Behaviours;
using DG.Tweening;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Behaviours
{
	public class EnemyAnimator : MonoBehaviour, IDamageTakenAnimator
	{
		private static readonly int OverlayIntensityProperty = Shader.PropertyToID("_OverlayIntensity");


		[SerializeField] private Animator _animator;
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private readonly int _isIdling = Animator.StringToHash("isIdling");
		private readonly int _isMoving = Animator.StringToHash("isMoving");

		private readonly int _aimUp = Animator.StringToHash("aimUp");
		private readonly int _aimUpRight = Animator.StringToHash("aimUpRight");
		private readonly int _aimUpLeft = Animator.StringToHash("aimUpLeft");
		private readonly int _aimRight = Animator.StringToHash("aimRight");
		private readonly int _aimLeft = Animator.StringToHash("aimLeft");
		private readonly int _aimDown = Animator.StringToHash("aimDown");

		private readonly int _diedHash = Animator.StringToHash("died");

		private Material Material => _spriteRenderer.material;

		public void StartIdling() => _animator.SetBool(_isIdling, true);
		public void StopIdling() => _animator.SetBool(_isIdling, false);

		public void StartMoving() => _animator.SetBool(_isMoving, true);
		public void StopMoving() => _animator.SetBool(_isMoving, false);

		public void StartAimUp() => _animator.SetBool(_aimUp, true);
		public void StopAimUp() => _animator.SetBool(_aimUp, false);

		public void StartAimUpRight() => _animator.SetBool(_aimUpRight, true);
		public void StopAimUpRight() => _animator.SetBool(_aimUpRight, false);

		public void StartAimUpLeft() => _animator.SetBool(_aimUpLeft, true);
		public void StopAimUpLeft() => _animator.SetBool(_aimUpLeft, false);

		public void StartAimRight() => _animator.SetBool(_aimRight, true);
		public void StopAimRight() => _animator.SetBool(_aimRight, false);

		public void StartAimLeft() => _animator.SetBool(_aimLeft, true);
		public void StopAimLeft() => _animator.SetBool(_aimLeft, false);

		public void StartAimDown() => _animator.SetBool(_aimDown, true);
		public void StopAimDown() => _animator.SetBool(_aimDown, false);

		public void PlayDied() => _animator.SetTrigger(_diedHash);

		public void PlayDamageTaken()
		{
			if (DOTween.IsTweening(Material))
				return;

			Material.DOFloat(0.4f, OverlayIntensityProperty, 0.15f)
				.OnComplete(() =>
				{
					if (_spriteRenderer)
						Material.DOFloat(0, OverlayIntensityProperty, 0.15f);
				});
		}

		public void ResetAll()
		{
			_animator.ResetTrigger(_diedHash);
		}
	}
}